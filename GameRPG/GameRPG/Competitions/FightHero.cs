using GameRPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class FightHero
    {
        SpecialAbility specialAbility = new SpecialAbility();
        
        private int[] RandHero(List<Champion> hero)
        {
            Random rand = new Random();
            int[] fighter = new int[2];  
            while(fighter[0] == fighter[1])
            {
                fighter[0] = rand.Next(hero.Count);
                fighter[1] = rand.Next(hero.Count);
            }            
            return fighter;
        }

        public int Attac(int Hp, int damage)
        {
            Hp = Hp - damage;
            return Hp;
        }

        public void Fight(List<Champion> hero)
        {
            while (hero.Count > 1)
            {
                var fighters = RandHero(hero);
                var fighter1 = hero[fighters[0]];
                var fighter2 = hero[fighters[1]];

                while ((fighter1.currentHp > 0) && (fighter2.currentHp > 0))
                {
                    if (specialAbility.Miss(fighter1.miss) == false) 
                    {
                        fighter1.currentHp = Attac(fighter1.currentHp, fighter2.strength);
                        Log.Info(fighter2.race + " " + fighter2._name + " zadał cios");
                    }
                    else { Log.Info(fighter1.race + " " + fighter1._name + "wykonał unik"); }

                    if (specialAbility.Miss(fighter2.miss) == false)
                    {
                        fighter2.currentHp = Attac(fighter2.currentHp, fighter1.strength);
                        Log.Info(fighter1.race + " " + fighter1._name + " zadał cios");
                    }
                    else { Log.Info(fighter2.race + " " + fighter2._name + " wykonał unik"); }
                       
                }
                if (fighter1.Hp > 0)
                {
                    Log.Info(fighter1.race +" "+ fighter1._name + " Wygrał Pojedynek \n");
                    fighter1.MaxHp();
                    hero.RemoveAt(fighters[1]);
                }
                else
                {
                    Log.Info(fighter2.race + " " + fighter2._name + " Wygrał Pojedynek \n");
                    fighter2.MaxHp();
                    hero.RemoveAt(fighters[0]);

                }
            }
        }


    }
}
