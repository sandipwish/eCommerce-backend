using System;
using System.Collections.Generic;
using System.Linq;
using eShop.Data;
using eShop.Data.Models;

namespace eShop.Services
{
    public class BookService : IBookService
    {
        private readonly GoodBooksDbContext _db;

        public BookService(GoodBooksDbContext db)
        {
            this._db = db;
        }
        public void AddBook(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            var bookToDelete = _db.Books.Find(bookId);
            if (bookToDelete != null)
            {
                _db.Remove(bookToDelete);
                _db.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Can't Delete book that doesn'texist");
            }
        }

        public List<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }

        public Book GetBook(int bookId)
        {
            return _db.Books.Find(bookId);
        }
    }
}
