using System.ComponentModel.DataAnnotations;

namespace VueBlog.ModelsDtos
{
    public class BlogDto
    {
        [Key]
        public int BlogID { get; set; }

        [StringLength(255)]
        public string Blog_Name { get; set; }
    }
}
