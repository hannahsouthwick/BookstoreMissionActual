using System;
using System.Linq;

namespace BookstoreMission.Models
{
    //implements and instance of IBookstoreRepository

    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository(BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Projects => context.Books;
    }
}
