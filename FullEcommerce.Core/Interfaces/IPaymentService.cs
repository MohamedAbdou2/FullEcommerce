using FullEcommerce.Core.Entities;
using FullEcommerce.Core.Entities.OrderAggregate;

namespace FullEcommerce.Core.Interfaces
{
    public interface IPaymentService
    {
        Task<CustomerBasket> CreateOrUpdatePaymentIntent(string basketId);
        Task<Order> UpdateOrderPaymentSucceded(string paymentIntentId);
        Task<Order> UpdateOrderPaymentFailed(string paymentIntentId);


    }
}
