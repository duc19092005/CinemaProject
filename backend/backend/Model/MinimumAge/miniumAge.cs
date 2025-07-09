using backend.Model.Movie;
using Microsoft.EntityFrameworkCore;

namespace backend.Model.MinimumAge
{
    [Index(nameof(minimumAgeDescription), IsUnique = true)]
    [Index(nameof(minimumAgeInfo) , IsUnique = true)]
    public class minimumAge
    {
        public string minimumAgeID { get; set; } = string.Empty;

        public int minimumAgeInfo { get; set; } 

        public string minimumAgeDescription { get; set; } = string.Empty;

        public List<movieInformation> movieInformation { get; set; } = null!;


    }
}
