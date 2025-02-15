using Domain.Interfaces;
using Domain.Models;

namespace Application.Strategies;

public class BitcoinPayment : IPaymentStrategy
{
    public bool ProcessPayment(Order order)
    {
        Console.WriteLine($"₿ Processing Bitcoin payment " +
            $"of ${order.Amount} for {order.CustomerEmail}");
        return true; // Assume success
    }
}
