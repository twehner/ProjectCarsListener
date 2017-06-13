using ProjectCarsListener.Types;
using System.Runtime.InteropServices;

using u8 = System.Byte;

namespace ProjectCarsListener.Packets
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public class sParticipantInfoStringsAdditional : Packet
    {
        public u8 sOffset;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public C64String[] sName;
    }
}