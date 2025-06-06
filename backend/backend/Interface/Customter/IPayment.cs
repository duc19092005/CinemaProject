namespace backend.Interface.Customter
{
    public interface IPayment
    {
        Task<string> createURL();
    }
}
