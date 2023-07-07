using System.Diagnostics.CodeAnalysis;

using Biosero.DataServices.Client;

namespace Biosero.Orchestrator.WorkflowService
{
    public class WorkflowContext
    {
        private readonly Parameter[] _globalVariables;

        public WorkflowContext(params Parameter[] globalVariables)
        {
            _globalVariables = globalVariables;
        }

        public string OrderIdentifier => "Order_00000";

        public ParameterValueType GetGlobalVariableValueType(string name)
        {
            return _globalVariables
                .Where(x => x.Name == name)
                .Select(x => x.ValueType)
                .Single();
        }

        public T GetGlobalVariableValue<T>(string name)
        {
            var variable = _globalVariables.SingleOrDefault(x => x.Name == name);

            if (variable == null)
            {
                throw new InvalidOperationException($"Could not find Global Variable with Name '{name}'.");
            }

            switch (variable.ValueType)
            {
                case ParameterValueType.String:
                    return (T)(object)variable.Value;
                case ParameterValueType.Integer:
                    return (T)(object)int.Parse(variable.Value);
                case ParameterValueType.Double:
                    return (T)(object)double.Parse(variable.Value);
                case ParameterValueType.Boolean:
                    return (T)(object)bool.Parse(variable.Value);
                default:
                    throw new InvalidOperationException($"Invalid ValueType on Global Variable with Name '{name}'.");
            }
        }

        public bool TryGetGlobalVariableValue<T>(string name, out T value)
        {
            var parameter = _globalVariables.SingleOrDefault(x => x.Name == name);

            if (parameter == null)
            {
                value = default;
                return false;
            }

            value = GetGlobalVariableValue<T>(name) ?? throw new NullReferenceException($"{nameof(value)} should not be null.");

            return true;
        }

        public Task UpdateGlobalVariableAsync<T>(string name, T value, CancellationToken cancellationToken = default)
        {
            _ = value ?? throw new ArgumentNullException(nameof(value));

            var valueType = GetParameterValueType(typeof(T));

            return UpdateGlobalVariableAsync(name, valueType, value.ToString(), cancellationToken);
        }

        public Task UpdateGlobalVariableAsync(string name, ParameterValueType valueType, string value, CancellationToken cancellationToken = default)
        {
            var variable = _globalVariables.SingleOrDefault(x => x.Name == name);

            if (variable == null)
            {
                throw new InvalidOperationException($"Global Variable '{name}' does not exist.");
            }

            if (valueType != variable.ValueType)
            {
                throw new InvalidOperationException($"Global Variable Type '{variable.ValueType}' does not match value type '{valueType}'.");
            }

            variable.Value = value;

            var cmd = new UpdateWorkflowGlobalVariableValueCommand
            {
                Value = variable.Value,
            };

            return Task.CompletedTask;
        }

        private ParameterValueType GetParameterValueType(Type type)
        {
            if (type == typeof(string))
                return ParameterValueType.String;

            if (type == typeof(int))
                return ParameterValueType.Integer;

            if (type == typeof(double))
                return ParameterValueType.Double;

            if (type == typeof(bool))
                return ParameterValueType.Boolean;

            throw new InvalidOperationException($"Type '{type.Name}' is not translateable to ParameterValueType.");
        }
    }
}
