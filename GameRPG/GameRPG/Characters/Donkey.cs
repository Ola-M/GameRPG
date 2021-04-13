using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    class Donkey : Champion
    {
        public Donkey(int Hp, string race, int miss, int strenght)
        {
            Hp = 80;
            race = GetType().Name;
            miss = 10;
            strenght = 40;

        }
        public Donkey(string name) : base(name)
        {
            _name = name;
        }

        public override List<Skill> SpecialAbility()
        {
            List<Skill> specialAbility = new List<Skill>();
            specialAbility.Add(new Skill("Zatrute ugryzienie", 50));
            specialAbility.Add(new Skill("Stanięcie Dęba ", 55));
            return specialAbility;
        }
    }
}
