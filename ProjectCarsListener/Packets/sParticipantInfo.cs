using System.Runtime.InteropServices;

using f32 = System.Single;
using s16 = System.Int16;
using u16 = System.UInt16;
using u8 = System.Byte;

namespace ProjectCarsListener.Packets
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sParticipantInfo
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public s16[] sWorldPosition;

        public u16 sCurrentLapDistance;
        public u8 sRacePosition;
        public u8 sLapsCompleted;
        public u8 sCurrentLap;
        public u8 sSector;
        public f32 sLastSectorTime;
    }
}