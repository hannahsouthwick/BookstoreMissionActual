using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreMission.Infrastructure;
using BookstoreMission.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookstoreMission.Pages
{
    public class CheckoutModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }

        public CheckoutModel(IBookstoreRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }

        public Cart cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book p = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            // if cart session already exists, use that cart
            //cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            cart.AddItem(p, 1, p.Price);

            //HttpContext.Session.SetJson("cart", cart);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            cart.RemoveItem(cart.Items.First(x => x.Book.BookId == bookId).Book);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
