namespace backend.ModelDTO.CommentDTO.CommentRequest
{
    public class CommentRequestDTO
    {
        public string customerID { get; set; } = string.Empty;

        public string movieID { get; set; } = string.Empty;

        public string commentDetail { get; set; } = string.Empty;
    }
}
