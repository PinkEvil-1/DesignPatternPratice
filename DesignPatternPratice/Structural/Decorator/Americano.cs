using DesignPatternPratice.Structural.Decorator.Interface;

namespace DesignPatternPratice.Structural.Decorator;

public class Americano : ICoffee
{
    public int GetCost()
    {
        return 60;
    }

    public string GetDescription()
    {
        return "美式咖啡";
    }
}
