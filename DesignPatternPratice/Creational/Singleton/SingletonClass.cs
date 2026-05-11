namespace DesignPatternPratice.Creational;

public sealed class SingletonClass
{
    public int HashCode { get; }

    private static readonly Lazy<SingletonClass> lazyInstance = new Lazy<SingletonClass>(() => new SingletonClass());

    private SingletonClass()
    {
        this.HashCode = Guid.NewGuid().GetHashCode();
    }

    public static SingletonClass Instance
    {
        get
        {
            return lazyInstance.Value;
        }
    }

    public bool IsSameObject(int other)
    {
        if (other == this.HashCode)
        {
            return true;
        }
        return false;
    }
}
