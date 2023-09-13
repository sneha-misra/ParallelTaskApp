using ParallelTaskApp.Model;

namespace ParallelTaskApp.Services.Interface
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrderDetails();
    }
}
