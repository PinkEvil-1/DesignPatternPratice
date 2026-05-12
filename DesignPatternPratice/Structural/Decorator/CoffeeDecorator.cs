using DesignPatternPratice.Structural.Decorator.Interface;

namespace DesignPatternPratice.Structural.Decorator;

public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }

    public virtual int GetCost()
    {
        return _coffee.GetCost();
    }
}
