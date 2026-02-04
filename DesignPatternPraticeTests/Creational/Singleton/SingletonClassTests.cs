using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternPratice.Creational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Concurrent;

namespace DesignPatternPraticeTests
{
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
            ConcurrentQueue<int> hachCodes = new ConcurrentQueue<int>();
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < checkTime; i++)
            {
                Task task = Task.Run(() =>
                {
                    SingletonClass objectA = SingletonClass.Instance;
                    hachCodes.Enqueue(objectA.GetHashCode());
                });
                tasks.Add(task);
            }

            // Act
            Task.WaitAll(tasks.ToArray());

            //Assert
            hachCodes.TryDequeue(out int firstHashCode);
            while (hachCodes.Count > 0)
            {
                hachCodes.TryDequeue(out int nextHashCode);
                if (firstHashCode != nextHashCode)
                {
                    Assert.Fail();
                }
            }
        }
    }
}