using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace VueBlog.Models
{
    public class VueBlogContext : DbContext
    {
        //public VueBlogContext() { }

        public VueBlogContext(DbContextOptions<VueBlogContext> options)
            : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
