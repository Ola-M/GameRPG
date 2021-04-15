using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    class Ogre : Champion
    {
        public Ogre(string name) : base(name)
        {
            StartingHp = 300;
            Race = GetType().Name;
            ChanceToMiss = 2;
            AttackStrength = 20;
            CurrentHp = StartingHp;
            SpecialAbilitiesList = new List<SpecialAbility>();

        }
        public override List<SpecialAbility> Skill()
        {
            SpecialAbilitiesList.Add(new SpecialAbility("Pierd", 25));
            SpecialAbilitiesList.Add(new SpecialAbility("Cios maczugą", 30));
            return SpecialAbilitiesList;
        }

    }
}
