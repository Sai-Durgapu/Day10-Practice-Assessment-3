using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorItemsApp;
using RazorItemsApp.Models;

namespace RazorItemsApp.Pages
{
    public class AddItemModel : PageModel
    {
        [BindProperty]
        public string? ItemName { get; set; }

        public IActionResult OnPost()
        {
            ItemRepository.Items.Add(
                new Item
                {
                    Name = ItemName ?? ""
                });

            return RedirectToPage("Items");
        }
    }
}