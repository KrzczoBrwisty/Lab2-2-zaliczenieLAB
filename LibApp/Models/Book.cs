using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the title of the book")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the Author of the book")]
        public string Author { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "Please enter the Genre of the book")]
        public int GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage = "Please select the book's release date")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "How many books are there?")]
        [Range(1, 20, ErrorMessage = "Range from 1 to 20")]
        public byte NumberInStock { get; set; }
    }
}
