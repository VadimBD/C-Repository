using Magician_s_combat.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat.Interfaces
{
    internal interface IDamager
    {
        float AirMultiplicator { get; }
        float EarthMultiplicator { get; }
        float FireMultiplicator { get; }
        float WaterMultiplicator { get; }
    }
}
