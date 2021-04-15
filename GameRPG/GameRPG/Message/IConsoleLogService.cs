namespace GameRPG.Message
{
    interface IConsoleLogService
    {
        void Attack(string attackingHeroRace, string attackingHeroName);
        void FightWinner(string race, string name);
        void Miss(string heroAttackedRace, string heroAttackedName);
        void SpecialAttack(string attackingHeroRace, string attackingHeroName, string specialAttackName);
        void TournamentWinner(string race, string name);
    }
}