using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    class Knight : Champion
    {
        public Knight(int Hp, string race, int miss, int strenght)
        {
            Hp = 200;
            race = GetType().Name;
            miss = 5;
            strenght = 35;

        }
        public Knight(string name) : base(name)
        {
            _name = name;
        }
        public override List<Skill> SpecialAbility()
        {
            List<Skill> specialAbility = new List<Skill>();
            specialAbility.Add(new Skill("Cios Mieczem", 50));
            specialAbility.Add(new Skill("Błędny ryczerz", 45));
            return specialAbility;
        }
    }
}
