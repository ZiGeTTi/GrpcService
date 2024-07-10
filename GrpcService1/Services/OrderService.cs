namespace GrpcService1.Services
{
    public interface IOrderRepository
    {
        public Task<Order> GetOrder();
    }
    public class OrderService
    {
    }
}
