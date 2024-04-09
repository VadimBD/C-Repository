using Magician_s_combat.Enams;
using Magician_s_combat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat
{
    internal class AirWizard:Wizard
    {
        public AirWizard(string name)
        {
            Skin = "(ノ ˘_˘)ノ ζ|||ζ ζ|||ζ ζ|||ζ";
            Name = name;
            _spells.Add("Tornado", new Tornado(this));
        }

        public override float AirMultiplicator =>2*Level/10;

        public override float EarthMultiplicator => 0;

        public override float FireMultiplicator =>(float) 0.5;

        public override float WaterMultiplicator => 0;

        protected override int TakeHit(ISpell spell)
        {
           var damage=spell.damage;
           var totaldamage=(int)(damage.AirDamage*0.5+damage.FireDamage+ damage.EarthDamage + damage.WaterDamage);
            _health= Health>totaldamage?Health-totaldamage:0;
            _alive = Health > 0;
            return totaldamage;
        }
    }
}
