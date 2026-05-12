using DesignPatternPratice.Structural.Adapter;
using DesignPatternPratice.Structural.Adapter.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternPraticeTests.Structural.Adapter;

[TestClass()]
public class AdapterClassTests : TestBase
{
    protected override void ConfigureServices(IServiceCollection services)
    {
    }

    [TestMethod()]
    public void AdapterWork()
    {
        IPaymentService paymentService = new PaymentAdapter(new ThirdPartyPayment());

        paymentService.Pay(1000);
    }
}