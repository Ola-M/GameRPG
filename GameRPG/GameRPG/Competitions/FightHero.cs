using GameRPG.Characters;
using GameRPG.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    class FightHero
    {
        ISpecialAbilityHelper _specialAbility;
        IConsoleLogService _consoleLogService;

        public FightHero(ISpecialAbilityHelper specialAbility, IConsoleLogService consoleLogService)
        {
            _specialAbility = specialAbility;
            _consoleLogService = consoleLogService;

        }

        
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

        public void Attack(Champion heroAttacked, Champion attackingHero)
        {
            if(_specialAbility.ChanceOfSpecialAttac()== true)
            {
                _specialAbility.SpecialAttack(heroAttacked, attackingHero);
            }
            else
            {
                heroAttacked.CurrentHp -= attackingHero.AttackStrength;
                _consoleLogService.Attack(attackingHero.Race, attackingHero.Name);
            }
        }

        public void Fight(List<Champion> hero)
        {
            while (hero.Count > 1)
            {
                var fighters = RandHero(hero);
                var fighter1 = hero[fighters[0]];
                var fighter2 = hero[fighters[1]];

                while ((fighter1.CurrentHp > 0) && (fighter2.CurrentHp > 0))
                {
                    if (_specialAbility.Miss(fighter1.ChanceToMiss) == false) 
                    {
                        Attack(fighter1, fighter2);                        
                    }
                    else { _consoleLogService.Miss(fighter1.Race, fighter1.Name); }

                    if (fighter1.CurrentHp <= 0)
                    {
                        _consoleLogService.FightWinner(fighter2.Race, fighter2.Name);
                        fighter2.MaxHp();
                        hero.RemoveAt(fighters[0]);
                        break;
                    }

                    if (_specialAbility.Miss(fighter2.ChanceToMiss) == false)
                    {
                        Attack(fighter2, fighter1);                        
                    }
                    else { _consoleLogService.Miss(fighter2.Race, fighter2.Name); }

                    if (fighter2.CurrentHp <= 0)
                    {
                        _consoleLogService.FightWinner(fighter1.Race, fighter1.Name);
                        fighter1.MaxHp();
                        hero.RemoveAt(fighters[1]);
                        break;
                    }
                }                       
            }
        }
    }
}
