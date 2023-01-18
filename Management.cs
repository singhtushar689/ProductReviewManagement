using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcutReviewManagement
{
    public class Management
    {
        public static void TopRecords(List<ProductReview> reviews)
        {
            var recordData = (from productReview in reviews
                              orderby productReview.Rating descending
                              select productReview).Take(3);
            foreach (var List in recordData)
            {
                Console.WriteLine("ProductId: " + List.ProductId + "UserId :" + List.UserId + "Rating :" + List.Rating + "Review:" + List.Review + "isLike:" + List.isLike);
            }
        }  
        public void SelectedRecords(List<ProductReview> reviews)
        {
            var recordData = (from product in reviews
                              where (product.ProductId == 1 && product.Rating > 3) ||
                              (product.ProductId == 4 && product.Rating > 3) ||
                              (product.ProductId == 9 && product.Rating > 3)
                              select product);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId: " + list.ProductId + "UserId :" + list.UserId + "Rating :" + list.Rating + "Review:" + list.Review + "isLike:" + list.isLike);
            }
        }
    }
}
