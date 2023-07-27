namespace Biosero.DataServices.Client
{
    /// <summary>
    /// Extensions for the Data Services Client contract.
    /// </summary>
    public static class DataServicesClientExtensions
    {
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
