using DesignPatternPratice.Behavioral.Observer;
using DesignPatternPratice.Behavioral.Observer.Observer;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternPraticeTests.Behavioral.Observer;

[TestClass()]
public class ObserverClassTests : TestBase
{
    protected override void ConfigureServices(IServiceCollection services)
    {
    }

    [TestMethod()]
    public void ObserverWork()
    {
        var player = new Player();

        player.Subscribe(new UIObserver());
        player.Subscribe(new LogObserver());
        player.Subscribe(new AchievementObserver());

        player.LevelUp();
        player.LevelUp();
    }
}