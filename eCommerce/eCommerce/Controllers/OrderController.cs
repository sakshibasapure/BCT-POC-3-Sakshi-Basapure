using System.Collections.Generic;
using System.Threading.Tasks;
using eCommerce.Dto;
using eCommerce.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Models;

namespace eCommerce.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        readonly IOrderService _orderService;
        

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Get the list of all the orders placed by a particular user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public async Task<List<OrdersDto>> Get(int userId)
        {
            
            return await Task.FromResult(_orderService.GetOrderList(userId)).ConfigureAwait(true);

        }


        
    }
}
