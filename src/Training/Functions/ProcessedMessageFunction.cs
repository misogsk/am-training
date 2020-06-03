using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Training.Functions
{
    public static class ProcessedMessageFunction
    {
        [FunctionName("ProcessedMessageFunction")]
        public static void Run([ServiceBusTrigger("file-processed", "aztrain", Connection = "FileProcessor")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
            //store data to table storage
        }
    }
}
