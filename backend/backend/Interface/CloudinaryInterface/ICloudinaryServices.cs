namespace backend.Interface.CloudinaryInterface
{
    public interface ICloudinaryServices
    {
        public Task<string> uploadFileToCloudinary(IFormFile formFile);
    }
}
