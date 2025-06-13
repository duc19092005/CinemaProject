using backend.ModelDTO.MoviesDTO.MovieRequest;
namespace backend.Interface.MovieInterfaces
{
    public interface IMovie
    {
        // Tạm thời để boolean

        Task<bool> uploadMovie(MovieRequestDTO movieRequestDTO);
    }
}
