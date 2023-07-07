using Biosero.DataServices.Client;
using Biosero.Orchestrator.WorkflowService;
using Westwind.Scripting;

namespace Biosero.Orchestrator.DevTools
{
    public class ScriptHelper
    {
        public static void Compile(string script)
        {
            var scriptExecution = new CSharpScriptExecution
            {
                ThrowExceptions = true,
            };

            scriptExecution.AddDefaultReferencesAndNamespaces();
            scriptExecution.AddLoadedReferences();
            scriptExecution.AddAssembly(typeof(DataServicesClient));

            scriptExecution.CompileClass(script);

            if (scriptExecution.Error)
            {
                throw scriptExecution.LastException;
            }
        }

        public static Task RunAsync(string script, DataServicesClient client, WorkflowContext context)
        {
            var scriptExecution = new CSharpScriptExecution
            {
                ThrowExceptions = true,
            };

            scriptExecution.AddDefaultReferencesAndNamespaces();
            scriptExecution.AddLoadedReferences();
            scriptExecution.AddAssembly(typeof(DataServicesClient));

            dynamic compiledScript = scriptExecution.CompileClass(script);

            if (scriptExecution.Error)
            {
                throw scriptExecution.LastException;
            }

            return compiledScript.RunAsync(client, context, CancellationToken.None);
        }
    }
}
