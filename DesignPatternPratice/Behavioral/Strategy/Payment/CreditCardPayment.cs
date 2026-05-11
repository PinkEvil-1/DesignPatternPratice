using DesignPatternPratice.Behavioral.Strategy.Interface;

namespace DesignPatternPratice.Behavioral.Strategy.Payment;

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"信用卡付款 {amount}");
    }
}
