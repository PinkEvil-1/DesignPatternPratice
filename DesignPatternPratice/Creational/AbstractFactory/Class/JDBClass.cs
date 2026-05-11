using DesignPatternPratice.Creational.AbstractFactory.Interface;

namespace DesignPatternPratice.Creational.AbstractFactory.Class;

public class JdbApiClient : IApiClient
{
    public void Send()
    {
        Console.WriteLine("JDB API 呼叫");
    }
}

public class JdbBetParser : IBetParser
{
    public void Parse()
    {
        Console.WriteLine("JDB 解析注單");
    }
}

public class JdbErrorHandler : IErrorHandler
{
    public void Handle()
    {
        Console.WriteLine("JDB 錯誤處理");
    }
}
