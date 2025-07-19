using backend.Data;
using backend.Enum;
using backend.Interface.RoomInferface;
using backend.ModelDTO.GenericRespond;
using backend.ModelDTO.RoomDTOS;
using Microsoft.EntityFrameworkCore;
using Seats = backend.Model.CinemaRoom.Seats;

namespace backend.Services.RoomServices;

public class RoomService : IRoomService
{
    private readonly DataContext _context;

    public RoomService(DataContext context)
    {
        _context = context;
    }

    public GenericRespondWithObjectDTO<RoomRequestGetListDTO> getRoomInfo(string movieID , DateTime scheduleDate ,  string HourId , string movieVisualID)
    {
        // Truy van toi bang MovieSchedule de lay data
        
        var getRoomID = _context.movieSchedule
            .FirstOrDefault(x => x.movieVisualFormatID == movieVisualID
            && x.ScheduleDate == scheduleDate
            && x.HourScheduleID == HourId
            && x.movieId == movieID
            && x.ScheduleDate > DateTime.Now);

        if (getRoomID != null)
        {
            // Tiep tuc truy van toi bang room
            var getSeatsNumber = _context.Seats.Include
                (x => x.cinemaRoom)
                .Where(x => x.cinemaRoomId.Equals(getRoomID.cinemaRoomId) && !x.isDelete);
            
            List<SeatsDTO> seatsDTO = new List<SeatsDTO>();
            foreach (var seats in getSeatsNumber)
            {
                seatsDTO.Add
                    (new SeatsDTO()
                    {
                        SeatsId = seats.seatsId,
                        SeatsNumber = seats.seatsNumber,
                        IsTaken = seats.isTaken,
                    });
            }
            // Truyen Thong Tin Vao DTO
            var newGenericRespond = new GenericRespondWithObjectDTO<RoomRequestGetListDTO>()
            {
                Status = GenericStatusEnum.Success.ToString(),
                message = "Room Information",
                data = new RoomRequestGetListDTO()
                {
                    CinemaRoomId = getSeatsNumber.Select(x => x.cinemaRoom.cinemaRoomId).FirstOrDefault(),
                    CinemaRoomNumber = getSeatsNumber.Select(x => x.cinemaRoom.cinemaRoomNumber).FirstOrDefault(),
                    Seats = seatsDTO
                }
            };
            return newGenericRespond;
        }

        return new GenericRespondWithObjectDTO<RoomRequestGetListDTO>()
        {
            Status = GenericStatusEnum.Failure.ToString(),
            message = "Room Request Failed",
        };
    }

}