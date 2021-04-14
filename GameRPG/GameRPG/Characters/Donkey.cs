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
        

        public override List<SpecialAbility> Skill()
        {
            List<SpecialAbility> specialAbiliti = new List<SpecialAbility>();
            specialAbiliti.Add(new SpecialAbility("Zatrute ugryzienie", 50));
            specialAbiliti.Add(new SpecialAbility("Stanięcie Dęba ", 55));
            return specialAbiliti;
        }
    }
}
