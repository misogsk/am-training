using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;
using System;
using System.Text;

namespace MessageGenerator
{
    class Program
    {
        static async void Main(string[] args)
        {
            var busClient = new TopicClient("connectionstring", "topic");

            //p.DeliveryKardex = 24181;
            var dto = new
            {
                name = "test"
            };
            await busClient.SendAsync(CreateServiceBusMessage(dto));
        }

        private static Message CreateServiceBusMessage(object messageData)
        {
            var serializedPackage = JsonConvert.SerializeObject(messageData);
            var message = new Message(Encoding.UTF8.GetBytes(serializedPackage));
            return message;
        }

    }
}
