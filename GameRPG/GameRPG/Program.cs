using GameRPG.Message;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace GameRPG
{
    class Program
    {
        Tournament _tournament;
        public Program(Tournament tournament)
        {
            _tournament = tournament;
        }
        static void Main(string[] args)
        {
            
            using IHost host = CreateHostBuilder(args).Build(); ;
            host.Services.GetRequiredService<Program>().Run();
           
        }
        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((services) =>
                    services.AddTransient<Program>()
                            .AddTransient<Tournament>()
                            .AddTransient<FightHero>()
                            .AddScoped<ISpecialAbilityHelper, SpecialAbilityHelper>()
                            .AddScoped<IConsoleLogService, ConsoleLogService>());
                            
        public void Run()
        {
            _tournament.TournamentCompetitions();
        }

    }
    
}
