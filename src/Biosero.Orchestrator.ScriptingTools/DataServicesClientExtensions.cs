#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace Biosero.DataServices.Client
{
    /// <summary>
    /// Extensions for the Data Services Client contract.
    /// </summary>
    public static class DataServicesClientExtensions
    {
        public static async Task<Identity> GetIdentityOrNullAsync(this DataServicesClient client, string identifier, CancellationToken cancellationToken = default)
        {
            try
            {
                return await client.GetIdentityAsync(identifier, cancellationToken).ConfigureAwait(false);
            }
            catch (DataServicesException ex)
                when (ex.StatusCode == 404)
            {
                return null;
            }
        }

        public static async Task<OrderTemplate> GetOrderTemplateOrNullAsync(this DataServicesClient client, string name, CancellationToken cancellationToken = default)
        {
            try
            {
                return await client.GetOrderTemplateAsync(name, cancellationToken).ConfigureAwait(false);
            }
            catch (DataServicesException ex)
                when (ex.StatusCode == 404)
            {
                return null;
            }
        }

        public static async Task<WorkflowThread> GetNextWorkflowThreadOrNullAsync(this DataServicesClient client, CancellationToken cancellationToken = default)
        {
            var stackElements = await client.GetNextWorkflowThreadAsync(cancellationToken).ConfigureAwait(false);

            return stackElements.SingleOrDefault();
        }

        public static async Task<WorkflowStackElement> PeekWorkflowStackOrNullAsync(this DataServicesClient client, int workflowThreadId, CancellationToken cancellationToken = default)
        {
            var stackElements = await client.PeekWorkflowStackAsync(workflowThreadId, cancellationToken).ConfigureAwait(false);

            return stackElements.SingleOrDefault();
        }

        public static async Task<TransportationRequest> GetNextTransportationRequestOrNullAsync(this DataServicesClient client, CancellationToken cancellationToken = default)
        {
            var requests = await client.GetNextTransportationRequestAsync(cancellationToken).ConfigureAwait(false);

            return requests.SingleOrDefault();
        }

        public static async Task<TransportationRequest> PeekNextTransportationRequestOrNullAsync(this DataServicesClient client, CancellationToken cancellationToken = default)
        {
            var requests = await client.PeekNextTransportationRequestAsync(cancellationToken).ConfigureAwait(false);

            return requests.SingleOrDefault();
        }

        public static async Task<MobileRobotTransport> GetMobileRobotTransportOrNullAsync(this DataServicesClient client, string mobileRobotIdentifier, CancellationToken cancellationToken = default)
        {
            try
            {
                return await client.GetMobileRobotTransportAsync(mobileRobotIdentifier, cancellationToken).ConfigureAwait(false);
            }
            catch (DataServicesException ex)
                when (ex.StatusCode == 404)
            {
                return null;
            }
        }

        public static async Task<MobileRobotTransport> GetNextMobileRobotTransportOrNullAsync(this DataServicesClient client, CancellationToken cancellationToken = default)
        {
            var requests = await client.GetNextMobileRobotTransportAsync(cancellationToken).ConfigureAwait(false);

            return requests.SingleOrDefault();
        }

        public static async Task<MobileRobotTransport> PeekNextMobileRobotTransportOrNullAsync(this DataServicesClient client, CancellationToken cancellationToken = default)
        {
            var requests = await client.PeekNextMobileRobotTransportAsync(cancellationToken).ConfigureAwait(false);

            return requests.SingleOrDefault();
        }

        /// <summary>
        /// Gets the value of a specific parameter.
        /// </summary>
        /// <typeparam name="T">The parameter type.</typeparam>
        /// <param name="source">The parameter collection.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <returns>T.</returns>
        /// <exception cref="ArgumentException">Could not find parameter named {parameterName}.</exception>
        /// <exception cref="InvalidOperationException">Invalid type.</exception>
        public static T GetValue<T>(this ICollection<Parameter> source, string parameterName)
        {
            var parameter = source.FirstOrDefault(p => p.Name == parameterName);

            if (parameter == null)
            {
                throw new ArgumentException($"Could not find parameter named {parameterName}.");
            }

            if (typeof(T) == typeof(string))
            {
                return (T)Convert.ChangeType(parameter.Value, typeof(T));
            }

            if (typeof(T) == typeof(int))
            {
                return (T)(object)int.Parse(parameter.Value);
            }

            if (typeof(T) == typeof(double))
            {
                return (T)(object)double.Parse(parameter.Value);
            }

            if (typeof(T) == typeof(bool))
            {
                return (T)(object)bool.Parse(parameter.Value);
            }

            throw new InvalidOperationException("Invalid type.");
        }

        /// <summary>
        /// Gets the value if exists, otherwise returns the specified default value.
        /// </summary>
        /// <typeparam name="T">The value type.</typeparam>
        /// <param name="source">The parameter collection.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>T. The value if exists, otherwise returns the specified default value.</returns>
        /// <exception cref="System.InvalidOperationException">Invalid Type.</exception>
        public static T GetOrDefaultValue<T>(this ICollection<Parameter> source, string parameterName, T defaultValue)
        {
            var parameter = source.FirstOrDefault(p => p.Name == parameterName);

            if (parameter == null)
            {
                return defaultValue;
            }

            if (typeof(T) == typeof(string))
            {
                return (T)Convert.ChangeType(parameter.Value, typeof(T));
            }
            else if (typeof(T) == typeof(int))
            {
                return (T)(object)int.Parse(parameter.Value);
            }
            else if (typeof(T) == typeof(double))
            {
                return (T)(object)double.Parse(parameter.Value);
            }
            else if (typeof(T) == typeof(bool))
            {
                return (T)(object)bool.Parse(parameter.Value);
            }

            throw new InvalidOperationException("Invalid Type");
        }

        /// <summary>
        /// Gets the value if exists, otherwise returns the default value.
        /// </summary>
        /// <typeparam name="T">The value type.</typeparam>
        /// <param name="source">The parameter collection.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <returns>T. The value if exists, otherwise returns the default value.</returns>
        /// <exception cref="System.InvalidOperationException">Invalid Type.</exception>
        public static T GetOrDefaultValue<T>(this ICollection<Parameter> source, string parameterName)
        {
            return source.GetOrDefaultValue(parameterName, default(T));
        }
    }
}

#pragma warning restore CS1591