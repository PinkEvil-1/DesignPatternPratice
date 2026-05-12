using DesignPatternPratice.Structural.Decorator.Interface;

namespace DesignPatternPratice.Structural.Decorator;

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + " + 糖";
    }

    public override int GetCost()
    {
        return _coffee.GetCost() + 5;
    }
}
