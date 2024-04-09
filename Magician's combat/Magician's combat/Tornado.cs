using Magician_s_combat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat
{
    internal class Tornado : Spell
    {
      
        public override string Name => "Tornado";

        public override int AirDamage => 7;

        public override int EarthDamage => 1;

        public override int FireDamage =>0;

        public override int WaterDamage => 0;
        public Tornado(IDamager damager) : base(damager)
        {
        }
    }
}
