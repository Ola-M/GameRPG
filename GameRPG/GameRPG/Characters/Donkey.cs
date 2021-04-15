using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    class Donkey : Champion
    {
        public Donkey(string name ) : base(name)
        {
            StartingHp = 80;
            Race = GetType().Name;
            ChanceToMiss = 10;
            AttackStrength = 40;
            CurrentHp = StartingHp;
            SpecialAbilitiesList = new List<SpecialAbility>();            
        }

        public override List<SpecialAbility> Skill()
        {
            SpecialAbilitiesList.Add(new SpecialAbility("Zatrute ugryzienie", 50));
            SpecialAbilitiesList.Add(new SpecialAbility("Stanięcie Dęba ", 55));
            return SpecialAbilitiesList;
        }

    }
}
