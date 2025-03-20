using Biosero.DataServices.Client;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Biosero.Orchestrator.WorkflowService
{
    /// <summary>
    /// The Workflow context that manages global variables.
    /// </summary>
    public class WorkflowContext
    {
        private static readonly HttpMessageHandler _httpMessageHandler = new HttpClientHandler();

        private readonly List<Parameter> _globalVariables;
        private readonly ILoggerFactory _loggerFactory;

        /// <summary>
        /// Constructs a Workflow Context.
        /// </summary>
        /// <param name="globalVariables">The global varables with their initial values.</param>
        public WorkflowContext(params Parameter[] globalVariables)
        {
            _globalVariables = (globalVariables ?? Array.Empty<Parameter>()).ToList();
            _loggerFactory = new NullLoggerFactory();
        }

        /// <summary>
        /// Constructs a Workflow Context.
        /// </summary>
        /// <param name="globalVariables">The global varables with their initial values.</param>
        /// <param name="loggerFactory">The logger factory to use to record logs.</param>
        public WorkflowContext(Parameter[] globalVariables, ILoggerFactory loggerFactory)
        {
            _globalVariables = (globalVariables ?? Array.Empty<Parameter>()).ToList();
            _loggerFactory = loggerFactory ?? new NullLoggerFactory();
        }

        /// <summary>
        /// The Order Identifier for the currently running Workflow.
        /// </summary>
        public string OrderIdentifier => "Order_00000";

        /// <summary>
        /// Create a HttpClient without needing to worry about managing its HttpMessageHandler.
        /// Feel free to dispose of the HttpClient immediately after use.
        /// Primarily should be used for creating a HttpClient from a custom workflow script.
        /// </summary>
        public HttpClient CreateHttpClient()
        {
            return new HttpClient(_httpMessageHandler, false);
        }

        /// <summary>
        /// Create a logger where the category name is derived from the specified TCategoryName type name.
        /// Primarily should be used for creating a logger from a custom workflow script.
        /// </summary>
        /// <typeparam name="TCategoryName">The type whose name is used for the logger category name.</typeparam>
        public ILogger<TCategoryName> CreateLogger<TCategoryName>()
        {
            return _loggerFactory.CreateLogger<TCategoryName>();
        }

        /// <summary>
        /// Gets a global variables value type by its variable name.
        /// </summary>
        /// <param name="name">The global variable name.</param>
        public ParameterValueType GetGlobalVariableValueType(string name)
        {
            return _globalVariables
                .Where(x => x.Name == name)
                .Select(x => x.ValueType)
                .Single();
        }

        /// <summary>
        /// Gets a global variable value by variable name.
        /// </summary>
        /// <typeparam name="T">The global variable value type.</typeparam>
        /// <param name="name">The global variable name.</param>
        /// <exception cref="InvalidOperationException"></exception>
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

        /// <summary>
        /// Tries to get a global variable value by variable name.
        /// </summary>
        /// <typeparam name="T">The global variable value type.</typeparam>
        /// <param name="name">The global variable name.</param>
        /// <param name="value">The global variable value.</param>
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

        /// <summary>
        /// Adds or updates a global variable value by variable name.
        /// </summary>
        /// <typeparam name="T">The global variable value type.</typeparam>
        /// <param name="name">The global variable name.</param>
        /// <param name="value">The global variable value.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <exception cref="InvalidOperationException"></exception>
        public Task AddOrUpdateGlobalVariableAsync<T>(string name, T value, CancellationToken cancellationToken = default)
        {
            _ = value ?? throw new ArgumentNullException(nameof(value));

            var valueType = GetParameterValueType(typeof(T));

            return AddOrUpdateGlobalVariableAsync(name, valueType, value.ToString(), cancellationToken);
        }

        /// <summary>
        /// Adds or updates a global variable value by variable name.
        /// </summary>
        /// <param name="name">The global variable name.</param>
        /// <param name="valueType">The global variable value type.</param>
        /// <param name="value">The global variable value.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <exception cref="InvalidOperationException"></exception>
        public Task AddOrUpdateGlobalVariableAsync(string name, ParameterValueType valueType, string value, CancellationToken cancellationToken = default)
        {
            var variable = _globalVariables.SingleOrDefault(x => x.Name == name);

            if (variable == null)
            {
                variable = new Parameter
                {
                    Name = name,
                    ValueType = valueType,
                    Value = value,
                };

                _globalVariables.Add(variable);
            }
            else
            {
                if (valueType != variable.ValueType)
                {
                    throw new InvalidOperationException($"Global Variable Type '{variable.ValueType}' does not match value type '{valueType}'.");
                }

                variable.Value = value;
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Updates a global variable value by variable name.
        /// </summary>
        /// <typeparam name="T">The global variable value type.</typeparam>
        /// <param name="name">The global variable name.</param>
        /// <param name="value">The global variable value.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <exception cref="InvalidOperationException"></exception>
        public Task UpdateGlobalVariableAsync<T>(string name, T value, CancellationToken cancellationToken = default)
        {
            _ = value ?? throw new ArgumentNullException(nameof(value));

            var valueType = GetParameterValueType(typeof(T));

            return UpdateGlobalVariableAsync(name, valueType, value.ToString(), cancellationToken);
        }

        /// <summary>
        /// Updates a global variable value by variable name.
        /// </summary>
        /// <param name="name">The global variable name.</param>
        /// <param name="valueType">The global variable value type.</param>
        /// <param name="value">The global variable value.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <exception cref="InvalidOperationException"></exception>
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
