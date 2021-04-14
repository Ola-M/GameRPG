using GameRPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class SpecialAbility : ISpecialAbility
    {
        
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
        public void SpecialAttac(Champion champion)
        {
            Random random = new Random();
            var specialAttac = random.Next(champion.Skill().Count);


            
        }

        
    }
}
