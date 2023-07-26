using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    public class Management
    {
        public void TopThreeRecords(List<ProductReview> products)
        {
            var record = (from product in products orderby product.Rating descending select product).Take(3);
            foreach (var item in record)
            {
                Console.WriteLine(item.ProductId + " " + item.UserId + " " + item.Rating + " " + item.Review + " " + item.IsLike);
            }
        }
        public void PruductId_Rating(List<ProductReview> products)
        {
            var record = from product in products where (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9) && product.Rating > 3 select product;
            foreach (var item in record)
            {
                Console.WriteLine(item.ProductId + " " + item.UserId + " " + item.Rating + " " + item.Review + " " + item.IsLike);
            }
        }
        public void Print_ProductId_Review(List<ProductReview> products)
        {
            var record = from product in products select new { product.ProductId, product.Review };
            foreach (var item in record)
            {
                Console.WriteLine(item.ProductId + " " + item.Review);
            }
        }
        public void RetiveProductId_UserId_Review(List<ProductReview> products)
        {
            var record = from product in products select new { product.ProductId, product.UserId, product.Review };
            foreach (var item in record)
            {
                Console.WriteLine(item.ProductId + " " + item.UserId + " " + item.Review);
            }
        }
        public void SkipTopFive(List<ProductReview> products)
        {
            var record = (from product in products select product).Skip(5);
            foreach (var item in record)
            {
                Console.WriteLine(item.ProductId + " " + item.UserId + " " + item.Rating + " " + item.Review + " " + item.IsLike);
            }
        }
        public void CoundByRating(List<ProductReview> products)
        {
            var record = products.GroupBy(x => x.Rating).Select(x => new { Rating = x.Key, Count = x.Count() });
            foreach (var item in record)
            {
                Console.WriteLine(item.Rating + " " + item.Count);
            }
        }
    }
}
