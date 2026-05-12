namespace DesignPatternPratice.Structural.Adapter;

public class ThirdPartyPayment
{
    public void MakePayment(double money)
    {
        Console.WriteLine($"第三方支付成功：{money}");
    }
}
