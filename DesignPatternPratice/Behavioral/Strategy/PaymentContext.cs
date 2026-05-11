using DesignPatternPratice.Behavioral.Strategy.Interface;

namespace DesignPatternPratice.Behavioral.Strategy;

public class PaymentContext
{
    private readonly IPaymentStrategy _strategy;

    public PaymentContext(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Checkout(decimal amount)
    {
        _strategy.Pay(amount);
    }
}