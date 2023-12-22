using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Commerce_MVC_Web_UI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var categories = new List<Category>()
            {
                new Category() {Name ="Kategori 1" , Description = "Ctg1 Description" },
                new Category() {Name ="Kategori 2" , Description = "Ctg2 Description" },
                new Category() {Name ="Kategori 3" , Description = "Ctg3 Description" },
                new Category() {Name ="Kategori 4" , Description = "Ctg4 Description" },
            };

            foreach (Category category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();

            var products = new List<Product>()
            {
                new Product() {Name ="Product1 Product1 Product1 Product1 Product1 Product1Product1 Product1 Product1 Product1 Product1" , Description = "Product1 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 119.90, Stock= 34 , IsApproved=true, CategoryId=2 , IsHome=true, Image= "Pro1.jpg"},
                new Product() {Name ="Product2" , Description = "Product2 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 59.90, Stock= 75 , IsApproved=true, CategoryId=1, IsHome=true, Image= "Pro2.jpg" },
                new Product() {Name ="Product3" , Description = "Product3 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 67.70, Stock= 17 , IsApproved=true, CategoryId=4, Image= "Pro3.jpg" },
                new Product() {Name ="Product4" , Description = "Product4 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 79.90, Stock= 39 , CategoryId=3 , Image= "Pro4.jpg"},
                new Product() {Name ="Product5" , Description = "Product5 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 129.90, Stock= 117 , IsApproved=true, CategoryId=2, Image= "Pro5.jpg" },
                new Product() {Name ="Product6" , Description = "Product6 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 74.90, Stock= 22 , IsApproved=true, CategoryId=1 , IsHome=true, Image= "Pro6.jpg"},
                new Product() {Name ="Product7" , Description = "Product1 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 188.90, Stock= 2 , IsApproved=true, CategoryId=3, IsHome=true , Image= "Pro7.jpg"},
                new Product() {Name ="Product8" , Description = "Product2 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 214.90, Stock= 18 , IsApproved=true, CategoryId=2, Image= "Pro8.jpg"},
                new Product() {Name ="Product9" , Description = "Product3 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 38.90, Stock= 18 , IsApproved=true, CategoryId=4, Image= "Pro9.jpg" },
                new Product() {Name ="Product10" , Description = "Product4 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 11.90, Stock= 41 , IsApproved=true, CategoryId=3, IsHome=true, Image= "Pro2.jpg"},
                new Product() {Name ="Product11" , Description = "Product5 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 23.90, Stock= 102 , IsApproved=true, CategoryId=1},
                new Product() {Name ="Product12" , Description = "Product6 Lorem, ipsum dolor sit amet consectetur adipisicing elit. Tempora dignissimos sintperspiciatis maxime consectetur itaque tenetur nihil enim impedit minima rem debitis facere,aut aliquid!" , Price= 64.90, Stock= 78 , IsApproved=true, CategoryId=2, IsHome=true, Image= "Pro4.jpg"},
            };

            foreach (Product product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();

            base.Seed(context);

        }
    }
}