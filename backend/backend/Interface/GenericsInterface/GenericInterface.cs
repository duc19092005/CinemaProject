using backend.ModelDTO.BookingHistoryDTO.OrderDetailRespond;

namespace backend.Interface.GenericsInterface

{
    // Chia ra làm 2 kiểu generic 
    // T List có nghĩa là danh sách 
    // TDetail có nghĩa là xem chi tiết
    public interface GenericInterface<TList , TDetail>
    {
        Task<List<TList>> getAll(string userID);

        Task<TDetail> getByID(string id);
    }
}
