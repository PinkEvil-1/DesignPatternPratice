using DesignPatternPratice.Creational.AbstractFactory;
using DesignPatternPratice.Creational.AbstractFactory.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternPraticeTests;

[TestClass()]
public class AbstractFactoryClassTests : TestBase
{
    protected override void ConfigureServices(IServiceCollection services)
    {

    }

    [TestMethod()]
    public void AbstractFactoryWork()
    {
        IPlatformFactory factory;

        // 切換平台, 一個工廠 = 一整套產品
        factory = new PgFactory();
        //factory = new JdbFactory();

        var apiClient = factory.CreateApiClient();
        var parser = factory.CreateBetParser();
        var errorHandler = factory.CreateErrorHandler();

        apiClient.Send();
        parser.Parse();
        errorHandler.Handle();
    }
}
