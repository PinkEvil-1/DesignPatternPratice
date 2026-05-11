using DesignPatternPratice.Creational.AbstractFactory.Class;
using DesignPatternPratice.Creational.AbstractFactory.Interface;

namespace DesignPatternPratice.Creational.AbstractFactory;

public class JdbFactory : IPlatformFactory
{
    public IApiClient CreateApiClient()
    {
        return new JdbApiClient();
    }

    public IBetParser CreateBetParser()
    {
        return new JdbBetParser();
    }

    public IErrorHandler CreateErrorHandler()
    {
        return new JdbErrorHandler();
    }
}
