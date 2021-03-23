using System;
using System.Collections.Generic;

namespace _1_linq_terms
{
    public class Player
    {
        public string Name { get; set; }
        //private double _avgScore;
        //public double AvgScore { get { Console.WriteLine("avgscore get executed"); return this._avgScore; } set { this._avgScore = value; } }
        public double AvgScore { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{Name} - {City} - {AvgScore}";
        }
    }

    public static class PlayerDataManager
    {
        public static IEnumerable<Player> GetPlayerList()
        {
            return new List<Player>() {

                new Player(){ Name="Jordan", City="Chicago", AvgScore=39.5 },
                new Player(){ Name="Pippen", City="Chicago", AvgScore=27.8 },
                new Player(){ Name="Bryant", City="Los Angeles", AvgScore=35.2 },
                new Player(){ Name="ONeill", City="Los Angeles", AvgScore=30.0 },
                new Player(){ Name="Davis", City="Los Angeles", AvgScore=30.0 },
                new Player(){ Name="James", City="Cleveland", AvgScore=31.1 },
                new Player(){ Name="Iverson", City="Philadelphia", AvgScore=34.3 }

            };
        }
    }
}
