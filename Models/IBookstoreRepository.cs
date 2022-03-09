using System;
using System.Linq;

namespace BookstoreMission.Models
{
    // template for a class
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }

        public void SaveBook(Book b);
        public void CreateBook(Book b);
        public void DeleteBook(Book b);
    }
}
