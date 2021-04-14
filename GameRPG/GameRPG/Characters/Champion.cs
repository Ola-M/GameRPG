using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    abstract class Champion
    {
        
        public int Hp { get; set; }
        public int currentHp { get; set; }
        public string _name { get; set; }
        public string race { get; set; }
        public int miss { get; set; }
        public int strength { get; set; }

        public Champion(string name )
        {
            _name = name;
           
        }
       

        public  void MaxHp()
        {
            currentHp = Hp;
        }

        public abstract List<Skill> Skill();
        
    }
}
