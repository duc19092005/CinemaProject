using backend.ModelDTO.MoviesDTO.MovieRespond;

namespace backend.ModelDTO.PaginiationDTO.Respond
{
    public class PagniationRespond
    {
        public List<movieRespondDTO> movieRespondDTOs { get; set; } = [];

        public int pageSize { get; set; }

        public int page {  get; set; }

        public int totalCount { get; set; }
    }
}
