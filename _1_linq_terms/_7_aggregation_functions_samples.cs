using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_linq_terms
{
    public class AggregationFunctionsSamples
    {
        private IEnumerable<Player> players;
        private IEnumerable<PersonalTrainer> trainers;

        public AggregationFunctionsSamples()
        {
            this.players = PlayerDataManager.GetPlayerList();
            this.trainers = PersonalTrainerDataManager.GetTrainerList();
        }

        public void AggregationSample()
        {
            var groupingPlayers = from p in players
                                  group p by p.City;

            foreach (var p in groupingPlayers)
            {
                Console.WriteLine($"City {p.Key} - player count is : {p.Count()}");
                Console.WriteLine($"City {p.Key} - max average score : {p.Max(x => x.AvgScore)}");
                Console.WriteLine($"City {p.Key} - min average score : {p.Min(x => x.AvgScore)}");
                Console.WriteLine($"City {p.Key} - average score : {p.Average(x => x.AvgScore)}");
                Console.WriteLine($"City {p.Key} - sum of average scores : {p.Sum(x => x.AvgScore)}");
            }

        }

    }
}
