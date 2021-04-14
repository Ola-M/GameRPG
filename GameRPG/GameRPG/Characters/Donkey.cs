using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    class Donkey : Champion
    {
        public Donkey( string name) : base(name)
        {
            Hp = 80;
            race = GetType().Name;
            miss = 10;
            strength = 40;
            _name = name;
            currentHp = Hp;

        }
        

        public override List<Skill> Skill()
        {
            List<Skill> skill = new List<Skill>();
            skill.Add(new Skill("Zatrute ugryzienie", 50));
            skill.Add(new Skill("Stanięcie Dęba ", 55));
            return skill;
        }
    }
}
