using ProjectCarsListener.Types;
using System.Runtime.InteropServices;

using f32 = System.Single;

namespace ProjectCarsListener.Packets
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public class sParticipantInfoStrings : Packet
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string sCarName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string sCarClassName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string sTrackLocation;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string sTrackVariation;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public C64String[] sName;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public f32[] sFastestLapTime;
    }
}