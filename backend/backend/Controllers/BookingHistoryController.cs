using backend.Interface.GenericsInterface;
using backend.ModelDTO.BookingHistoryDTO.OrderDetailRespond;
using backend.ModelDTO.BookingHistoryDTO.OrderRespond;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingHistoryController : ControllerBase
    {
        private readonly GenericInterface<BookingHistoryRespondList, OrderDetailRespond> bookingHistoryList;

        public BookingHistoryController(GenericInterface<BookingHistoryRespondList, OrderDetailRespond> bookingHistoryList)
        {
            this.bookingHistoryList = bookingHistoryList;
        }

        [HttpGet("getBookingHistory/{userID}")]
        public async Task<IActionResult> getBookingHistoryLists(string userID)
        {
            var getLists = await bookingHistoryList.getAll(userID);

            if (getLists.Count > 0)
            {
                return Ok(getLists);
            }

            return NotFound(new {message = "Lỗi rồi chúng tôi Không tìm thấy thông tin của bạn"});
        }
    }
}
