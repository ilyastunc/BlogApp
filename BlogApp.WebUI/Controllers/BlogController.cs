using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository blogRepository;
        private ICategoryRepository categoryRepository;
        public BlogController(IBlogRepository _blogRepo, ICategoryRepository _categoryRepo)
        {
            blogRepository = _blogRepo;
            categoryRepository = _categoryRepo;
        }
        public IActionResult Index(int? id, string q)
        {
            var query = blogRepository.GetAll().Where(i=>i.IsApproved);
            if (id != null)
                query = query.Where(i=>i.CategoryId==id);

            if (!string.IsNullOrEmpty(q))
            {
                //query = query.Where(i=>i.Title.Contains(q) || i.Description.Contains(q) || i.Body.Contains(q));
                //EF.Functions.Like methodu Core sürümü ile gelen bir özellik. ab% şeklinde çağırarak ab ile başlayanlar falan diyebiliriz.
                query = query.Where(i=>EF.Functions.Like(i.Title, "%"+q+"%") || EF.Functions.Like(i.Description, "%"+q+"%") || EF.Functions.Like(i.Body, "%"+q+"%"));
            }
                
            
            query = query.OrderByDescending(i=>i.Date);
            return View(query);
        }

        public IActionResult Details(int id)
        {
            return View(blogRepository.GetById(id));
        }

        public IActionResult List()
        {
            return View(blogRepository.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog entity)
        {
            if(ModelState.IsValid)
            {
                entity.Date = DateTime.Now;
                blogRepository.AddBlog(entity);
                return RedirectToAction("List");
            }
            else
            {
                return View(entity);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "CategoryId", "Name");
            return View(blogRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Blog entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null) 
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot//img",file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    entity.Image = file.FileName;
                }
                
                blogRepository.UpdateBlog(entity);
                TempData["message"]=$"{entity.Title} güncellendi.";
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "CategoryId", "Name");
                return View(entity);
            }
        }

        [HttpGet]
        public IActionResult AddOrUpdate(int? id)
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "CategoryId", "Name");
            if (id==null)
            {
                //yeni kayıt
                return View(new Blog());
            }
            else
            {
                //güncelleme işlemi
                return View(blogRepository.GetById((int)id));
            }
        }

        [HttpPost]
        public IActionResult AddOrUpdate(Blog entity) //Ekleme ve güncelleme işlemleri için 2 ayrı method yazmak yerine tek method yazarak hallediyoruz.
        {
            if (ModelState.IsValid)
            {
                blogRepository.SaveBlog(entity);
                TempData["message"] = $"{entity.Title} kayıt edildi";
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "CategoryId", "Name");
                return View(entity);
            }
        }

        [HttpGet]
        public IActionResult Delete (int id)
        {
            return View(blogRepository.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed (int blogId)
        {
            blogRepository.DeleteBlog(blogId);
            TempData["message"] = $"{blogId} numaralı kayıt silindi";
            return RedirectToAction("List");
        }
    }
}