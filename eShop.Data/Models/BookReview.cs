using System;

namespace eShop.Data.Models
{
    public class BookReview
    {
        public int Id { get; set; }
        public DateTime CreatedOn{get;set;}
        public DateTime UpdatedOn{get;set;}
        public string Title { get; set; }
        public string Author { get; set; }
        public Book Book{get;}
    }

}