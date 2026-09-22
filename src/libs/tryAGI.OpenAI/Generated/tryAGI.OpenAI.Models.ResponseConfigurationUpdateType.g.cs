
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `configuration_update`.<br/>
    /// Default Value: configuration_update
    /// </summary>
    public enum ResponseConfigurationUpdateType
    {
        /// <summary>
        ///
        /// </summary>
        ConfigurationUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseConfigurationUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseConfigurationUpdateType value)
        {
            return value switch
            {
                ResponseConfigurationUpdateType.ConfigurationUpdate => "configuration_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseConfigurationUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "configuration_update" => ResponseConfigurationUpdateType.ConfigurationUpdate,
                _ => null,
            };
        }
    }
}