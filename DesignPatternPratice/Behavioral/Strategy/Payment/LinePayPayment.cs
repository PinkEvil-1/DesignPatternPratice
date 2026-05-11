using DesignPatternPratice.Behavioral.Strategy.Interface;

namespace DesignPatternPratice.Behavioral.Strategy.Payment;

public class LinePayPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"LinePay 付款 {amount}");
    }
}
