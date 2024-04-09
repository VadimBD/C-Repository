using Magician_s_combat.Enams;
using Magician_s_combat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat
{
    internal class WaterWizard : Wizard
    {

        public WaterWizard(string name)
        {
            Skin = "(∩` ﾛ ´)⊃━炎炎炎炎炎";
            Name = name;
            _spells.Add("Wave", new Wave(this));
        }

        public override float AirMultiplicator => 0;

        public override float EarthMultiplicator =>0;

        public override float FireMultiplicator =>0;

        public override float WaterMultiplicator =>3;

        protected override int TakeHit(ISpell spell)
        {
            var damage = spell.damage;
            var totaldamage = (int)(damage.AirDamage + damage.FireDamage + damage.EarthDamage + damage.WaterDamage * 0.5);
            _health = Health > totaldamage ? Health - totaldamage : 0;
            _alive = Health > 0;
            return totaldamage;
        }
    }
}

