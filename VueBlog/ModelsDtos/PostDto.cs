using System.ComponentModel.DataAnnotations;

namespace VueBlog.ModelsDtos
{
    public class PostDto
    {
        [Key]
        public int PostID { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Title")]
        public string Post_Title { get; set; }

        [Required]
        [Display(Name = "Content")]
        public string Post_Content { get; set; }
    }
}
