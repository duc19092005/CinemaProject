namespace backend.ModelDTO.RoomDTOS;

public class RoomRequestGetListDTO
{
    public string CinemaRoomId { get; set; } = string.Empty;
    
    public int CinemaRoomNumber { get; set; }
    
    public List<SeatsDTO> Seats { get; set; } = [];
}

public class SeatsDTO
{ 
    public string SeatsId { get; set; } = "";

    public string SeatsNumber { get; set; } = "";

    public bool IsTaken { get; set; } = false;
}