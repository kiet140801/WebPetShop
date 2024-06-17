using Microsoft.EntityFrameworkCore;

namespace WebPetShop.Models.Entities
{
    public class PetShopDbContext : DbContext
    {
        public PetShopDbContext() { }
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options) : base(options) { }

    }
}
