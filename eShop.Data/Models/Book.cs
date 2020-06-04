using System;


namespace eShop.Data.Models
{
    public class Book
    {
        public int Id { get; set; }

        public DateTime CreatedOn{get;set;}
        public DateTime UpdatedOn{get;set;}
        public string Title { get; set; }
        public string Author { get; set; }
    }
}