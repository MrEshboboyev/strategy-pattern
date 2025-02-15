using Domain.Interfaces;
using Domain.Models;

namespace Application.Strategies;

public class PayPalPayment : IPaymentStrategy
{
    public bool ProcessPayment(Order order)
    {
        Console.WriteLine($"📧 Processing PayPal payment" +
            $" of ${order.Amount} for {order.CustomerEmail}");
        return true; // Assume success
    }
}
