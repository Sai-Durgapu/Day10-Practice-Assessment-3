using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorItemsApp.Models;

namespace RazorItemsApp.Pages
{
    public class ItemsModel : PageModel
    {
        public List<Item> Items { get; set; } = new();

        public void OnGet()
        {
            Items = ItemRepository.Items;
        }
    }
}