using Microsoft.EntityFrameworkCore;

namespace Murad.WebApi.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnType("decimal(18,2)");

            

            modelBuilder.Entity<Product>().HasData(new Product[]
                {
                new() {Id=1,Name="Lenovo Ideapad",Price=1750,Stock=20,CreatedTime=System.DateTime.Now.AddDays(-3),ImageUrl="https://amazoncomp.az/wp-content/uploads/2020/08/Lenovo-IdeaPad-L3-15IML05.jpg" ,CategoryId=1},

                new() {Id=2,Name="OnePlus",Price=1450,Stock=10,CreatedTime=System.DateTime.Now.AddDays(-33),ImageUrl="https://www.tradeinn.com/f/13796/137965389/oneplus-nord-8gb-128gb-6.44-smartphone.jpg" ,CategoryId=1},
                new() {Id=3,Name="Mibro Watch X1",Price=82,Stock=25,CreatedTime=System.DateTime.Now.AddDays(-55),ImageUrl="https://strgimgr.umico.az/sized/1680/258600-e3d5563b2275dac6f48948047bebb250.jpg",CategoryId=2 },
                });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
