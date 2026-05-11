namespace DesignPatternPratice.Creational.Factory.Interface
{
    // Creator：工廠抽象類別
    public abstract class GameServiceFactory
    {
        public abstract IGameService CreateGameService();

        public void RunGame()
        {
            var gameService = CreateGameService();
            gameService.StartGame();
        }
    }
}
