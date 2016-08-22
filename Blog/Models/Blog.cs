using System;
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
        [StringLength(254, MinimumLength = 3)]
        public string Title { get; set;}

        [Display(Name = "Blog Message")]
        [RegularExpression(@"^[A-Z]+[\d\D]*$")]
        [Required]
        [StringLength(254)]
        public string Message { get; set; }

        [Display(Name ="Time to read (in minutes)")]
        public int TimeToRead { get; set; }

        public float Rating { get; set; }

        [Display(Name = "Date of Blog")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PublishedDate { get; set; }
    }

    public class BlogDBContext : DbContext
    {
        public DbSet<Post> Blogs { get; set; }
    }
}