using GameRPG.Characters;
using GameRPG.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class Tournament
    {
        IConsoleLogService _consoleLogService;
        private FightHero _fightHero ;
        public Tournament(FightHero fightHero, IConsoleLogService consoleLogService)
        {
            _fightHero = fightHero;
            _consoleLogService = consoleLogService;
        }
       
        public void TournamentCompetitions()
        {
            List<Champion> hero = new List<Champion>();
            hero.Add(new Ogre("Shrek"));
            hero.Add(new Princess("Fiona"));
            hero.Add(new Knight("Książe z bajki"));
            hero.Add(new Donkey("Osioł"));
            hero.Add(new Knight("Lord Farqaad"));
            hero.Add(new Princess("Kopciuszek"));

            _fightHero.Fight(hero);
            _consoleLogService.TournamentWinner(hero[0].Race, hero[0].Name);
            
        }
        

     }
}
