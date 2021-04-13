using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    class Ogre : Champion
    {
        public Ogre(int Hp,string race, int miss, int strenght)
        {
            Hp = 300;
            race = GetType().Name;
            miss = 2;
            strenght = 20;
        }
        public Ogre(string name) : base(name)
        {
            _name = name;
        }

        public override List<Skill> SpecialAbility()
        {
            List<Skill> specialAbility = new List<Skill>();
            specialAbility.Add(new Skill("Pierd", 25));
            specialAbility.Add(new Skill("Cios maczugą", 30));
            return specialAbility;
        }
    }
}
