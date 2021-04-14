using GameRPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class SpecialAbilityHelper : ISpecialAbilityHelper
    {
        SpecialAbility specialAbility = new SpecialAbility();
        
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
        public void SpecialAttac(Champion heroAttacked, Champion attackingHero)
        {
            Random random = new Random();
            var specialAttac = attackingHero.Skill();            
            var index = random.Next(specialAttac.Count);
            heroAttacked.Hp -= specialAttac[index].PointsAttack;
            Log.Info(attackingHero.race + " " + attackingHero._name + " zadał cios " + specialAttac[index].Name);
        }

        public bool ChanceOfSpecialAttac()
        {
            Random random = new Random();
            bool randomBool = random.Next(2) == 1;
            return randomBool;
        }


    }
}
