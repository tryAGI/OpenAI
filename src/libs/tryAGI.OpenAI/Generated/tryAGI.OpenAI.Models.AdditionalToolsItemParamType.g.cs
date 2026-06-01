
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `additional_tools`.<br/>
    /// Default Value: additional_tools
    /// </summary>
    public enum AdditionalToolsItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        AdditionalTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdditionalToolsItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdditionalToolsItemParamType value)
        {
            return value switch
            {
                AdditionalToolsItemParamType.AdditionalTools => "additional_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdditionalToolsItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => AdditionalToolsItemParamType.AdditionalTools,
                _ => null,
            };
        }
    }
}