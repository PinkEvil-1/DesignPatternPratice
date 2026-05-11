using DesignPatternPratice.Creational;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Concurrent;

namespace DesignPatternPraticeTests;

[TestClass()]
public class SingletonClassTests : TestBase
{

    protected override void ConfigureServices(IServiceCollection services)
    {

    }

    [TestMethod()]
    public void CheckSingletonIsSameObject_MultiThreat_UseInSameTime()
    {
        // Arrange
        int checkTime = 20;
        ConcurrentQueue<int> hashCodes = new ConcurrentQueue<int>();
        List<Task> tasks = new List<Task>();
        for (int i = 0; i < checkTime; i++)
        {
            Task task = Task.Run(() =>
            {
                SingletonClass objectA = SingletonClass.Instance;
                hashCodes.Enqueue(objectA.GetHashCode());
            });
            tasks.Add(task);
        }

        // Act
        Task.WaitAll(tasks.ToArray());

        //Assert
        hashCodes.TryDequeue(out int firstHashCode);
        while (hashCodes.Count > 0)
        {
            hashCodes.TryDequeue(out int nextHashCode);
            if (firstHashCode != nextHashCode)
            {
                Assert.Fail();
            }
        }
    }
}