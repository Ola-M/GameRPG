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
        SpecialAbilityHelper specialAbility = new SpecialAbilityHelper();
        
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

        public void Attac(Champion heroAttacked, Champion attackingHero)
        {
            if(specialAbility.ChanceOfSpecialAttac()== true)
            {
                specialAbility.SpecialAttac(heroAttacked, attackingHero);
            }
            else
            {
                heroAttacked.currentHp -= attackingHero.strength;
                Log.Info(attackingHero.race + " " + attackingHero._name + " zadał cios");
            }
            
            
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
                        Attac(fighter1, fighter2);                        
                    }
                    else { Log.Info(fighter1.race + " " + fighter1._name + "wykonał unik"); }

                    if (fighter1.currentHp <= 0)
                    {
                        Log.Info(fighter2.race + " " + fighter2._name + " Wygrał Pojedynek \n");
                        fighter2.MaxHp();
                        hero.RemoveAt(fighters[0]);

                    }

                    if (specialAbility.Miss(fighter2.miss) == false)
                    {
                        Attac(fighter2, fighter1);                        
                    }
                    else { Log.Info(fighter2.race + " " + fighter2._name + " wykonał unik"); }

                    if (fighter2.currentHp <= 0)
                    {
                        Log.Info(fighter1.race + " " + fighter1._name + " Wygrał Pojedynek \n");
                        fighter1.MaxHp();
                        hero.RemoveAt(fighters[1]);
                    }

                }
                
                
            }
        }


    }
}
