using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Message
{
    class ConsoleLogService : IConsoleLogService
    {
        public void TournamentWinner(string race, string name)
        {
            Console.WriteLine("\nZwycięzcą turnieju jest " + race + " " + name);
        }
        public void FightWinner(string race, string name)
        {
            Console.WriteLine(race + " " + name + " Wygrał Pojedynek \n");
        }
        public void Miss(string heroAttackedRace, string heroAttackedName)
        {
            Console.WriteLine(heroAttackedRace + " " + heroAttackedName + " wykonał unik");
        }
        public void Attack(string attackingHeroRace, string attackingHeroName)
        {
            Console.WriteLine(attackingHeroRace + " " + attackingHeroName + " zadał cios");
        }
        public void SpecialAttack(string attackingHeroRace, string attackingHeroName, string specialAttackName)
        {
            Console.WriteLine(attackingHeroRace + " " + attackingHeroName + " zadał cios " + specialAttackName);
        }
    }
}
