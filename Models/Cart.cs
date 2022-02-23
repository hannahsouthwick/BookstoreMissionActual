using System;
using System.Collections.Generic;
using System.Linq;

namespace BookstoreMission.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        public void AddItem(Book book, int qty, double price)
        {
            CartLineItem line = Items
                .Where(p => p.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new CartLineItem
                {
                    Book = book,
                    Quantity = qty,
                    Price = price
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }
        public double CalculateTotal()
        {
            // generate sum from quantity and price
            double sum = Items.Sum(x => x.Quantity * x.Price);

            return sum;
        }
    }

    public class CartLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
