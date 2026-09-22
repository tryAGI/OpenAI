
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `environment_connection`.<br/>
    /// Default Value: environment_connection
    /// </summary>
    public enum SessionRequiredActionResourceEnvironmentConnectionType
    {
        /// <summary>
        ///
        /// </summary>
        EnvironmentConnection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionRequiredActionResourceEnvironmentConnectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionRequiredActionResourceEnvironmentConnectionType value)
        {
            return value switch
            {
                SessionRequiredActionResourceEnvironmentConnectionType.EnvironmentConnection => "environment_connection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionRequiredActionResourceEnvironmentConnectionType? ToEnum(string value)
        {
            return value switch
            {
                "environment_connection" => SessionRequiredActionResourceEnvironmentConnectionType.EnvironmentConnection,
                _ => null,
            };
        }
    }
}