using Magician_s_combat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat
{
    internal class Metiorite : Spell
    {
        public override string Name => "Metiorite";

        public override int AirDamage =>0;

        public override int EarthDamage => 15;

        public override int FireDamage => 6;

        public override int WaterDamage => 0;
        public Metiorite(IDamager damager) : base(damager)
        {
        }
    }
}
