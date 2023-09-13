using ParallelTaskApp.Model;
using ParallelTaskApp.Services.Interface;

namespace ParallelTaskApp.Services.Implementation
{
    public class ShippingService : IShippingService
    {
        public async Task<List<Shipping>> GetShippingService()
        {
            List<Shipping> shippingDetails = new List<Shipping>();
            {
                shippingDetails.Add(new Shipping { ShippingId = 1, CustomerId = 1, OrderId=  1, ShippingStatus = 1 });
                shippingDetails.Add(new Shipping { ShippingId = 2, CustomerId = 1, OrderId=  5, ShippingStatus = 1 });
                shippingDetails.Add(new Shipping { ShippingId = 7, CustomerId = 1, OrderId = 4, ShippingStatus = 1 });
                shippingDetails.Add(new Shipping { ShippingId = 3, CustomerId = 2, OrderId=  2, ShippingStatus = 1 });
                shippingDetails.Add(new Shipping { ShippingId = 4, CustomerId = 2, OrderId=  6, ShippingStatus =1 });
                shippingDetails.Add(new Shipping { ShippingId = 8, CustomerId = 2, OrderId = 10, ShippingStatus = 1 });
                shippingDetails.Add(new Shipping { ShippingId = 5, CustomerId = 3, OrderId=  3, ShippingStatus =1 });
                shippingDetails.Add(new Shipping { ShippingId = 6, CustomerId = 3, OrderId=  7, ShippingStatus = 1 });
                shippingDetails.Add(new Shipping { ShippingId = 9, CustomerId = 3, OrderId = 8, ShippingStatus = 1 });

            };
            return shippingDetails;
        }
    }
}
