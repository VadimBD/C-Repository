using Magician_s_combat.Enams;
using Magician_s_combat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat
{
    internal abstract class Wizard : IWizard, IDamager, IDamaged
    {
        protected bool _alive=true;
        protected int _health=100;
        protected Dictionary<string,ISpell> _spells=new Dictionary<string, ISpell>();
        protected int _level=1;
        public string Name { get; init; }=string.Empty;

        public Dictionary<string, ISpell> Spells { get => _spells; }

        public int Health { get => _health; }

        public string Skin { get; init; } = string.Empty;

        public int Level { get => _level; }

        public bool Alive { get => _alive;}

        public abstract float AirMultiplicator { get; }

        public abstract float EarthMultiplicator { get; }

        public abstract float FireMultiplicator { get; }

        public abstract float WaterMultiplicator { get; }
        public int GetHit(ISpell spell)
        { 
             var result=TakeHit(spell);
            if (GetHitEvent != null)
                GetHitEvent(this, new() { Damage= result, Alive=Alive,Health=Health});
            return result;
        }
        protected abstract int TakeHit(ISpell spell);


        public delegate void GetHitEventHandler(object sender,GetHitArgs args);
        public event GetHitEventHandler GetHitEvent;
    }

    internal class GetHitArgs
    {
        public int Damage { get; init; }
        public bool Alive { get; init; }
        public int Health { get; init; }
    }

}
