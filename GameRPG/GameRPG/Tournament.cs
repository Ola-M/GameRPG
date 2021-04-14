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
        private FightHero fightHero = new FightHero();
        
        public void TournamentCompetitions()
        {
            List<Champion> hero = new List<Champion>();
            hero.Add(new Ogre("Shreck"));
            hero.Add(new Princess("Fiona"));
            hero.Add(new Knight("Książe z bajki"));
            hero.Add(new Donkey("Osioł"));
            hero.Add(new Knight("Lord Farqaad"));
            hero.Add(new Princess("Kopciuszek"));

            fightHero.Fight(hero);
            Log.Info("\nZwycięzcą turnieju jest " + hero[0]._name);
        }

     }
}
