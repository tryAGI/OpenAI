
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `configuration_update`.<br/>
    /// Default Value: configuration_update
    /// </summary>
    public enum BetaResponseConfigurationUpdateItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        ConfigurationUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseConfigurationUpdateItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseConfigurationUpdateItemParamType value)
        {
            return value switch
            {
                BetaResponseConfigurationUpdateItemParamType.ConfigurationUpdate => "configuration_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseConfigurationUpdateItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "configuration_update" => BetaResponseConfigurationUpdateItemParamType.ConfigurationUpdate,
                _ => null,
            };
        }
    }
}