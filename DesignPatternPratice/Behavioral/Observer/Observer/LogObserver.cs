using DesignPatternPratice.Behavioral.Observer.Interface;

namespace DesignPatternPratice.Behavioral.Observer.Observer;

public class LogObserver : IObserver
{
    public void UPdate(int level)
    {
        Console.WriteLine($"LOG：玩家升級到 {level}");
    }
}
