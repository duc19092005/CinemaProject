namespace backend.ModelDTO.PriceDTOs;

public class UserTypeRequestGetListPriceDTO
{
    public string UserTypeId { get; set; } = string.Empty;

    public UserTypeWithPriceDTO UserTypeWithPriceDTO { get; set; } = null!;
}

public class UserTypeWithPriceDTO
{
    public string UserTypeName { get; set; } = string.Empty;
    
    public long Price { get; set; }
}