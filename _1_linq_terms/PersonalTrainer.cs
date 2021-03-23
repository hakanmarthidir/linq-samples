using System.Collections.Generic;

namespace _1_linq_terms
{
    public class PersonalTrainer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} - {City}";
        }
    }

    public static class PersonalTrainerDataManager
    {
        public static IEnumerable<PersonalTrainer> GetTrainerList()
        {
            return new List<PersonalTrainer>() {

                new PersonalTrainer(){ Name="Kevin", City="Chicago", Age=35},
                new PersonalTrainer(){ Name="George", City="Los Angeles", Age=23 },
                new PersonalTrainer(){ Name="Michael", City="Cleveland", Age=21},
                new PersonalTrainer(){ Name="Fred", City="Philadelphia", Age=44 },
                new PersonalTrainer(){ Name="Fredie", City="Texas", Age=41 }
            };
        }
    }
}
