using DesignPatternPratice.Behavioral.Strategy;
using DesignPatternPratice.Behavioral.Strategy.Interface;
using DesignPatternPratice.Behavioral.Strategy.Payment;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternPraticeTests.Behavioral.Strategy;


[TestClass()]
public class StrategyClassTests : TestBase
{
    protected override void ConfigureServices(IServiceCollection services)
    {
    }

    [TestMethod()]
    public void StrategyWork()
    {
        IPaymentStrategy strategy = new LinePayPayment();
        //Dictionary<PaymentType, IPaymentStrategy> 動態選擇

        var context = new PaymentContext(strategy);
        context.Checkout(1000);
    }
}