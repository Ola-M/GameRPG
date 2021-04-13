using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    abstract class Champion
    {
        
        public int _Hp { get; set; }
        public string _name { get; set; }
        public string race { get; set; }
        public int _miss { get; set; }
        public int _strength { get; set; }

        public Champion()
        {

        }
        public Champion(string name)
        {
            _name = name;
        }

        public static int CurrentHp(int Hp, int damage)
        {
            Hp = Hp - damage;
            return Hp;
        }

        public abstract List<Skill> SpecialAbility();
        
    }
}
