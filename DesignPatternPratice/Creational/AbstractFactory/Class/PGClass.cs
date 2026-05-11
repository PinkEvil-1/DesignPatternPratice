using DesignPatternPratice.Creational.AbstractFactory.Interface;

namespace DesignPatternPratice.Creational.AbstractFactory.Class;

public class PgApiClient : IApiClient
{
    public void Send()
    {
        Console.WriteLine("PG API 呼叫");
    }
}

public class PgBetParser : IBetParser
{
    public void Parse()
    {
        Console.WriteLine("PG 解析注單");
    }
}

public class PgErrorHandler : IErrorHandler
{
    public void Handle()
    {
        Console.WriteLine("PG 錯誤處理");
    }
}
