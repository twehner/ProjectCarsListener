using System;

namespace ProjectCarsListener.Enums
{
    [Flags]
    public enum TireFlags : byte
    {
        ATTACHED = 1,
        INFLATED = 2,
        IS_ON_GROUND = 4
    }
}