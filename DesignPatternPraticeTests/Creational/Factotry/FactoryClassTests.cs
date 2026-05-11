using DesignPatternPratice.Creational.Factory;
using DesignPatternPratice.Creational.Factory.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternPraticeTests;

[TestClass()]
public class FactoryClassTests : TestBase
{

    protected override void ConfigureServices(IServiceCollection services)
    {

    }

    [TestMethod()]
    public void FactoryWork()
    {
        GameServiceFactory factory;

        factory = new SlotGameServiceFactory();
        factory.RunGame();
        // 輸出：啟動老虎機遊戲

        factory = new TableGameServiceFactory();
        factory.RunGame();
        // 輸出：啟動桌遊遊戲
    }
}
