using WebAPIDemo.Models;

namespace WebAPIDemo.Services
{
    public class DisneyMovieService
    {
        public static List<DisneyMovieModel>  DisneyMovies = new List<DisneyMovieModel>
        {
            new DisneyMovieModel {
                Id = 1,
                Title = "Thor Love & Thunder",
                Genre = "Action-Adventure",
                ReleaseDate =  new DateTime(2022, 7, 8),
                MainCharacter = "Thor"
            },
            new DisneyMovieModel {
                Id = 2,
                Title = "Doctor Strange in the Multiverse of Madness",
                Genre = "Action-Adventure",
                ReleaseDate =  new DateTime(2022, 5, 6),
                MainCharacter = "Dr. Strange"
            },
            new DisneyMovieModel
            {
                Id = 2,
                Title = "Raya and the Last Dragon",
                Genre = "Action-Adventure",
                ReleaseDate = new DateTime(2021, 3, 5),
                MainCharacter = "Raya"
            }
        };
    }
}
