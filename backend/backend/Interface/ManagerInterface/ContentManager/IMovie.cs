using backend.ModelDTO.ContentManagement.MovieRequest;
namespace backend.Interface.ManagerInterface.ContentManager
{
    public interface IMovie
    {
        // Tạm thời để boolean

        Task<bool> uploadMovie(MovieRequestDTO movieRequestDTO);
    }
}
