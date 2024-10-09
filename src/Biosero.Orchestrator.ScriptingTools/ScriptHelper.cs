using System.Reflection;
using System.Runtime.Loader;
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
        /// <param name="script">The C# script text.</param>
        public static void Compile(string script)
        {
            var scriptExecution = new CSharpScriptExecution
            {
                ThrowExceptions = true,
                AllowReferencesInCode = true,
            };

            scriptExecution.AddDefaultReferencesAndNamespaces();
            scriptExecution.AddLoadedReferences();
            scriptExecution.AddAssembly(typeof(System.Net.Http.Json.HttpClientJsonExtensions));
            scriptExecution.AddAssembly(typeof(System.Text.Json.JsonSerializer));
            scriptExecution.AddAssembly(typeof(Newtonsoft.Json.JsonSerializer));
            scriptExecution.AddAssembly(typeof(Microsoft.Extensions.Logging.ILogger));
            scriptExecution.AddAssembly(typeof(Biosero.DataServices.Client.DataServicesClient));

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
                AllowReferencesInCode = true,
            };

            scriptExecution.AddDefaultReferencesAndNamespaces();
            scriptExecution.AddLoadedReferences();
            scriptExecution.AddAssembly(typeof(System.Net.Http.Json.HttpClientJsonExtensions));
            scriptExecution.AddAssembly(typeof(System.Text.Json.JsonSerializer));
            scriptExecution.AddAssembly(typeof(Newtonsoft.Json.JsonSerializer));
            scriptExecution.AddAssembly(typeof(Microsoft.Extensions.Logging.ILogger));
            scriptExecution.AddAssembly(typeof(Biosero.DataServices.Client.DataServicesClient));

            dynamic compiledScript = scriptExecution.CompileClass(script);

            if (scriptExecution.Error)
            {
                throw scriptExecution.LastException;
            }

            return compiledScript.RunAsync(client, context, CancellationToken.None);
        }

        #region Experimental feature - third party assembly references

        static ScriptHelper()
        {
            // When searching for external references to compile against, the Westwind.Scripting library uses relative paths.
            // Ensure relative paths start at the application base directory.
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);

            // .NET (.NET Core) does not search in the application base directory for assemblies not known at compile time like .NET Framework does.
            // Adding this event handler gives us a 2nd chance to find an assembly referenced by a script in the application base directory.
            AssemblyLoadContext.Default.Resolving += ResolveThirdPartyAssemblies;
        }

        /// <summary>
        /// If we'd wish to reference third party assemblies (.dlls) from scripts, the below functionality will load
        /// them on demand from the application base directory.
        /// </summary>
        private static Assembly ResolveThirdPartyAssemblies(AssemblyLoadContext context, AssemblyName assemblyName)
        {
            var assemblyPath = Path.Combine(AppContext.BaseDirectory, $"{assemblyName.Name}.dll");

            if (!File.Exists(assemblyPath))
            {
                assemblyPath = Path.Combine(AppContext.BaseDirectory, $"{assemblyName.Name}.exe");
            }

            if (!File.Exists(assemblyPath))
            {
                return null;
            }

            return context.LoadFromAssemblyPath(assemblyPath);
        }

        #endregion
    }
}
