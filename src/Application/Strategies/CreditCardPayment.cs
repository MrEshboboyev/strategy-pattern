using Domain.Interfaces;
using Domain.Models;

namespace Application.Strategies;

public class CreditCardPayment : IPaymentStrategy
{
    public bool ProcessPayment(Order order)
    {
        Console.WriteLine($"💳 Processing credit card payment " +
            $"of ${order.Amount} for {order.CustomerEmail}");
        return true; // Assume success
    }
}
