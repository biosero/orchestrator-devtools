using Biosero.DataServices.Client;
using Biosero.Orchestrator.WorkflowService;
using Westwind.Scripting;

namespace Biosero.Orchestrator.ScriptingTools
{
    /// <summary>
    /// A static class to simulate the scripting functionality of the Workflow Engine.
    /// </summary>
    public class ScriptHelper
    {
        /// <summary>
        /// Compiles C# script text.
        /// </summary>
        /// <param name="script">The C# script text</param>
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

        /// <summary>
        /// Compiles and runs script text asynchronously.
        /// </summary>
        /// <param name="script">The C# script text.</param>
        /// <param name="client">The DataServices client to pass to the script.</param>
        /// <param name="context">The Workflow context to pass to the script.</param>
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
