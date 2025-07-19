using backend.Data;
using backend.Enum;
using backend.Interface.FoodInterface;
using backend.ModelDTO.Customer.OrderRequest;
using backend.ModelDTO.FoodDTOS;
using backend.ModelDTO.GenericRespond;

namespace backend.Services.FoodServices;

public class FoodService : IFoodService
{
    private readonly DataContext _context;

    public FoodService(DataContext context)
    {
        _context = context;
    }
    public GenericRespondWithObjectDTO<List<FoodGetListRequestDTO>> getFullListOfFoods()
    {
        try
        {
            // Lấy Data Thng tin thức ăn

            List<FoodGetListRequestDTO> foodRequests = new List<FoodGetListRequestDTO>();

            var getFoodInfo = _context.foodInformation.ToList();

            foreach (var getFood in getFoodInfo)
            {
                foodRequests.Add(new FoodGetListRequestDTO
                {
                    FoodId = getFood.foodInformationId,
                    FoodName = getFood.foodInformationName,
                    FoodPrice = getFood.foodPrice,
                });
            }

            return new GenericRespondWithObjectDTO<List<FoodGetListRequestDTO>>()
            {
                Status = GenericStatusEnum.Success.ToString(),
                message = "Food list retrieved successfully.",
                data = foodRequests
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message.ToString());
            return new GenericRespondWithObjectDTO<List<FoodGetListRequestDTO>>()
            {
                Status = GenericStatusEnum.Failure.ToString(),
                message = e.Message.ToString(),
            };
        }
    }

}