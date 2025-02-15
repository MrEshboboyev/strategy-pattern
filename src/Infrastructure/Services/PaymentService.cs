using Domain.Interfaces;
using Domain.Models;

namespace Infrastructure.Services;

public class PaymentService
{
    private IPaymentStrategy _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public bool ProcessOrderPayment(Order order)
    {
        if (_paymentStrategy == null)
        {
            throw new Exception("Payment strategy not set.");
        }

        return _paymentStrategy.ProcessPayment(order);
    }
}
