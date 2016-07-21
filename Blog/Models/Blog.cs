using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Blog.Models
{
    [Table("myDetaisl")]
    public class Post
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Blog Title")]
        public string Title { get; set;}
        [Display(Name = "Blog Message")]
        public string Message { get; set; }
        [Display(Name ="Time to read (in minutes)")]
        public int TimeToRead { get; set; }


        public float Rating { get; set; }
    }

    public class BlogDBContext : DbContext
    {
        public DbSet<Post> Blogs { get; set; }
    }
}