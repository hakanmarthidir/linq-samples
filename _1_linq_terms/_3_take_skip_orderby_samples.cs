using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_linq_terms
{
    public class TakeOrderBySamples
    {
        private IEnumerable<Player> players;
        public TakeOrderBySamples()
        {
            this.players = PlayerDataManager.GetPlayerList();
        }


        public void TakeSample1()
        {
            Console.WriteLine("---Take Sample");
            var filteredPlayers = players.Where(x => x.City == "Los Angeles").Take(1);

            foreach (var p in filteredPlayers)
            {
                Console.WriteLine(p);
            }
        }

        public void SkipSample1()
        {
            Console.WriteLine("---Skip Sample");
            var filteredPlayers = players.Where(x => x.City == "Los Angeles").Skip(1).Take(1);

            foreach (var p in filteredPlayers)
            {
                Console.WriteLine(p);
            }
        }

        public void OrderBySample1()
        {
            Console.WriteLine("---Orderby Sample");
            var filteredPlayers = players.Where(x => x.City == "Los Angeles").OrderBy(x => x.AvgScore);

            //---Orderby Sample
            //ONeill - Los Angeles - 30
            //Davis - Los Angeles - 30
            //Bryant - Los Angeles - 35.2

            foreach (var p in filteredPlayers)
            {
                Console.WriteLine(p);
            }
        }

        public void OrderBySample2()
        {
            Console.WriteLine("---Orderby Sample2");

            var filteredPlayers = from p in players
                                  where p.City == "Los Angeles"
                                  orderby p.AvgScore //orderby p.AvgScore descending
                                  select p;

            foreach (var p in filteredPlayers)
            {
                Console.WriteLine(p);
            }
        }

        public void MultiOrderBySample1()
        {
            Console.WriteLine("---Multi Orderby Sample");
            var filteredPlayers = players.Where(x => x.City == "Los Angeles")
                .OrderByDescending(x => x.AvgScore)
                .ThenBy(x => x.Name);

            //second orderby executed 

            //Bryant - Los Angeles - 35.2
            //Davis - Los Angeles - 30
            //ONeill - Los Angeles - 30

            foreach (var p in filteredPlayers)
            {
                Console.WriteLine(p);
            }
        }

    }
}
