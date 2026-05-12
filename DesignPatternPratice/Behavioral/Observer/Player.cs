using DesignPatternPratice.Behavioral.Observer.Interface;

namespace DesignPatternPratice.Behavioral.Observer;

public class Player
{
    private readonly List<IObserver> _observers = new();

    private int _level;

    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void LevelUp()
    {
        _level++;

        Console.WriteLine($"玩家升級到 {_level}");

        Notify();
    }

    private void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.UPdate(_level);
        }
    }
}
