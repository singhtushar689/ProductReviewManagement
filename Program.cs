namespace ProcutReviewManagement
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Product Review Management");
            List<ProductReview> productReview = new List<ProductReview>();

            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", isLike = true };
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 5, Review = "Good", isLike = true };
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 5, Review = "Good", isLike = true };
                new ProductReview() { ProductId = 4, UserId = 4, Rating = 5, Review = "Good", isLike = true };
                new ProductReview() { ProductId = 5, UserId = 1, Rating = 2, Review = "Bad", isLike = false };
                new ProductReview() { ProductId = 6, UserId = 3, Rating = 5, Review = "Good", isLike = true };
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", isLike = true };
                new ProductReview() { ProductId = 9, UserId = 5, Rating = 5, Review = "Good", isLike = true };
                new ProductReview() { ProductId = 11, UserId = 1, Rating = 3, Review = "Fair", isLike = true };
                new ProductReview() { ProductId = 14, UserId = 6, Rating = 1, Review = "Very Bad", isLike = false };
                new ProductReview() { ProductId = 13, UserId = 4, Rating = 5, Review = "Good", isLike = true };
                new ProductReview() { ProductId = 11, UserId = 1, Rating = 4, Review = "Nice", isLike = true };
                new ProductReview() { ProductId = 10, UserId = 3, Rating = 1, Review = "Very Bad", isLike = false };
                new ProductReview() { ProductId = 15, UserId = 1, Rating = 5, Review = "Good", isLike = true };
            }
              // foreach(var List in productReview)
            //{
            //    Console.WriteLine("ProductId: " + List.ProductId + "UserId :" + List.UserId + "Rating :" + List.Rating + "Review:" + List.Review + "isLike:" + List.isLike);
            //}

           // Management management = new Management();
            Management.TopRecords(productReview);    //UC1
            //management.SelectedRecords(productReview); //UC2
        }
    }
}