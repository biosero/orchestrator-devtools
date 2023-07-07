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
    public class Script3_DataServicesGetOrder_Tests
    {
        [TestMethod]
        public async Task Execute_Directly()
        {
            var script = new Script3_DataServicesGetOrder();
            var mockClient = new Mock<DataServicesClient>();

            mockClient
                .Setup(x => x.GetOrderAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new Order());

            await script.RunAsync(mockClient.Object, new WorkflowContext(), CancellationToken.None);

            mockClient
                .Verify(x => x.GetOrderAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public void Compile_As_Script()
        {
            var scriptText = File.ReadAllText($"{nameof(Script3_DataServicesGetOrder)}.cs");

            ScriptHelper.Compile(scriptText);
        }

        [TestMethod]
        public async Task Execute_As_Script()
        {
            var scriptText = File.ReadAllText($"{nameof(Script3_DataServicesGetOrder)}.cs");
            var mockClient = new Mock<DataServicesClient>();

            mockClient
                .Setup(x => x.GetOrderAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new Order());

            await ScriptHelper.RunAsync(scriptText, mockClient.Object, new WorkflowContext());

            mockClient
                .Verify(x => x.GetOrderAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()));
        }
    }
}