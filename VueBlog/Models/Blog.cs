using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VueBlog.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        [StringLength(255)]
        [Display(Name = "Blog Name")]
        [Required]
        public string Blog_Name { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}
