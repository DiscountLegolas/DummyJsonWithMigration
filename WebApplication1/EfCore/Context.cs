using WebApplication1.EfCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.EfCore
{
    public class DummyDbcontext: DbContext
    {
        public DummyDbcontext(DbContextOptions<DummyDbcontext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Category>().ToTable("Categories");
            modelBuilder.Entity<Models.Image>().ToTable("Images");
            modelBuilder.Entity<Models.Product>().ToTable("Products");
            List<string> Categories = JsonConvert.DeserializeObject<List<string>>(new RestClient("https://dummyjson.com/products/categories").GetAsync(new RestRequest()).GetAwaiter().GetResult().Content);
            foreach (var item in Categories)
            {
                modelBuilder.Entity<Category>().HasData(new Category() { CategoryName = item.ToString() });
                RestClient client = new RestClient(("https://dummyjson.com/products/category/" + item));
                RestRequest request = new RestRequest();
                Root root = JsonConvert.DeserializeObject<Root>(client.GetAsync(request).GetAwaiter().GetResult().Content);
                foreach (var product in root.products)
                {
                    foreach (var url in product.images)
                    {
                        modelBuilder.Entity<Image>().HasData(new Image() { Url = url, ProductId = product.id });
                    }
                    modelBuilder.Entity<Models.Product>().HasData(new Models.Product() { id = product.id, title = product.title, description = product.description, price = product.price, discountPercentage = product.discountPercentage, rating = product.rating, stock = product.stock, brand = product.brand, thumbnail = product.thumbnail, category = item });
                }
            }
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Category> Categories {get;set;}
        public DbSet<Models.Product> Products {get;set;}
        public DbSet<Image> Images {get;set;}

    }
}