using backend.Data;
using backend.Enum;
using backend.Interface.PriceInterfaces;
using backend.ModelDTO.GenericRespond;
using backend.ModelDTO.PriceDTOs;
using Microsoft.EntityFrameworkCore;

namespace backend.Services.PriceServices;

public class PriceService(DataContext dataContext) : IPriceService
{
    private readonly DataContext _context = dataContext;
    
    public GenericRespondWithObjectDTO<List<UserTypeRequestGetListPriceDTO>> 
        GetListPrice(string movieVisualFormatId)
    {
        // Truy Van Toi Bang Price De Lay Data

        var getPriceInfo =
            _context.priceInformationForEachUserFilmType
                .Where(x => x.movieVisualFormatId.Equals(movieVisualFormatId))
                .Include(x => x.userType)
                .Include(x => x.PriceInformation);
        
        List<UserTypeRequestGetListPriceDTO> userTypeListPrice = new List<UserTypeRequestGetListPriceDTO>();

        if (getPriceInfo != null)
        {
            foreach (var getPrices in getPriceInfo)
            {
                UserTypeRequestGetListPriceDTO userTypeDTO = new UserTypeRequestGetListPriceDTO()
                {
                    UserTypeId = getPrices.userTypeId,
                    UserTypeWithPriceDTO = new UserTypeWithPriceDTO()
                    {
                        Price = getPrices.PriceInformation.priceAmount ,
                        UserTypeName= getPrices.userType.userTypeDescription
                    }
                };
                userTypeListPrice.Add(userTypeDTO);
            }

            return new GenericRespondWithObjectDTO<List<UserTypeRequestGetListPriceDTO>>()
            {
                Status = GenericStatusEnum.Success.ToString(),
                message = "Successfully retrieved list price for userType",
                data = userTypeListPrice
            };
        }

        return new GenericRespondWithObjectDTO<List<UserTypeRequestGetListPriceDTO>>()
        {
            Status = GenericStatusEnum.Failure.ToString(),
            message = "Failed to get list price.",
        };
    }
}