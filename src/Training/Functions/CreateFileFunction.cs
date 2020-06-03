using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.Storage.Blob;
using Microsoft.Azure.Storage;
using Microsoft.Extensions.Configuration;

namespace Functions.Training
{
    public class CreateFileFunction
    {
        private readonly IConfigurationRoot root;
        public CreateFileFunction(IConfigurationRoot configurationRoot)
        {
            root = configurationRoot;
        }
        [FunctionName("CreateFile")]
        public async Task<IActionResult> CreateFile(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            //create file with data
            log.LogInformation("C# HTTP trigger function processed a request.");
            var account = CloudStorageAccount.Parse(root["StorageConnectionString"]);

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            var fileName = data?.fileName;
            var responseMessage = string.Empty;
            if (string.IsNullOrEmpty(fileName))
            {
                responseMessage = "No file name in body";
            }
            responseMessage = string.IsNullOrEmpty(fileName)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {fileName}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
        }
    }
}
