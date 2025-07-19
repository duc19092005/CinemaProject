using backend.ModelDTO.GenericRespond;
using backend.ModelDTO.PriceDTOs;

namespace backend.Interface.PriceInterfaces;

public interface IPriceService
{
    GenericRespondWithObjectDTO<List<UserTypeRequestGetListPriceDTO>> GetListPrice(string movieVisualFormatId);
}