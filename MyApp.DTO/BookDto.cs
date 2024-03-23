using System.ComponentModel.DataAnnotations;

namespace MyApp.DTO
{
    public record CreateBookDto([Required(ErrorMessage = "Title is requiered")] string BookTitle, string BookDescription, [Required(ErrorMessage = "Author is requiered")] int AuthorId);
    public record UpdateBookDto([Required(ErrorMessage = "Book id is requiered")] int Id,  [Required(ErrorMessage = "Book title is requiered")] string BookTitle, string BookDescription, [Required(ErrorMessage = "Author is requiered")] int AuthorId);

    public record GetBookDto(int Id, string BookTitle, string BookDescription);
}


