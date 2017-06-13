using System;

namespace ProjectCarsListener.Enums
{
    [Flags]
    public enum CarFlags : byte
    {
        HEADLIGHT = 1,
        ENGINE_ACTIVE = 2,
        ENGINE_WARNING = 4,
        SPEED_LIMITER = 8,
        ABS = 16,
        HANDBRAKE = 32
    }
}