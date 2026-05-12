using DesignPatternPratice.Creational.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatternPraticeTests.Creational.Builder;

[TestClass()]
public class BuilderClassTests : TestBase
{

    protected override void ConfigureServices(IServiceCollection services)
    {

    }

    [TestMethod()]
    public void BuilderWork()
    {
        var hero = new CharacterBuilder()
                        .SetName("Knight")
                        .SetHp(100)
                        .SetAttack(30)
                        .SetWeapon("Sword")
                        .Build();
        Console.WriteLine(hero.Name);

        var director = new CharacterDirector();

        var knight = director.CreateKnight();
        var mage = director.CreateMage();
    }
}