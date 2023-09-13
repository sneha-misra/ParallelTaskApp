using ParallelTaskApp.Model;
using ParallelTaskApp.Services.Interface;

namespace ParallelTaskApp.Services.Implementation
{
    public class OrderService : IOrderService
    {
        public async Task<List<Order>> GetOrderDetails()
        {
            List<Order> orders = new List<Order>();
            {
                orders.Add(new Order { OrderId = 1, CustomerId = 1, Amount = 6000, OrderDate = "2022/09/12" });
                orders.Add(new Order { OrderId = 2, CustomerId = 2, Amount = 5000, OrderDate = "2023/09/12" });
                orders.Add(new Order { OrderId = 3, CustomerId = 3, Amount = 6600, OrderDate = "2022/09/12" });
                orders.Add(new Order { OrderId = 4, CustomerId = 1, Amount = 600, OrderDate = "2022/05/12"  });
                orders.Add(new Order { OrderId = 5, CustomerId = 1, Amount = 900, OrderDate = "2022/04/13"  });
                orders.Add(new Order { OrderId = 6, CustomerId = 2, Amount = 7800, OrderDate = "2022/02/02" });
                orders.Add(new Order { OrderId = 7, CustomerId = 3, Amount = 5500, OrderDate = "2023/01/11" });
                orders.Add(new Order { OrderId = 8, CustomerId = 3, Amount = 6400, OrderDate = "2023/09/11" });
                orders.Add(new Order { OrderId = 9, CustomerId = 3, Amount = 100, OrderDate = "2023/08/12"  });
                orders.Add(new Order { OrderId = 10, CustomerId = 2, Amount = 1100, OrderDate = "2022/08/12"});

            };
            //return await Task.FromResult(orders); 
            return orders;
        }

    }
}
