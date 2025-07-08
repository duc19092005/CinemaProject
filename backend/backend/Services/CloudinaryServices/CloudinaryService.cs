using backend.Interface.CloudinaryInterface;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Security.Cryptography;
using System.Text;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace backend.Services.CloudinaryServices
{
    public class CloudinaryService : ICloudinaryServices
    {
        private readonly IConfiguration _configuration;
        public CloudinaryService(IConfiguration configuration) 
        {
            this._configuration = configuration;
        }

        //public async Task<string> postRequest(IFormFile file)
        //{
        //    string url = $"https://api.cloudinary.com/v1_1/{_configuration["Cloudinary:CloudName"].ToString() ?? null}/image/upload";

        //    // Lấy thời gian
        //    var getTimeSpan = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
        //    // Lấy APIkey // Mấy cái này nó ko null a ơi maauuy này e debug kĩ lắm rùi
        //    var apikey = _configuration["Cloudinary:ApiKey"];
        //    //Lấy Apisecrect // Mấy cái này nó ko null a ơi maauuy này e debug kĩ lắm rùi
        //    var apiSecrect = _configuration["Cloudinary:ApiSecrect"];

        //    string uploadPreset = "ml_default";

        //    byte[] imageData;
        //    using (var memorySteam = new MemoryStream())
        //    {
        //        file.CopyTo(memorySteam);
        //        imageData = memorySteam.ToArray();
        //    }

        //    // Hash Dictionary

        //    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
        //    {
        //        {"timestamp" , getTimeSpan.ToString() },
        //        {"public_id" , file.FileName.Replace(" " , "") },
        //        {"upload_preset"  , "ml_default"}  
        //    };

        //    // Convert to key=value&key1=value1 ...

        //    var convertToURL = keyValuePairs.OrderBy(x => x.Key).Select(x => x.Key + "=" + x.Value);

        //    // kết hợp với api secrect

        //    var convertToCloudinaryForm = String.Join("&", convertToURL) + apiSecrect;

        //    // Mã hóa

        //    var getHash = SHA256Convert(convertToCloudinaryForm);

        //    // FormData request

        //    var formData = new MultipartFormDataContent();

        //    Console.WriteLine(String.IsNullOrEmpty(Convert.ToBase64String(imageData)) ? "Null" : "NotNull");
        //    Console.WriteLine(apikey);
        //    Console.WriteLine(getTimeSpan);
        //    Console.WriteLine(getHash);

        //    formData.Add(new ByteArrayContent(imageData), "file", file.FileName.Replace(" ", ""));
        //    formData.Add(new StringContent(!String.IsNullOrEmpty(apikey) ? apikey : ""), "api_key");
        //    formData.Add(new StringContent(getTimeSpan), "timestamp");
        //    formData.Add(new StringContent(getHash), "signature");
        //    formData.Add(new StringContent(file.FileName.Replace(" ", "")), "public_id");
        //    formData.Add(new StringContent(uploadPreset), "upload_preset");

        //    // Tạo yêu cầu Post

        //    var getFilePath = Path.GetFullPath(file.FileName);

        //    var postRequest = await new HttpClient().PostAsync(url, formData);

        //    // Nó trả về lỗi 400 a ơi =(((((( e có bê nguyên cái này qua bên postman
        //    // có cả signature với timespan mà nó chạy đc trả về 200 còn ở đây nó bonk cho e 
        //    // Cái lỗi 400

        //    return await postRequest.Content.ReadAsStringAsync();
        //}


        // Test dùng thư viện
        public async Task<string> uploadFileToCloudinary(IFormFile formFile)
        {
            // Tạo GUID mới để file ko bị trùng
            var newGuid = Guid.NewGuid();
            Account account = new Account()
            {
                ApiKey = _configuration["Cloudinary:ApiKey"] ,
                ApiSecret = _configuration["Cloudinary:ApiSecrect"] ,
                Cloud = _configuration["Cloudinary:CloudName"]
            };
            Cloudinary cloudinary = new Cloudinary(account);
            var FileUpload = new ImageUploadParams()
            {
                File = new FileDescription(formFile.FileName , formFile.OpenReadStream()) ,
                PublicId = newGuid.ToString(),
            };
            var getUpload = await cloudinary.UploadAsync(FileUpload);
            return getUpload.Url.ToString();
        }
    }
}
