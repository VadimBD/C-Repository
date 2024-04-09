using Magician_s_combat.Enams;
using Magician_s_combat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat
{
    internal class EarthWizard : Wizard
    {
        public EarthWizard(string name)
        {
            Skin = "(/￣ー￣)/~~☆’.･.･:★’.･.･:☆";
            Name = name;
            _spells.Add("Metiorite", new Metiorite(this));
        }

        public override float AirMultiplicator =>0;

        public override float EarthMultiplicator => 3;

        public override float FireMultiplicator => 0;

        public override float WaterMultiplicator => 0;
        protected override int TakeHit(ISpell spell)
        {
            var damage = spell.damage;
            var totaldamage = (int)(damage.AirDamage + damage.FireDamage + damage.EarthDamage * 0.5 + damage.WaterDamage);
            _health = Health > totaldamage ? Health - totaldamage : 0;
            _alive = Health > 0;
            return totaldamage;
        }
    }
}
