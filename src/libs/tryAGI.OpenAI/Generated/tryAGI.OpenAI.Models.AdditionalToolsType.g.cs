
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `additional_tools`.<br/>
    /// Default Value: additional_tools
    /// </summary>
    public enum AdditionalToolsType
    {
        /// <summary>
        /// 
        /// </summary>
        AdditionalTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdditionalToolsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdditionalToolsType value)
        {
            return value switch
            {
                AdditionalToolsType.AdditionalTools => "additional_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdditionalToolsType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => AdditionalToolsType.AdditionalTools,
                _ => null,
            };
        }
    }
}