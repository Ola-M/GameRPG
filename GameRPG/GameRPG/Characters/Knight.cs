using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    class Knight : Champion
    {
        public Knight( string name) : base(name)
        {
            Hp = 200;
            race = GetType().Name;
            miss = 5;
            strength = 35;
            _name = name;
            currentHp = Hp;

        }


        public override List<SpecialAbility> Skill()
        {
            List<SpecialAbility> skill = new List<SpecialAbility>();
            skill.Add(new SpecialAbility("Cios Mieczem", 50));
            skill.Add(new SpecialAbility("Błędny ryczerz", 45));
            return skill;
        }
    }
}
