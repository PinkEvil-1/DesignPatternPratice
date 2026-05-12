using DesignPatternPratice.Behavioral.Observer.Interface;

namespace DesignPatternPratice.Behavioral.Observer.Observer;

public class AchievementObserver : IObserver
{
    public void UPdate(int level)
    {
        if (level >= 10)
        {
            Console.WriteLine("解鎖成就：新手畢業");
        }
    }
}
