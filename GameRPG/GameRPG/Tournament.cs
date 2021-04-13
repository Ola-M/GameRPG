using GameRPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class Tournament
    {       
        private int[] RandHero(List<Champion>hero)
        {
            Random rand = new Random();
            int[] fighter = new int[2];
            fighter[0] = rand.Next(hero.Count);
            fighter[1] = rand.Next(hero.Count);
            return fighter;
        }
        public void Fight()
        {
            List<Champion> hero = new List<Champion>();
            hero.Add(new Ogre("Shreck"));
            hero.Add(new Princess("Fiona"));
            hero.Add(new Knight("Książe z bajki"));
            hero.Add(new Donkey("Osioł"));
            hero.Add(new Knight("Lord Farqaad"));
            hero.Add(new Princess("Kopciuszek"));


            while (hero.Count > 1)
            {              
               var fighters = RandHero(hero);
               var fighter1 = hero[fighters[0]];
               var fighter2 = hero[fighters[2]];

                while ((fighter1._Hp > 0) && (fighter2._Hp > 0))
                {

                }
               


            }
            
                
            




        }

        


    }
}
