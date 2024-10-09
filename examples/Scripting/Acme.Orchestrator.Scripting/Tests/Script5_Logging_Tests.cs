using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Biosero.DataServices.Client;
using Biosero.Orchestrator.ScriptingTools;
using Biosero.Orchestrator.WorkflowService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Acme.Orchestrator.Scripting.Tests
{
    [TestClass]
    public class Script5_Logging_Tests
    {
        [TestMethod]
        public async Task Execute_Directly()
        {
            var script = new Script5_Logging();
            var client = new Mock<DataServicesClient>().Object;

            await script.RunAsync(client, new WorkflowContext(), CancellationToken.None);
        }

        [TestMethod]
        public void Compile_As_Script()
        {
            var scriptText = File.ReadAllText($"{nameof(Script5_Logging)}.cs");

            ScriptHelper.Compile(scriptText);
        }

        [TestMethod]
        public async Task Execute_As_Script()
        {
            var scriptText = File.ReadAllText($"{nameof(Script5_Logging)}.cs");
            var client = new Mock<DataServicesClient>().Object;

            await ScriptHelper.RunAsync(scriptText, client, new WorkflowContext());
        }
    }
}