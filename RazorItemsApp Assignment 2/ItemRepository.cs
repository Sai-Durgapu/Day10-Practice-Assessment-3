using RazorItemsApp.Models;

namespace RazorItemsApp
{
    public static class ItemRepository
    {
        public static List<Item> Items = new()
        {
            new Item { Name = "Laptop" },
            new Item { Name = "Mobile" }
        };
    }
}