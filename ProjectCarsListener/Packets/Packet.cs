using System.Runtime.InteropServices;

using u16 = System.UInt16;
using u8 = System.Byte;

namespace ProjectCarsListener.Packets
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class Packet
    {
        public u16 sBuildVersionNumber;
        public u8 sSeqPacket;

        public u8 SequenceNumber
        {
            get { return (byte)(sSeqPacket & 0xFC >> 2); }
        }

        public u8 PacketType
        {
            get { return (byte)(sSeqPacket & 0x3); }
        }
    }
}