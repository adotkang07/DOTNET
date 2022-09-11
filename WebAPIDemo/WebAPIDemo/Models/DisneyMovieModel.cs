using System.ComponentModel.DataAnnotations;

namespace WebAPIDemo.Models
{
    public class DisneyMovieModel
    {
        public int Id { get; set; }

        public string Title { get; set; }


        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
    }
}
