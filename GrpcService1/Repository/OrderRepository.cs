
using GrpcService1.Services;
using GrpcOrderService;
namespace GrpcService1.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public async Task<Order> GetOrderAsync()
        {
            return await Task.FromResult(new Order
            {
                OrderId = 1,
                ShipAddress = "K.Maras Binevler",
                ShipCity = "Onikişubat",
                ShipPostalCode = "464646",
                OrderQuantity = 100
            });
        }
    }
}
