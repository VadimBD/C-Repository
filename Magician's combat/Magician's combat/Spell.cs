using Magician_s_combat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat
{
    internal abstract class Spell : ISpell
    {
        private readonly IDamager _damager;

        public abstract string Name { get; }
        
        public virtual Damage damage => new Damage()
        {
            AirDamage = (int)(AirDamage * _damager.AirMultiplicator),
            EarthDamage = (int)(EarthDamage * _damager.EarthMultiplicator),
            FireDamage = (int)(FireDamage * _damager.FireMultiplicator),
            WaterDamage = (int)(WaterDamage * _damager.WaterMultiplicator)
        };
        public abstract int AirDamage { get; }

        public abstract int EarthDamage { get; }

        public abstract int FireDamage { get; }

        public abstract int WaterDamage { get; }

        public Spell(IDamager damager)
        {
            _damager = damager;
        }
    }
}
