using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            BlogContext context = app.ApplicationServices.GetRequiredService<BlogContext>();

            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category() {Name="Category 1"},
                    new Category() {Name="Category 2"},
                    new Category() {Name="Category 3"}
                );

                context.SaveChanges();
            }

            if(!context.Blogs.Any())
            {
                context.Blogs.AddRange(
                    new Blog() {Title="Blog Title 1", Description="Blog Description", Image="1.jpg", Date=DateTime.Now.AddDays(-5), IsApproved=true, CategoryId=1}, 
                    new Blog() {Title="Blog Title 2", Description="Blog Description", Image="2.jpg", Date=DateTime.Now.AddDays(-7), IsApproved=true, CategoryId=1}, 
                    new Blog() {Title="Blog Title 3", Description="Blog Description", Image="3.jpg", Date=DateTime.Now.AddDays(-8), IsApproved=false, CategoryId=2}, 
                    new Blog() {Title="Blog Title 4", Description="Blog Description", Image="4.jpg", Date=DateTime.Now.AddDays(-9), IsApproved=true, CategoryId=3} 
                );

                context.SaveChanges();
            }
        }
    }
}