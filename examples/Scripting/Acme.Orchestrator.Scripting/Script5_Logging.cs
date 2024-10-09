using System.Threading;
using System.Threading.Tasks;
using Biosero.DataServices.Client;
using Biosero.Orchestrator.WorkflowService;
using Microsoft.Extensions.Logging;

namespace Acme.Orchestrator.Scripting
{
    // Scripts require a class with a parameterless constructor and a RunAsync method matching the below signature.
    public class Script5_Logging
    {
        public Task RunAsync(DataServicesClient client, WorkflowContext context, CancellationToken cancellationToken)
        {
            // information logs will log to console
            // error logs will log to console & database
            var logger = context.CreateLogger<Script5_Logging>();

            logger.LogTrace("This is a log with level: {Level}.", LogLevel.Trace);
            logger.LogDebug("This is a log with level: {Level}.", LogLevel.Debug);
            logger.LogInformation("This is a log with level: {Level}.", LogLevel.Information);
            logger.LogWarning("This is a log with level: {Level}.", LogLevel.Warning);
            logger.LogError("This is a log with level: {Level}.", LogLevel.Error);
            logger.LogCritical("This is a log with level: {Level}.", LogLevel.Critical);

            return Task.CompletedTask;
        }
    }
}