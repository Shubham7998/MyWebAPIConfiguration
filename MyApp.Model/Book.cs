using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Model
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Please enter Booktiyle name.")]
        public string Booktitle { get; set; } =string.Empty;
        public string BookDescription { get; set; } = string.Empty;

        [ForeignKey("Author")]

        [Required(ErrorMessage = "Please enter book author id.")]

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
