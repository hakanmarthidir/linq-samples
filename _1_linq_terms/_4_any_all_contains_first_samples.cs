using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_linq_terms
{
    public class AnyAllContainsFirstSamples
    {

        private IEnumerable<Player> players;
        public AnyAllContainsFirstSamples()
        {
            this.players = PlayerDataManager.GetPlayerList();
        }


        public void AnySample()
        {
            //contains any elements or not -> returns boolean
            //not deferred execution. 
            var isEmpty = this.players.Any();
            Console.WriteLine(isEmpty);
        }

        public void AllSample()
        {
            //every element is suitable to our filter
            //not deferred execution.
            //every player is from Chicago - answer is no
            var isAllFromChicago = this.players.All(x => x.City == "Chicago");
            Console.WriteLine(isAllFromChicago);
        }

        public void ContainsSample()
        {
            var isExist = players.Contains(new Player() { City = "Minnesota", AvgScore = 35, Name = "Garnett" });
            Console.WriteLine(isExist);
        }


        //in First and FirstOrDefault methods, you can have a sequence which has more than one element after your filter was executed.
        //you will get first item of sequence with First methods.
        //however in Single Methods, if you have a sequence which has more than one element you will get an exception. 

        public void FirstSample()
        {
            //returns first element of sequences
            //if there is no element in sequence, you will get a exception
            //InvalidOperation Exception - sequence contains no element

            var filteredPlayer = players.Where(x => x.City == "Chicago").First();
            Console.WriteLine(filteredPlayer);
        }

        public void FirstOrDefaultSample()
        {
            //if there is no element in source, you will get default value of return type
            //var filteredPlayers = players.Where(x => x.City == "Minnesota").FirstOrDefault();

            //or you can apply where filter into First and FirstOrDefault methods
            var filteredPlayer = players.FirstOrDefault(x => x.City == "Minnesota");
            if (filteredPlayer != null)
            {
                Console.WriteLine(filteredPlayer);
            }

        }

        public void SingleSample()
        {
            //returns element of sequence
            //if there is no element in sequence, you will get a exception

            var filteredPlayer = players.Single(x => x.City == "Chicago");
            Console.WriteLine(filteredPlayer);
        }


        public void SingleOrDefaultSample()
        {
            //if there is more than one element in sequence, you will get a exception
            //Otherwise you will get element or default valiue (if sequence is empty)

            var filteredPlayer = players.SingleOrDefault(x => x.City == "Chicago");
            Console.WriteLine(filteredPlayer);
        }
    }
}
