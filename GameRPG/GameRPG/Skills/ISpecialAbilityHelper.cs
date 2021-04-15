using GameRPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
     interface ISpecialAbilityHelper
    {
      bool Miss(int miss);
        void SpecialAttack(Champion heroAttacked, Champion attackingHero);
        bool ChanceOfSpecialAttac();
    }
}
