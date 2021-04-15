using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    class Princess : Champion
    {
        
        public Princess(string name) : base(name)
        {
            StartingHp = 150;
            Race = GetType().Name;
            ChanceToMiss = 20;
            AttackStrength = 30; 
            CurrentHp = StartingHp;
            SpecialAbilitiesList = new List<SpecialAbility>();
        }

        public override List<SpecialAbility> Skill()
        {
            SpecialAbilitiesList.Add(new SpecialAbility("Kopnięcie z półobrotu", 40));
            SpecialAbilitiesList.Add(new SpecialAbility("Przerźliwy krzyk", 35));
            return SpecialAbilitiesList;
        }
    }
}
