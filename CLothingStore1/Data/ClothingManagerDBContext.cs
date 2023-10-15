using CLothingStore1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CLothingStore1.Data
{
    public class ClothingManagerDBContext : DbContext
    {
        public ClothingManagerDBContext(
            DbContextOptions<ClothingManagerDBContext> options) : base(options)
        {   
        }

        public DbSet<Clothing> Clothings => Set<Clothing>();
        public DbSet<Department> Departments => Set<Department>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, name = "Men" },
                new Department { Id = 2, name = "Women" },
                new Department { Id = 3, name = "Boys" },
                new Department { Id = 4, name = "Girls" },
                new Department { Id = 5, name = "Babies" });

            modelBuilder.Entity<Clothing>().HasData(
                new Clothing { ID = 1, type = "shirt", size = "large", isTrending = true, DepartmentId = 1 },
                new Clothing { ID = 2, type = "Pants", size = "Medium", isTrending = false, DepartmentId = 4 },
                new Clothing { ID = 3, type = "Shoes", size = "10", isTrending = false, DepartmentId = 3 },
                new Clothing { ID = 4, type = "Shorts", size = "large", isTrending = true, DepartmentId = 5 },
                new Clothing { ID = 5, type = "skirt", size = "small", isTrending = true, DepartmentId = 4 },
                new Clothing { ID = 6, type = "shirt", size = "xLarge", isTrending = false, DepartmentId = 2 },
                new Clothing { ID = 7, type = "shirt", size = "large", isTrending = false, DepartmentId = 1 },
                new Clothing { ID = 8, type = "pants", size = "small", isTrending = true, DepartmentId = 5 }
                );
        }
    }
}
