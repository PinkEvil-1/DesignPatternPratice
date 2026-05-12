using DesignPatternPratice.Structural.Decorator;
using DesignPatternPratice.Structural.Decorator.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternPraticeTests.Structural.Decorator;

[TestClass()]
public class DecoratorClassTests : TestBase
{
    protected override void ConfigureServices(IServiceCollection services)
    {
    }

    [TestMethod()]
    public void DecoratorWork()
    {
        ICoffee coffee = new Americano();

        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);

        Console.WriteLine(coffee.GetDescription());
        Console.WriteLine(coffee.GetCost());
    }
}