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


        public override List<Skill> Skill()
        {
            List<Skill> skill = new List<Skill>();
            skill.Add(new Skill("Cios Mieczem", 50));
            skill.Add(new Skill("Błędny ryczerz", 45));
            return skill;
        }
    }
}
