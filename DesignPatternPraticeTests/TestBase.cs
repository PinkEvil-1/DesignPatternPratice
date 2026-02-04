using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternPraticeTests
{
    public abstract class TestBase
    {
        protected ServiceProvider Provider = default!;
        protected ServiceCollection Services = default!;

        [TestInitialize]
        public void Init()
        {
            this.Services = new ServiceCollection();

            // 這裡放「測試共用」的註冊

            ConfigureServices(this.Services);

            this.Provider = Services.BuildServiceProvider(new ServiceProviderOptions
            {
                ValidateScopes = true,
                ValidateOnBuild = true
            });
        }

        protected virtual void ConfigureServices(IServiceCollection services) { }
    }
}
