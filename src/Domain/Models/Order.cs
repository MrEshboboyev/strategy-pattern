namespace Domain.Models;

public class Order(int orderId, decimal amount, string customerEmail)
{
    public int OrderId { get; } = orderId;
    public decimal Amount { get; } = amount;
    public string CustomerEmail { get; } = customerEmail;
}
