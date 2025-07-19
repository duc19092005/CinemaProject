using backend.ModelDTO.GenericRespond;
using backend.ModelDTO.RoomDTOS;

namespace backend.Interface.RoomInferface;

public interface IRoomService
{
    GenericRespondWithObjectDTO<RoomRequestGetListDTO>  getRoomInfo(string movieID , DateTime scheduleDate ,  string HourId , string movieVisualID);
}