using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    abstract class Champion
    {

        public int StartingHp { get; set; }
        public int CurrentHp { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public int ChanceToMiss { get; set; }
        public int AttackStrength { get; set; }
        public List<SpecialAbility> SpecialAbilitiesList;


        public Champion(string name )
        {
            Name = name;
        }

        public  void MaxHp()
        {
            CurrentHp = StartingHp;
        }

        public abstract List<SpecialAbility> Skill();        
    }
}
