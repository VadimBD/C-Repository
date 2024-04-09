using Magician_s_combat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat
{
    internal class FireBall : Spell
    {
        public override string Name => "FireBall";

        public override int AirDamage => 0;

        public override int EarthDamage => 0;

        public override int FireDamage => 6;

        public override int WaterDamage => 0;

        public FireBall(IDamager damager) :base(damager)
        { 
        
        }
    }
}
