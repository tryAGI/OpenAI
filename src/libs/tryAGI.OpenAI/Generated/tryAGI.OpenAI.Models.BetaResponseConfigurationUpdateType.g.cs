
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `configuration_update`.<br/>
    /// Default Value: configuration_update
    /// </summary>
    public enum BetaResponseConfigurationUpdateType
    {
        /// <summary>
        ///
        /// </summary>
        ConfigurationUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseConfigurationUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseConfigurationUpdateType value)
        {
            return value switch
            {
                BetaResponseConfigurationUpdateType.ConfigurationUpdate => "configuration_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseConfigurationUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "configuration_update" => BetaResponseConfigurationUpdateType.ConfigurationUpdate,
                _ => null,
            };
        }
    }
}