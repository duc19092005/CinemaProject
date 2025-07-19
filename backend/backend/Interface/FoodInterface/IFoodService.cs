using backend.ModelDTO.Customer.OrderRequest;
using backend.ModelDTO.FoodDTOS;
using backend.ModelDTO.GenericRespond;

namespace backend.Interface.FoodInterface;

public interface IFoodService
{
    GenericRespondWithObjectDTO<List<FoodGetListRequestDTO>> getFullListOfFoods();
}