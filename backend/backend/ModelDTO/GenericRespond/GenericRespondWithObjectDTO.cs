namespace backend.ModelDTO.GenericRespond
{
    public class GenericRespondWithObjectDTO<T>
    {
        public string Status { get; set; } = string.Empty;

        public string message { get; set; } = string.Empty;
        
        public T ? data { get; set; }
    }
}
