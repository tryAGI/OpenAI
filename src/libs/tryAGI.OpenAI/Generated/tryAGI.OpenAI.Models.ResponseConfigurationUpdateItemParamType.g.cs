
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `configuration_update`.<br/>
    /// Default Value: configuration_update
    /// </summary>
    public enum ResponseConfigurationUpdateItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        ConfigurationUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseConfigurationUpdateItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseConfigurationUpdateItemParamType value)
        {
            return value switch
            {
                ResponseConfigurationUpdateItemParamType.ConfigurationUpdate => "configuration_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseConfigurationUpdateItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "configuration_update" => ResponseConfigurationUpdateItemParamType.ConfigurationUpdate,
                _ => null,
            };
        }
    }
}