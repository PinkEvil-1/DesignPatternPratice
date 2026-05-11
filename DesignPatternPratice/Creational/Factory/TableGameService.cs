using DesignPatternPratice.Creational.Factory.Interface;

namespace DesignPatternPratice.Creational.Factory
{
    public class TableGameService : IGameService
    {
        public void StartGame()
        {
            Console.WriteLine("啟動桌遊遊戲");
        }
    }
}
