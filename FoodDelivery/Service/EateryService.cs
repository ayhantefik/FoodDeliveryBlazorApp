using FoodDelivery.Data;
using FoodDelivery.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Service
{
    public class EateryService
    {
        private IDbContextFactory<AppDbContext> _dbContextFactory;
        public EateryService(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddEatery(Eatery eatery)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.eateries.Add(eatery);
                context.SaveChanges();
            }
        }
        public void DeleteEatery(int eid)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var eateryToDelete = context.eateries.Find(eid);
                if (eateryToDelete != null)
                {
                    context.eateries.Remove(eateryToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}
