using ParallelTaskApp.Model;

namespace ParallelTaskApp.Services.Interface
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomers();
    }
}
