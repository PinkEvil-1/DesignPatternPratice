using DesignPatternPratice.Creational.Factory.Interface;

namespace DesignPatternPratice.Creational.Factory;

// ConcreteCreator：具體工廠
public class SlotGameServiceFactory : GameServiceFactory
{
    public override IGameService CreateGameService()
    {
        return new SlotGameService();
    }
}
