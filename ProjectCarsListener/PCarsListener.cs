using ProjectCarsListener.Packets;
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace ProjectCarsListener
{
    public class ProjectCarsListener
    {
        public event TelemetryEventHandler Telemetry;

        public event ParticipantInfoStringsHandler ParticipantInfoStrings;

        public event ParticipantInfoStringsAdditionalHandler ParticipantInfoStringsAdditional;

        private readonly int _port;
        private readonly UdpClient _udpClient;
        private bool _enabled;

        public ProjectCarsListener(int port = 5606)
        {
            _port = port;
            _udpClient = new UdpClient()
            {
                ExclusiveAddressUse = false
            };
            _udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            _udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, _port));
        }

        public void Start()
        {
            if (!_enabled)
            {
                _enabled = true;
                _udpClient.BeginReceive(new AsyncCallback(Receive), null);
            }
        }

        public void Stop()
        {
            _enabled = false;
        }

        private void Receive(IAsyncResult res)
        {
            var groupEP = new IPEndPoint(IPAddress.Any, _port + 1);
            var data = _udpClient.EndReceive(res, ref groupEP);

            var packet = ToClass<Packet>(data);

            if (_enabled)
            {
                switch (packet.PacketType)
                {
                    case 0:
                        var telemetry = ToClass<sTelemetryData>(data);
                        if (Telemetry != null)
                            Telemetry(telemetry);
                        break;

                    case 1:
                        var participantInfo = ToClass<sParticipantInfoStrings>(data);
                        if (ParticipantInfoStrings != null)
                            ParticipantInfoStrings(participantInfo);
                        break;

                    case 2:
                        var additionalParticipantInfo = ToClass<sParticipantInfoStringsAdditional>(data);
                        if (ParticipantInfoStringsAdditional != null)
                            ParticipantInfoStringsAdditional(additionalParticipantInfo);
                        break;
                }

                _udpClient.BeginReceive(new AsyncCallback(Receive), null);
            }
        }

        private T ToClass<T>(byte[] arr) where T : new()
        {
            T cls = new T();
            var size = Marshal.SizeOf(cls);
            var ptr = Marshal.AllocHGlobal(size);
            Marshal.Copy(arr, 0, ptr, size);
            cls = (T)Marshal.PtrToStructure<T>(ptr);
            Marshal.FreeHGlobal(ptr);
            return cls;
        }
    }

    public delegate void TelemetryEventHandler(sTelemetryData telemetry);

    public delegate void ParticipantInfoStringsHandler(sParticipantInfoStrings participantInfoStrings);

    public delegate void ParticipantInfoStringsAdditionalHandler(sParticipantInfoStringsAdditional participantInfoStringsAdditional);
}