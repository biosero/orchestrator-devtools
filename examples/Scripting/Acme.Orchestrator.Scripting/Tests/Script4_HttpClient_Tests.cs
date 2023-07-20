using Biosero.DataServices.Client;
using Biosero.Orchestrator.ScriptingTools;
using Biosero.Orchestrator.WorkflowService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Acme.Orchestrator.Scripting.Tests
{
    [TestClass]
    public class Script4_HttpClient_Tests
    {
        [TestMethod]
        public async Task Execute_Directly()
        {
            var script = new Script4_HttpClient();
            var client = new Mock<DataServicesClient>().Object;

            var context = new WorkflowContext(
                new Parameter
                {
                    Name = "Time",
                    ValueType = ParameterValueType.String,
                });

            await script.RunAsync(client, context, CancellationToken.None);

            Assert.IsNotNull(context.GetGlobalVariableValue<string>("Time"));
        }

        [TestMethod]
        public void Compile_As_Script()
        {
            var scriptText = File.ReadAllText($"{nameof(Script4_HttpClient)}.cs");

            ScriptHelper.Compile(scriptText);
        }

        [TestMethod]
        public async Task Execute_As_Script()
        {
            var scriptText = File.ReadAllText($"{nameof(Script4_HttpClient)}.cs");
            var client = new Mock<DataServicesClient>().Object;

            var context = new WorkflowContext(
                new Parameter
                {
                    Name = "Time",
                    ValueType = ParameterValueType.String,
                });

            await ScriptHelper.RunAsync(scriptText, client, context);

            Assert.IsNotNull(context.GetGlobalVariableValue<string>("Time"));
        }
    }
}