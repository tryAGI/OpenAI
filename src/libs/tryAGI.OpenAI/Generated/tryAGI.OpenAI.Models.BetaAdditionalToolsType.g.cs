
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `additional_tools`.<br/>
    /// Default Value: additional_tools
    /// </summary>
    public enum BetaAdditionalToolsType
    {
        /// <summary>
        ///
        /// </summary>
        AdditionalTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAdditionalToolsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAdditionalToolsType value)
        {
            return value switch
            {
                BetaAdditionalToolsType.AdditionalTools => "additional_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAdditionalToolsType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => BetaAdditionalToolsType.AdditionalTools,
                _ => null,
            };
        }
    }
}