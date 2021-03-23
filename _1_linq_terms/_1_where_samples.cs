using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_linq_terms
{
    public class WhereSamples
    {

        //There are 3 parts in LINQ
        //1- datasource
        //2- creating query
        //3- Execution

        private IEnumerable<Player> players;

        public WhereSamples()
        {
            this.players = PlayerDataManager.GetPlayerList();
        }

        //Add Namespace : to activating Linq extension methods, System.Linq namespace is necessary. 

        //1- Lambda Expression
        public void WhereSample(double score)
        {
            Console.WriteLine("---Where With Lambda Sample");
            //filter will not execute - it means it has deferred execution feature.
            var filteredPlayers = players.Where(x => x.AvgScore > score);

            //when you iterate the source, execution will be performed.
            foreach (var p in filteredPlayers)
            {
                Console.WriteLine(p);
            }

        }

        //2- Named Method
        public void WhereSampleWithNamedMethod()
        {
            Console.WriteLine("---Where With Named Method Sample");
            var filteredPlayers = players.Where(GreaterThanThirtyFiveScore);

            var playerEnumerator = filteredPlayers.GetEnumerator();
            while (playerEnumerator.MoveNext())
            {
                Console.WriteLine(playerEnumerator.Current);
            }
        }

        private bool GreaterThanThirtyFiveScore(Player player)
        {
            return player.AvgScore > 35;
        }

        //3- Anonymous Method
        public void WhereSampleWithDelegatedMethod()
        {
            Console.WriteLine("---Where With Anonymous Method Sample");
            var filteredPlayers = players.Where(delegate (Player player) { return player.AvgScore > 35; });

            var playerEnumerator = filteredPlayers.GetEnumerator();
            while (playerEnumerator.MoveNext())
            {
                Console.WriteLine(playerEnumerator.Current);
            }
        }

        //4- Query Method
        public void WhereQuerySample()
        {
            Console.WriteLine("---Where Query Sample");
            // filter will not execute - it means it has deferred execution feature.
            // query always start with from...in and ends select keyword...
            // you might add where, orderby or other extension methods between them. 
            var filteredPlayers = from p in players
                                  where p.AvgScore > 35
                                  select p;

            //when you iterate the source, execution will be performed.
            var playerEnumerator = filteredPlayers.GetEnumerator();
            while (playerEnumerator.MoveNext())
            {
                Console.WriteLine(playerEnumerator.Current);
            }

        }

    }
}
