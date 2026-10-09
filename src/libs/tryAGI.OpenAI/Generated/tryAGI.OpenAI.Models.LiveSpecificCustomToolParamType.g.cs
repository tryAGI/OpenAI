
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `custom`.<br/>
    /// Default Value: custom
    /// </summary>
    public enum LiveSpecificCustomToolParamType
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSpecificCustomToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSpecificCustomToolParamType value)
        {
            return value switch
            {
                LiveSpecificCustomToolParamType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSpecificCustomToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => LiveSpecificCustomToolParamType.Custom,
                _ => null,
            };
        }
    }
}