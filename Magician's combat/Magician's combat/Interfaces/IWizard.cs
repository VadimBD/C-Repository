using Magician_s_combat.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Magician_s_combat.Wizard;

namespace Magician_s_combat.Interfaces
{
    internal interface IWizard
    {
        string Name { get; init; }
        int Health { get;  }
        string Skin {get; init;}
        bool Alive { get;}
        Dictionary<string, ISpell> Spells { get; }
        event GetHitEventHandler GetHitEvent;
    }

}
