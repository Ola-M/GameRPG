using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    class Princess : Champion
    {
        
        public Princess(int Hp, string race, int miss, int strenght)
        {
            Hp = 150;
            race = GetType().Name;
            miss = 20;
            strenght = 30; 
        }
        public Princess(string name) : base(name)
        {
            _name = name;
        }

        public override List<Skill> SpecialAbility()
        {
            List<Skill> specialAbility = new List<Skill>();
            specialAbility.Add(new Skill("Kopnięcie z półobrotu", 40));
            specialAbility.Add(new Skill("Przerźliwy krzyk", 35));
            return specialAbility;
        }
    }
}
