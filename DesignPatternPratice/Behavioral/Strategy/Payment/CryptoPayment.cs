using DesignPatternPratice.Behavioral.Strategy.Interface;

namespace DesignPatternPratice.Behavioral.Strategy.Payment;

public class CryptoPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"加密貨幣付款 {amount}");
    }
}
