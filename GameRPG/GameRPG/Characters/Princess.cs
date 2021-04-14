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
            Hp = 150;
            race = GetType().Name;
            miss = 20;
            strength = 30;
            _name = name;
            currentHp = Hp;
        }


        public override List<Skill> Skill()
        {
            List<Skill> skill = new List<Skill>();
            skill.Add(new Skill("Kopnięcie z półobrotu", 40));
            skill.Add(new Skill("Przerźliwy krzyk", 35));
            return skill;
        }
    }
}
