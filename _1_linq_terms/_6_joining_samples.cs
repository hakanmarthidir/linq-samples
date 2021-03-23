using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_linq_terms
{
    public class JoiningSamples
    {
        private IEnumerable<Player> players;
        private IEnumerable<PersonalTrainer> trainers;

        public JoiningSamples()
        {
            this.players = PlayerDataManager.GetPlayerList();
            this.trainers = PersonalTrainerDataManager.GetTrainerList();
        }

        //JOIN Types
        //1- JOIN (inner, outer)
        //2- GROUPJOIN

        public void JoiningSample()
        {
            Console.WriteLine("---Joining Sample----");
            var matchTrainerPlayer = from p in players
                                     join t in trainers on p.City equals t.City
                                     orderby p.Name
                                     select new { PlayerName = p.Name, PlayerTrainer = t.Name };

            foreach (var item in matchTrainerPlayer)
            {
                Console.WriteLine($"{item.PlayerName} works with {item.PlayerTrainer}");
            }

            //---Joining Sample----
            //Bryant works with George
            //Davis works with George
            //Iverson works with Fred
            //James works with Michael
            //Jordan works with Kevin
            //ONeill works with George
            //Pippen works with Kevin
        }

        public void JoiningSample2()
        {
            var matchTrainerPlayer = players
                .Join(trainers, t => t.City, p => p.City, (t, p) => new { PlayerName = p.Name, PlayerTrainer = t.Name })
                .OrderBy(x => x.PlayerName);

            foreach (var item in matchTrainerPlayer)
            {
                Console.WriteLine($"{item.PlayerName} - {item.PlayerTrainer}");
            }

        }

        public void GroupJoiningSample()
        {
            Console.WriteLine("----GroupJoiningSample-----");

            var brandList = Brand.Brands();
            var productList = Product.Products();


            var brandProducts = from b in brandList
                                join p in productList on b.Id equals p.BrandId into brandProductGroup
                                select new { Brand = b.Name, Products = brandProductGroup };

            foreach (var brandProduct in brandProducts)
            {
                Console.WriteLine($"{brandProduct.Brand}");
                foreach (var product in brandProduct.Products)
                {
                    Console.WriteLine($"{product.ProductName}");
                }

            }
        }

        public void GroupJoiningSample2()
        {
            Console.WriteLine("----GroupJoiningSample2-----");

            var brandList = Brand.Brands();
            var productList = Product.Products();

            var brandProducts = brandList.GroupJoin(
                productList,
                brand => brand.Id,
                products => products.BrandId,
                (brand, products) => new { Brand = brand.Name, Products = products });

            foreach (var brandProduct in brandProducts)
            {
                Console.WriteLine($"{brandProduct.Brand}");
                foreach (var product in brandProduct.Products)
                {
                    Console.WriteLine($"{product.ProductName}");
                }

            }
        }

        public void LeftJoinSample()
        {
            Console.WriteLine("---Left Joining Sample----");
            var matchTrainerPlayer = from t in trainers
                                     join p in players on t.City equals p.City into pc
                                     from pcInfo in pc.DefaultIfEmpty()
                                     orderby t.Name
                                     select new { PlayerName = pcInfo?.Name ?? "-", PlayerTrainer = t.Name };

            foreach (var item in matchTrainerPlayer)
            {
                Console.WriteLine($"{item.PlayerName} works with {item.PlayerTrainer}");
            }

            //---Left Joining Sample----
            //Iverson works with Fred
            //- works with Fredie
            //Bryant works with George
            //ONeill works with George
            //Davis works with George
            //Jordan works with Kevin
            //Pippen works with Kevin
            //James works with Michael


        }

    }
}
