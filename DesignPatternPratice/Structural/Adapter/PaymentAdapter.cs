using DesignPatternPratice.Structural.Adapter.Interface;

namespace DesignPatternPratice.Structural.Adapter;

public class PaymentAdapter : IPaymentService
{
    private readonly ThirdPartyPayment _thirdPartyPayment;

    public PaymentAdapter(ThirdPartyPayment thirdPartyPayment)
    {
        _thirdPartyPayment = thirdPartyPayment;
    }

    public void Pay(decimal amount)
    {
        // 轉換 decimal -> double
        _thirdPartyPayment.MakePayment((double)amount);
    }
}
