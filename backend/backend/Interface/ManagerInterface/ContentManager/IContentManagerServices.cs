using backend.ModelDTO.ContentManagement.MovieRequest;
namespace backend.Interface.ManagerInterface.ContentManager
{
    public interface IContentManagerServices
    {
        // Tạm thời để boolean

        Task<bool> uploadMovie(MovieRequestDTO movieRequestDTO);
    }
}
