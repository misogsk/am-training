using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Training
{
    public static class ProcessFileFunction
    {
        [FunctionName("ProcessFileFunction")]
        public static void Run([BlobTrigger("input/{name}", Connection = "FilesStorage")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
            //store data in cosmosdb
        }
    }
}
