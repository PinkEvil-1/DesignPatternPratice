using DesignPatternPratice.Structural.Decorator.Interface;

namespace DesignPatternPratice.Structural.Decorator;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }
    public override string GetDescription()
    {
        return _coffee.GetDescription() + " + 牛奶";
    }

    public override int GetCost()
    {
        return _coffee.GetCost() + 15;
    }
}
