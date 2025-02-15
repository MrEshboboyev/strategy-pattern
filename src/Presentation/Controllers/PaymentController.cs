using Microsoft.AspNetCore.Mvc;
using Application.Strategies;
using Domain.Models;
using Infrastructure.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly PaymentService _paymentService;

    public PaymentController()
    {
        _paymentService = new PaymentService();
    }

    [HttpPost("pay")]
    public IActionResult ProcessPayment(int orderId, decimal amount, string email, string method)
    {
        var order = new Order(orderId, amount, email);

        switch (method.ToLower())
        {
            case "creditcard":
                _paymentService.SetPaymentStrategy(new CreditCardPayment());
                break;
            case "paypal":
                _paymentService.SetPaymentStrategy(new PayPalPayment());
                break;
            case "bitcoin":
                _paymentService.SetPaymentStrategy(new BitcoinPayment());
                break;
            default:
                return BadRequest("Invalid payment method.");
        }

        bool success = _paymentService.ProcessOrderPayment(order);
        return success ? Ok("Payment successful.") : BadRequest("Payment failed.");
    }
}
