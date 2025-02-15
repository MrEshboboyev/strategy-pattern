using Domain.Models;

namespace Domain.Interfaces;

public interface IPaymentStrategy
{
    bool ProcessPayment(Order order);
}
