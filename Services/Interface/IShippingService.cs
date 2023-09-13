using ParallelTaskApp.Model;

namespace ParallelTaskApp.Services.Interface
{
    public interface IShippingService
    {
        Task<List<Shipping>> GetShippingService();
    }
}
