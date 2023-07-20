using System;
using System.Threading;
using System.Threading.Tasks;
using Biosero.DataServices.Client;
using Biosero.Orchestrator.WorkflowService;

namespace Acme.Orchestrator.Scripting
{
    // Scripts require a class with a parameterless constructor and a RunAsync method matching the below signature.
    public class Script3_DataServicesClient
    {
        public async Task RunAsync(DataServicesClient client, WorkflowContext context, CancellationToken cancellationToken)
        {
            var order = await client.GetOrderAsync(context.OrderIdentifier);

            Console.WriteLine($"Order {order.Identifier} is {order.Status}.");
        }
    }
}