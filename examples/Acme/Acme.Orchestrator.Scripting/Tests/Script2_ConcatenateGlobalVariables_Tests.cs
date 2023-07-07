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
    public class Script2_ConcatenateGlobalVariables_Tests
    {
        [TestMethod]
        public async Task Execute_Directly()
        {
            var script = new Script2_ConcatenateGlobalVariables();
            var client = new Mock<DataServicesClient>().Object;
            var context = new WorkflowContext(
                new Parameter
                {
                    Name = "StringVariableName",
                    ValueType = ParameterValueType.String,
                    Value = "A string value"
                },
                new Parameter
                {
                    Name = "IntegerVariableName",
                    ValueType = ParameterValueType.Integer,
                    Value = "1"
                },
                new Parameter
                {
                    Name = "DoubleVariableName",
                    ValueType = ParameterValueType.Double,
                    Value = "0.5"
                },
                new Parameter
                {
                    Name = "BooleanVariableName",
                    ValueType = ParameterValueType.Boolean,
                    Value = "true"
                });

            var stringVariable = context.GetGlobalVariableValue<string>("StringVariableName");
            var integerVariable = context.GetGlobalVariableValue<int>("IntegerVariableName");
            var doubleVariable = context.GetGlobalVariableValue<double>("DoubleVariableName");
            var booleanVariable = context.GetGlobalVariableValue<bool>("BooleanVariableName");

            await script.RunAsync(client, context, CancellationToken.None);

            Assert.AreEqual($"{stringVariable} {stringVariable}", context.GetGlobalVariableValue<string>("StringVariableName"));
            Assert.AreEqual(integerVariable + integerVariable, context.GetGlobalVariableValue<int>("IntegerVariableName"));
            Assert.AreEqual(doubleVariable + doubleVariable, context.GetGlobalVariableValue<double>("DoubleVariableName"));
            Assert.AreEqual(booleanVariable && booleanVariable, context.GetGlobalVariableValue<bool>("BooleanVariableName"));
        }

        [TestMethod]
        public void Compile_As_Script()
        {
            var scriptText = File.ReadAllText($"{nameof(Script2_ConcatenateGlobalVariables)}.cs");

            ScriptHelper.Compile(scriptText);
        }

        [TestMethod]
        public async Task Execute_As_Script()
        {
            var scriptText = File.ReadAllText($"{nameof(Script2_ConcatenateGlobalVariables)}.cs");
            var client = new Mock<DataServicesClient>().Object;
            var context = new WorkflowContext(
                new Parameter
                {
                    Name = "StringVariableName",
                    ValueType = ParameterValueType.String,
                    Value = "A string value"
                },
                new Parameter
                {
                    Name = "IntegerVariableName",
                    ValueType = ParameterValueType.Integer,
                    Value = "1"
                },
                new Parameter
                {
                    Name = "DoubleVariableName",
                    ValueType = ParameterValueType.Double,
                    Value = "0.5"
                },
                new Parameter
                {
                    Name = "BooleanVariableName",
                    ValueType = ParameterValueType.Boolean,
                    Value = "true"
                });

            var stringVariable = context.GetGlobalVariableValue<string>("StringVariableName");
            var integerVariable = context.GetGlobalVariableValue<int>("IntegerVariableName");
            var doubleVariable = context.GetGlobalVariableValue<double>("DoubleVariableName");
            var booleanVariable = context.GetGlobalVariableValue<bool>("BooleanVariableName");

            await ScriptHelper.RunAsync(scriptText, client, context);

            Assert.AreEqual($"{stringVariable} {stringVariable}", context.GetGlobalVariableValue<string>("StringVariableName"));
            Assert.AreEqual(integerVariable + integerVariable, context.GetGlobalVariableValue<int>("IntegerVariableName"));
            Assert.AreEqual(doubleVariable + doubleVariable, context.GetGlobalVariableValue<double>("DoubleVariableName"));
            Assert.AreEqual(booleanVariable && booleanVariable, context.GetGlobalVariableValue<bool>("BooleanVariableName"));
        }
    }
}