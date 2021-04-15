using GameRPG.Characters;
using GameRPG.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class SpecialAbilityHelper : ISpecialAbilityHelper
    {
        IConsoleLogService _consoleLogService;
        public SpecialAbilityHelper(IConsoleLogService consoleLogService)
        {
            _consoleLogService = consoleLogService;
        }
       public bool Miss(int miss)
        {
            Random random = new Random();
            int chance = random.Next(101);
            if(miss >= chance)
            {
                return true;
            }
            return false;
        }
        public void SpecialAttack(Champion heroAttacked, Champion attackingHero)
        {
            Random random = new Random();
            var specialAttack = attackingHero.Skill();            
            var index = random.Next(specialAttack.Count);
            heroAttacked.CurrentHp -= specialAttack[index].PointsAttack;
            _consoleLogService.SpecialAttack(attackingHero.Race, attackingHero.Name, specialAttack[index].Name);
        }

        public bool ChanceOfSpecialAttac()
        {
            Random random = new Random();
            bool randomBool = random.Next(2) == 1;
            return randomBool;
        }


    }
}
