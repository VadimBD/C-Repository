﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magician_s_combat.Interfaces
{
    internal interface IDamaged
    {
        public int GetHit(ISpell spell);
    }
}
