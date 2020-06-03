using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: FunctionsStartup(typeof(Training.Startup))]
namespace Training
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var config = new ConfigurationBuilder().
                SetBasePath(Environment.CurrentDirectory).
                AddJsonFile("local.settings.json").
                AddEnvironmentVariables().
                Build();
                
        }
    }
}
