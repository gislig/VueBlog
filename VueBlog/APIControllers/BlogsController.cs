using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VueBlog.Models;
using VueBlog.ErrorHandling;
using VueBlog.ModelsDtos;
using AutoMapper;

namespace VueBlog.Controllers
{
    [Produces("application/json")]
    [Route("api/Blogs")]
    [Route("api/Blog")]
    [ModelErrorHandler]
    public class BlogsController : Controller
    {
        private VueBlogContext _context;

        public BlogsController(VueBlogContext context) => _context = context;

        // GET /api/blogs
        public IEnumerable<BlogDto> GetBlogs()
        {
            return _context.Blogs.ToList().Select(Mapper.Map<Blog, BlogDto>);
        }

        [Route("/api/blogs/{BlogID:int}", Name = "GetBlogById")]
        public BlogDto GetBlog(int BlogID)
        {
            var blogDto = _context.Blogs.SingleOrDefault(c => c.BlogID == BlogID);

            return Mapper.Map<Blog, BlogDto>(blogDto);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Blog item)
        {
            if (item == null)
            {
                return BadRequest();
            }
        
            _context.Blogs.Add(item);
            _context.SaveChanges();
        
            return Created("GetBlogById", new { id = item.BlogID });
        }

        //[HttpPost]
        //public IActionResult Create(BlogDto blogDto)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest();
        //
        //    var blog = Mapper.Map<BlogDto, Blog>(blogDto);
        //    _context.Blogs.Add(blog);
        //    _context.SaveChanges();
        //
        //    //blogDto.BlogID = blog.BlogID;
        //
        //    string uri = Url.Link("GetBlogByID", new { blogid = blogDto.BlogID });
        //
        //    return Created(uri, blogDto);
        //}

        [HttpPut]
        public void UpdateBlog(int id, BlogDto blogDto)
        {
            var blogInDb = _context.Blogs.SingleOrDefault(c => c.BlogID == id);

            Mapper.Map(blogDto, blogInDb);

            _context.SaveChanges();

            //string uri = Url.Link("GetBlogByID", new { blogid = blogDto.BlogID });
        }

        [HttpDelete]
        public void DeleteBlog(int id)
        {
            var blogInDb = _context.Blogs.SingleOrDefault(c => c.BlogID == id);

            _context.Blogs.Remove(blogInDb);
            _context.SaveChanges();
        }
    }
}