using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Management management = new Management();
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 101, Rating = 5, Review = "Very Good", IsLike = true },
                new ProductReview() { ProductId = 2, UserId = 102, Rating = 4, Review = " Good", IsLike = true },
                new ProductReview() { ProductId = 3, UserId = 103, Rating = 3, Review = "Average", IsLike = true },
                new ProductReview() { ProductId = 4, UserId = 104, Rating = 2, Review = "Poor", IsLike = true },
                new ProductReview() { ProductId = 5, UserId = 105, Rating = 1, Review = "Bad", IsLike = true },
                new ProductReview() { ProductId = 6, UserId = 106, Rating = 1, Review = "Bad", IsLike = true },
                new ProductReview() { ProductId = 7, UserId = 107, Rating = 2, Review = "Poor", IsLike = true },
                new ProductReview() { ProductId = 8, UserId = 108, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 9, UserId = 109, Rating = 3, Review = "Average", IsLike = true },
                new ProductReview() { ProductId = 10, UserId = 110, Rating = 5, Review = "Very Good", IsLike = true }
            };
            while(true)
            {
                Console.WriteLine("1- Select top 3 records");
                Console.WriteLine("2- Retrive deatails of ProductId =1,4,9 and rating >3");
                Console.WriteLine("3- print only ProductId and Review");
                Console.WriteLine("4- Retrive productId rating userId");
                Console.WriteLine("5-Skip top 5 records");
                Console.WriteLine("6- find total Count");
                Console.WriteLine("Choose above option");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        management.TopThreeRecords(list);
                        break;
                    case 2:
                        management.PruductId_Rating(list);
                        break;
                    case 3:
                        management.Print_ProductId_Review(list);
                        break;
                    case 4:
                        management.RetiveProductId_UserId_Review(list);
                        break;
                    case 5:
                        management.SkipTopFive(list); 
                        break;
                    case 6:
                        management.CoundByRating(list);
                        break;
                }
            }
        }
    }
}
