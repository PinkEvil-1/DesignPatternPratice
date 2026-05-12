using DesignPatternPratice.Behavioral.Observer.Interface;

namespace DesignPatternPratice.Behavioral.Observer.Observer;

public class UIObserver : IObserver
{
    public void UPdate(int level)
    {
        Console.WriteLine($"UI更新：玩家等級 {level}");
    }
}
