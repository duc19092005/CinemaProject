using System.ComponentModel.DataAnnotations;

namespace backend.Model
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        public string ?Name { get; set; }
    }
}
