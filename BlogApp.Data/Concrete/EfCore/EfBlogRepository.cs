using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;

namespace BlogApp.Data.Concrete.EfCore
{
    public class EfBlogRepository : IBlogRepository
    {
        private BlogContext _context;
        public EfBlogRepository(BlogContext context)
        {
            _context = context;
        }
        public void AddBlog(Blog entity)
        {
            _context.Blogs.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteBlog(int blogId)
        {
            var blog = _context.Blogs.FirstOrDefault(p=>p.BlogId==blogId);
            if (blog != null)
            {
                //_context.Blogs.Remove(blog);
                _context.Entry(blog).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public IQueryable<Blog> GetAll()
        {
            return _context.Blogs;
        }

        public Blog GetById(int blogId)
        {
            return _context.Blogs.FirstOrDefault(p=>p.BlogId==blogId);
        }

        public void SaveBlog(Blog entity)
        {
            if (entity.BlogId == 0)
            {
                entity.Date = DateTime.Now;
                _context.Blogs.Add(entity);
            }
            else
            {
                var blog = GetById(entity.BlogId);
                if (blog != null)
                {
                    blog.Title = entity.Title;
                    blog.Description = entity.Description;
                    blog.Body = entity.Body;
                    blog.CategoryId = entity.CategoryId;
                    blog.Image = entity.Image;
                    blog.IsApproved = entity.IsApproved;
                    blog.IsHome = entity.IsHome;
                    blog.IsSlider= entity.IsSlider;
                }
            }

            _context.SaveChanges();
        }

        public void UpdateBlog(Blog entity)
        {
            var blog = GetById(entity.BlogId);
            if (blog != null)
            {
                blog.Title = entity.Title;
                blog.Description = entity.Description;
                blog.Body = entity.Body;
                blog.CategoryId = entity.CategoryId;
                blog.Image = entity.Image;
                blog.IsApproved = entity.IsApproved;
                blog.IsHome = entity.IsHome;
                blog.IsSlider= entity.IsSlider;

                _context.SaveChanges();
            }
        }
    }
}