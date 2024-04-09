using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat.Interfaces
{
    internal interface ISpell
    {
        string Name { get; }
        Damage damage { get; }
        int AirDamage {  get; }
        int EarthDamage { get; }
        int FireDamage { get; }
        int WaterDamage { get; }
    }
}
