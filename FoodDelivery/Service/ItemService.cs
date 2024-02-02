using FoodDelivery.Data;
using FoodDelivery.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Service
{
    public class ItemService
    {
        private IDbContextFactory<AppDbContext> _dbContextFactory;
        public ItemService(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddItemInMenu(MenuProduct product)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.products.Add(product);
                context.SaveChanges();
            }
        }
        public void DeleteItem(int eid)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var itemToDelete = context.products.Find(eid);
                if (itemToDelete != null)
                {
                    context.products.Remove(itemToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}
