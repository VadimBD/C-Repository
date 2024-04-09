using Magician_s_combat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat
{
    internal class Wave : Spell
    {

        public override string Name => "Wave";

        public override int AirDamage =>0;

        public override int EarthDamage =>0;

        public override int FireDamage => 0;

        public override int WaterDamage => 10;

        public Wave(IDamager damager) : base(damager)
        {
        }
    }
}
