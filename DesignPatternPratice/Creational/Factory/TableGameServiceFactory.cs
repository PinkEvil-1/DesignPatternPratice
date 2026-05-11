using DesignPatternPratice.Creational.Factory.Interface;

namespace DesignPatternPratice.Creational.Factory
{
    public class TableGameServiceFactory : GameServiceFactory
    {
        public override IGameService CreateGameService()
        {
            return new TableGameService();
        }
    }
}
