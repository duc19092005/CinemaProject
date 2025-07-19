namespace backend.ModelDTO.ScheduleDTO.Respond
{
    public class ScheduleGetListsRepsond
    {
        public DateTime ShowDateTime { get; set; } 
    }

    public class cinemaList
    {
        public string cinemaID { get; set; }
        public string cinemaName { get; set; } = string.Empty;

        public string cinemaLocation { get; set; } = string.Empty;

        public List<cinemaShowTimeInEachCinema> cinemaShowTimeInEachCinema = [];
    }

    public class cinemaShowTimeInEachCinema
    {
        public string showTimeID { get; set; } = string.Empty;
        public string showTime { get; set; } = string.Empty;
    }
}
