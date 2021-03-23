using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_linq_terms
{
    public class GroupingSamples
    {
        private IEnumerable<Player> players;
        private IEnumerable<PersonalTrainer> trainers;

        public GroupingSamples()
        {
            this.players = PlayerDataManager.GetPlayerList();
            this.trainers = PersonalTrainerDataManager.GetTrainerList();
        }

        public void GroupingSample()
        {

            var groupingPlayers = from p in players
                                  group p by p.City;

            foreach (var p in groupingPlayers)
            {
                Console.WriteLine(p.Key);
                foreach (var item in p)
                {
                    Console.WriteLine(item);
                }
            }

            //Chicago
            //  Jordan - Chicago - 39.5
            //  Pippen - Chicago - 27.8
            //Los Angeles
            //  Bryant - Los Angeles - 35.2
            //  ONeill - Los Angeles - 30
            //  Davis - Los Angeles - 30
            //Cleveland
            //  James - Cleveland - 31.1
            //  Philadelphia
            //  Iverson - Philadelphia - 34.3

        }

        public void GroupingSample2()
        {
            var groupingPlayers = from p in players
                                  group p by p.City into cityPlayers
                                  where cityPlayers.Count() > 2
                                  orderby cityPlayers.Key
                                  select cityPlayers;

            foreach (var p in groupingPlayers)
            {
                Console.WriteLine(p.Key);
                foreach (var item in p)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void GroupingSample3()
        {
            var groupingPlayers = from p in players
                                  group p by p.City into cityPlayers
                                  orderby cityPlayers.Key
                                  select cityPlayers;

            foreach (var p in groupingPlayers)
            {
                Console.WriteLine($"{p.Key} has {p.Count()} players.");
            }

            //Chicago has 2 players.
            //Cleveland has 1 players.
            //Los Angeles has 3 players.
            //Philadelphia has 1 players.
        }

        public void GroupingSample4()
        {
            var groupingPlayers = players.GroupBy(x => x.City).OrderBy(x => x.Key);

            foreach (var p in groupingPlayers)
            {
                Console.WriteLine(p.Key);
                foreach (var item in p)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void GroupingSample5()
        {

            var groupingPlayers = from p in players
                                  group p by p.City into cityGroup
                                  from player in cityGroup
                                  where player.AvgScore > 35
                                  select new { CityName = cityGroup.Key, Players = cityGroup };

            //MAX, MIN, AVG 
            foreach (var item in groupingPlayers)
            {
                Console.WriteLine($"{item.CityName} - {item.Players.Max(x => x.AvgScore)}");
            }

        }

    }
}
