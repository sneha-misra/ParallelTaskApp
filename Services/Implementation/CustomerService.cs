using ParallelTaskApp.Model;
using ParallelTaskApp.Services.Interface;

namespace ParallelTaskApp.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        public async Task<List<Customer>> GetCustomers()
        {
         
            List<Customer> customers = new List<Customer>();
          {
                customers.Add(new Customer { Id = 1, Name = "Mahesh Chand", Address = "5th Cross road,Andheri", City = "Mumbai" });
                customers.Add(new Customer { Id = 2, Name = "Neel Beniwal", Address = "4/c Borivalli, Naktala", City = "Pune" });
                customers.Add(new Customer { Id = 3, Name = "Chris Love", Address = "13 Park Mansion, Park street", City = "Kolkata" });
          };
            return  customers;
            //return await Task.FromResult(customers);
        }
    }
}
