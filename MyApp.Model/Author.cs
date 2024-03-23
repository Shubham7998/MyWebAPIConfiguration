using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

namespace MyApp.Model
{
    [Table("Authors")]
    [Index(nameof(AuthorEmail), IsUnique = true)]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }
        [Required (ErrorMessage ="Please enter author name.")]
        [MaxLength(40)]
        public string AuthorName { get; set; } = string.Empty;
        [Required (ErrorMessage ="Please enter author email.")]
        public string AuthorEmail { get; set; } = string.Empty;

        public virtual ICollection<Book> Books { get; set; }
    }
}
