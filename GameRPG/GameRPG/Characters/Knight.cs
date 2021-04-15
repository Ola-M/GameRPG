using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    class Knight : Champion
    {
        public Knight( string name ) : base(name)
        {
            StartingHp = 200;
            Race = GetType().Name;
            ChanceToMiss = 5;
            AttackStrength = 35;
            CurrentHp = StartingHp;
            SpecialAbilitiesList = new List<SpecialAbility>();
        }

        public override List<SpecialAbility> Skill()
        {
            SpecialAbilitiesList.Add(new SpecialAbility("Cios Mieczem", 50));
            SpecialAbilitiesList.Add(new SpecialAbility("Błędny ryczerz", 45));
            return SpecialAbilitiesList;
        }
    }
}
