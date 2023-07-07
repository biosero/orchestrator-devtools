using System.Threading;
using System.Threading.Tasks;
using Biosero.DataServices.Client;
using Biosero.Orchestrator.WorkflowService;

namespace Acme.Orchestrator.Scripting
{
    // Scripts require a class with a parameterless constructor and a RunAsync method matching the below signature.
    public class Script2_ConcatenateGlobalVariables
    {
        public async Task RunAsync(DataServicesClient client, WorkflowContext context, CancellationToken cancellationToken)
        {
            if (context.TryGetGlobalVariableValue("StringVariableName", out string? stringValue))
            {
                await context.UpdateGlobalVariableAsync("StringVariableName", $"{stringValue} {stringValue}");
            }

            if (context.TryGetGlobalVariableValue("IntegerVariableName", out int integerValue))
            {
                await context.UpdateGlobalVariableAsync("IntegerVariableName", integerValue + integerValue);
            }

            if (context.TryGetGlobalVariableValue("DoubleVariableName", out double doubleValue))
            {
                await context.UpdateGlobalVariableAsync("DoubleVariableName", doubleValue + doubleValue);
            }

            if (context.TryGetGlobalVariableValue("BooleanVariableName", out bool boolValue))
            {
                await context.UpdateGlobalVariableAsync("BooleanVariableName", boolValue && boolValue);
            }
        }
    }
}