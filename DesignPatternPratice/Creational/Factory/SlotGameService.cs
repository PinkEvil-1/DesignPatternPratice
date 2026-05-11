using DesignPatternPratice.Creational.Factory.Interface;

namespace DesignPatternPratice.Creational.Factory
{
    // ConcreteProduct：具體產品
    public class SlotGameService : IGameService
    {
        public void StartGame()
        {
            Console.WriteLine("啟動老虎機遊戲");
        }
    }
}
