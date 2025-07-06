    namespace backend.ModelDTO.ScheduleDTO.Request
    {
        public class ScheduleRequestDTO
        {
            public string movieID { get; set; } = string.Empty;

            public List<ScheduleDateDTO> scheduleDateDTOs { get; set; } = [];

        }

        public class ScheduleDateDTO
        {
            public DateTime startDate { get; set; }

            public List<ScheduleCinemaDTO> scheduleCinemaDTOs { get; set; } = [];
        }

        public class ScheduleCinemaDTO
        {

            public string cinemaID { get; set; } = string.Empty;

            public List<ScheduleVisualFormat> ScheduleVisualFormat { get; set; } = [];
        }

        public class ScheduleVisualFormat
        {
            public string visualFormatID {  get; set; } = string.Empty;

            public List<ScheduleShowTimeDTO> scheduleShowTimeDTOs { get; set; } = [];
        }

        public class ScheduleShowTimeDTO
        {
            public string showTimeID { get; set; } = string.Empty;

            public List<ScheduleRoomDTO> scheduleRoomDTOs { get; set; } = [];
        }

        public class ScheduleRoomDTO
        {
            public string roomID { get; set; } = String.Empty;
        }
    }
