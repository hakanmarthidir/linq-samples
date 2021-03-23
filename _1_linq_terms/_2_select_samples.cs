using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_linq_terms
{
    public class SelectSamples
    {
        private IEnumerable<Player> players;

        public SelectSamples()
        {
            this.players = PlayerDataManager.GetPlayerList();
        }


        public void Select1()
        {
            //still deferred execution is valid
            IEnumerable<Player> filteredPlayers = players.Select(x => x);
        }

        public void Select2()
        {
            //still deferred execution is valid
            IEnumerable<string> filteredPlayers = players.Where(x => x.City.StartsWith("C")).Select(x => x.Name);
        }

        public void Select3()
        {
            //will execute immediately with ToList, ToArray, ToDictionary etc.
            var filteredPlayers = (players.Where(x => x.City.StartsWith("C") || x.City.StartsWith("P")).Select(x => x)).ToList();
        }

        public void Select4()
        {
            var filteredPlayers = players
                .Where(x => x.City.StartsWith("C") && x.City.StartsWith("P"))
                .Select(x => new { PlayerName = x.Name, PlayerScore = x.AvgScore });

            foreach (var p in filteredPlayers)
            {
                Console.WriteLine($"{p.PlayerName} - {p.PlayerScore}");
            }
        }

        public void Select5()
        {
            var filteredPlayers = from p in players
                                  where p.City.StartsWith("L")
                                  select p;

            foreach (var p in filteredPlayers)
            {
                Console.WriteLine(p);
            }
        }

        public void Select6()
        {
            var filteredPlayers = from p in players
                                  where p.City.StartsWith("L")
                                  select new { PlayerName = p.Name, PlayerScore = p.AvgScore };

            foreach (var p in filteredPlayers)
            {
                Console.WriteLine($"{p.PlayerName} - {p.PlayerScore}");
            }
        }
    }
}
