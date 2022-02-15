using System;
using System.Linq;

namespace BookstoreMission.Models
{
    // template for a class
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
