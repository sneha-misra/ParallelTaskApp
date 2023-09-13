using Microsoft.AspNetCore.Mvc;
using ParallelTaskApp.Model;
using ParallelTaskApp.Services.Interface;
using System.Diagnostics;

namespace ParallelTaskApp.Controllers
{
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;
        private readonly IShippingService _shippingService;
        static readonly Stopwatch timer = new Stopwatch();
        public CustomerController(ICustomerService customerService, IOrderService orderService, IShippingService shippingService)
        {
            _customerService = customerService;
            _orderService = orderService;
            _shippingService = shippingService;
        }

        [HttpGet]
        [Route("GetCustomerDetails")]
        public async Task<IActionResult> GetCustomerDetails(int customerId)
        {
            timer.Start();
            await Task.Delay(5000);
            var tasklist = new List<Task>();
            Task<List<Order>> ordeDetails = _orderService.GetOrderDetails();
            await Task.Delay(5000);
            Task<List<Customer>> customerDetails = _customerService.GetCustomers();
            Task.WhenAll(customerDetails, ordeDetails);


            var shippingDetails = await _shippingService.GetShippingService();
           
            var selectedcust = from cust in customerDetails.Result
                               join ord in ordeDetails.Result on cust.Id
                               equals ord.CustomerId
                               where ord.CustomerId == customerId

                               select new
                               {
                                   Id = cust.Id,
                                   Name = cust.Name,
                                   Amount = ord.Amount,
                                   OrderId = ord.OrderId,
                                   OrderDate = ord.OrderDate,
                               };
            var finalResult = from cust in selectedcust
                              join ship in shippingDetails on cust.OrderId
                               equals ship.OrderId 

                              select new
                              {
                                  Id = cust.Id,
                                  ShippingStatus = ship.ShippingStatus,
                                  Amount = cust.Amount,
                                  Name = cust.Name,
                                  OrderDate = cust.OrderDate,
                              };
            return Ok(finalResult);

        }
       
    }
}
