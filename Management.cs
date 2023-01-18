using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcutReviewManagement
{
    public class Management
    {
        public void TopRecords(List<ProductReview> reviews)
        {
            var recordData = (from productReview in reviews
                              orderby productReview.Rating descending
                              select productReview).Take(3);
            foreach (var List in recordData)
            {
                Console.WriteLine("ProductId: " + List.ProductId + "UserId :" + List.UserId + "Rating :" + List.Rating + "Review:" + List.Review + "isLike:" + List.isLike);
            }
        }   
    }
}
