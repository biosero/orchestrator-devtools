using Biosero.DataServices.Client;
using Biosero.Orchestrator.DevTools;
using Biosero.Orchestrator.WorkflowService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Acme.Orchestrator.Scripting.Tests
{
    [TestClass]
    public class Script1_DoesNothing_Tests
    {
        [TestMethod]
        public async Task Execute_Directly()
        {
            var script = new Script1_DoesNothing();
            var client = new Mock<DataServicesClient>().Object;

            await script.RunAsync(client, new WorkflowContext(), CancellationToken.None);
        }

        [TestMethod]
        public void Compile_As_Script()
        {
            var scriptText = File.ReadAllText("Script1_DoesNothing.cs");

            ScriptHelper.Compile(scriptText);
        }

        [TestMethod]
        public async Task Execute_As_Script()
        {
            var scriptText = File.ReadAllText("Script1_DoesNothing.cs");
            var client = new Mock<DataServicesClient>().Object;
            var context = new WorkflowContext();

            await ScriptHelper.RunAsync(scriptText, client, context);
        }
    }
}