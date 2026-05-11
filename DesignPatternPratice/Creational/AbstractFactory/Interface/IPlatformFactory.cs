namespace DesignPatternPratice.Creational.AbstractFactory.Interface;

public interface IPlatformFactory
{
    IApiClient CreateApiClient();

    IBetParser CreateBetParser();

    IErrorHandler CreateErrorHandler();
}
