using ProjectCarsListener.Enums;
using System.Runtime.InteropServices;

using f32 = System.Single;
using s16 = System.Int16;
using s8 = System.SByte;
using u16 = System.UInt16;
using u8 = System.Byte;

namespace ProjectCarsListener.Packets
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class sTelemetryData : Packet
    {
        public u8 sGameSessionState;

        // participant info
        public s8 sViewedParticipantIndex;

        public s8 sNumParticipants;

        // unfiltered input
        public u8 sUnfilteredThrottle;

        public u8 sUnfilteredBrake;
        public s8 sUnfilteredSteering;
        public u8 sUnfilteredClutch;
        public u8 sRaceStateFlags;

        // event information
        public u8 sLapsInEvent;

        // timings
        public f32 sBestLapTime;

        public f32 sLastLapTime;
        public f32 sCurrentTime;
        public f32 sSplitTimeAhead;
        public f32 sSplitTimeBehind;
        public f32 sSplitTime;
        public f32 sEventTimeRemaining;
        public f32 sPersonalFastestLapTime;
        public f32 sWorldFastestLapTime;
        public f32 sCurrentSector1Time;
        public f32 sCurrentSector2Time;
        public f32 sCurrentSector3Time;
        public f32 sFastestSector1Time;
        public f32 sFastestSector2Time;
        public f32 sFastestSector3Time;
        public f32 sPersonalFastestSector1Time;
        public f32 sPersonalFastestSector2Time;
        public f32 sPersonalFastestSector3Time;
        public f32 sWorldFastestSector1Time;
        public f32 sWorldFastestSector2Time;
        public f32 sWorldFastestSector3Time;

        public u16 sJoypad;

        // flags
        public u8 sHighestFlag;

        // pit info
        public u8 sPitModeSchedule;

        // car state
        public s16 sOilTempCelsius;

        public u16 sOilPressureKPa;
        public s16 sWaterTempCelsius;
        public u16 sWaterPressureKPa;
        public u16 sFuelPressureKPa;
        public u8 sCarFlags;
        public u8 sFuelCapacity;
        public u8 sBrake;
        public u8 sThrottle;
        public u8 sClutch;
        public s8 sSteering;
        public f32 sFuelLevel;
        public f32 sSpeed;
        public u16 sRpm;
        public u16 sMaxRpm;
        public u8 sGearNumGears;
        public u8 sBoostAmount;
        public s8 sEnforcedPitStopLap;
        public u8 sCrashState;

        public f32 sOdometerKM;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public f32[] sOrientation;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public f32[] LocalVelocity;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public f32[] WorldVelocity;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public f32[] AngularVelocity;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public f32[] LocalAcceleration;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public f32[] WorldAcceleration;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public f32[] ExtentsCentre;

        // wheels / tyres
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u8[] sTyreFlags;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u8[] sTerrain;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public f32[] sTyreY;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public f32[] sTyreRPS;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public f32[] sTyreSlipSpeed;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u8[] sTyreTemp;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u8[] sTyreGrip;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public f32[] sTyreHeightAboveGround;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public f32[] sTyreLateralStiffness;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u8[] sTyreWear;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u8[] sBrakeDamage;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u8[] sSuspensionDamage;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public s16[] sBrakeTempCelsius;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u16[] sTyreTreadTemp;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u16[] sTyreLayerTemp;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u16[] sTyreCarcassTemp;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u16[] sTyreRimTemp;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u16[] sTyreInternalAirTemp;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public f32[] sWheelLocalPositionY;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public f32[] sRideHeight;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public f32[] sSuspensionTravel;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public f32[] sSuspensionVelocity;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public u16[] sAirPressure;

        // extras
        public f32 sEngineSpeed;

        public f32 sEngineTorque;

        // car damage
        public u8 sAeroDamage;

        public u8 sEngineDamage;

        // weather
        public s8 sAmbientTemperature;

        public s8 sTrackTemperature;
        public u8 sRainDensity;
        public s8 sWindSpeed;
        public s8 sWindDirectionX;
        public s8 sWindDirectionY;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        public sParticipantInfo[] sParticipantInfo;

        public f32 sTrackLength;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public u8[] sWings;

        public u8 sDPad;

        public GameState GameState { get { return (GameState)(sGameSessionState & 0x07); } }
        public SessionState SessionState { get { return (SessionState)(sGameSessionState >> 4); } }
        public CarFlags CarFlags { get { return (CarFlags)sCarFlags; } }
        public FlagColour FlagColour { get { return (FlagColour)(sHighestFlag & 0x07); } }
        public FlagReason FlagReason { get { return (FlagReason)(sHighestFlag >> 4); } }
        public PitMode PitMode { get { return (PitMode)(sPitModeSchedule & 0x07); } }
        public PitSchedule PitSchedule { get { return (PitSchedule)(sPitModeSchedule >> 4); } }
        public RaceState RaceState { get { return (RaceState)(sRaceStateFlags & 0x07); } }
        public bool LapInvalidated { get { return (sRaceStateFlags & 8) > 0; } }
        public bool AntiLockActive { get { return (sRaceStateFlags & 16) > 0; } }
        public bool BoostActive { get { return (sRaceStateFlags & 32) > 0; } }

        public byte Gear { get { return (byte)(sGearNumGears & 0x0F); } }
        public byte NumGears { get { return (byte)((sGearNumGears & 0xF0) >> 4); } }
    }
}