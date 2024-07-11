using Grpc.Core;
using GrpcOrderService;
namespace GrpcService1.Services
{
    public interface IOrderRepository
    {
        public Task<Order> GetOrderAsync();
    }
    public class OrderService:OrderProcessing.OrderProcessingBase
    {
        private readonly ILogger<OrderService> _logger;
        private readonly IOrderRepository _orderRepository;
        public OrderService(ILogger<OrderService> logger,
          IOrderRepository orderRepository)
        {
            _logger = logger;
            _orderRepository = orderRepository;
        }

        public override async Task<OrderResponse> GetOrder(OrderRequest request, ServerCallContext context)
        {
            return await Task.FromResult(new OrderResponse
            {
                Order = await _orderRepository.GetOrderAsync()
            });
        }
    }


}
