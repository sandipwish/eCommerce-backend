using System.Collections.Generic;
using eShop.Data.Models;

namespace eShop.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();

        Book GetBook(int bookId);

        void AddBook(Book book);

        void DeleteBook(int bookId);
    }
}