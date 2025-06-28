namespace backend.ModelDTO.Customer.OrderRequest
{
    public class OrderRequestDTO
    {
        public string userId { get; set; } = "";

        public string movieScheduleId { get; set; } = string.Empty;

        public bool isPayment { get; set; } = false;

        public List<SeatsRequestDTO> seatsRequestDTOs { get; set; } = [];

        public List<FoodRequestDTO> foodRequestDTOs { get; set; } = [];

        public List<userTypeRequestDTO> userTypeRequestDTO { get; set; } = [];
    }

    public class userTypeRequestDTO
    {
        public string userTypeID { get; set; } = string.Empty;
        public int quantity { get; set; } // Số lượng của món ăn này
    }

    public class SeatsRequestDTO
    {
        public string seatID { get; set; } = string.Empty;

    }

    public class FoodRequestDTO
    {
        public string foodID { get; set; } = string.Empty;
        public int quantity { get; set; } 

    }
}
