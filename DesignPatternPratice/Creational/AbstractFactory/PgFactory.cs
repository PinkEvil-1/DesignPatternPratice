using DesignPatternPratice.Creational.AbstractFactory.Class;
using DesignPatternPratice.Creational.AbstractFactory.Interface;

namespace DesignPatternPratice.Creational.AbstractFactory;

public class PgFactory : IPlatformFactory
{
    public IApiClient CreateApiClient()
    {
        return new PgApiClient();
    }

    public IBetParser CreateBetParser()
    {
        return new PgBetParser();
    }

    public IErrorHandler CreateErrorHandler()
    {
        return new PgErrorHandler();
    }
}
