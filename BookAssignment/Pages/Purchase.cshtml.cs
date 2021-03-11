using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAssignment.Infrastructure;
using BookAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookAssignment.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookListRepository repository;
        public PurchaseModel (IBookListRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Project project = repository.Projects.FirstOrDefault(p => p.BookID == bookId);

            Cart.AddItem(project, 1);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove (long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Project.BookID == bookId).Project);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
