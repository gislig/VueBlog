using System.ComponentModel.DataAnnotations;

namespace VueBlog.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }

        [Required]
        public string Post_Title { get; set; }

        [Required]
        public string Post_Content { get; set; }

        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
