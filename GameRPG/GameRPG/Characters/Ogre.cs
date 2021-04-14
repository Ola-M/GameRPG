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
            Hp = 300;
            race = GetType().Name;
            miss = 2;
            strength = 20;
            _name = name;
            currentHp = Hp;
        }



        public override List<Skill> Skill()
        {
            List<Skill> skill = new List<Skill>();
            skill.Add(new Skill("Pierd", 25));
            skill.Add(new Skill("Cios maczugą", 30));
            return skill;
        }
    }
}
