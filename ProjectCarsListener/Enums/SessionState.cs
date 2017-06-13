using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarsListener.Enums
{
    public enum SessionState : byte
    {
        INVALID = 0,
        PRACTICE = 1,
        TEST = 2,
        QUALIFY = 3,
        FORMATION_LAP = 4,
        RACE = 5,
        TIME_ATTACK = 6
    }
}
