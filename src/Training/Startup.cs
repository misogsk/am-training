using Microsoft.Azure.Functions.Extensions.DependencyInjection;
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
            throw new NotImplementedException();
        }
    }
}
