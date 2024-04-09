using Magician_s_combat.Enams;
using Magician_s_combat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat
{
    internal class FireWizard : Wizard
    {

       public FireWizard(string name) 
        {
            Skin = "(∩•̀ω•́)⊃-*⋆";
            Name = name;
            _spells.Add("Metiorite", new Metiorite(this));
            _spells.Add("FireBall", new FireBall(this));
        }


        public override float AirMultiplicator => 0;

        public override float EarthMultiplicator =>0;

        public override float FireMultiplicator =>3;

        public override float WaterMultiplicator => 0;
        protected override int TakeHit(ISpell spell)
        {
            var damage = spell.damage;
            var totaldamage = (int)(damage.AirDamage + damage.FireDamage * 0.5 + damage.EarthDamage + damage.WaterDamage );
            _health = Health > totaldamage ? Health - totaldamage : 0;
            _alive = Health > 0;
            return totaldamage;
        }

    }
}
