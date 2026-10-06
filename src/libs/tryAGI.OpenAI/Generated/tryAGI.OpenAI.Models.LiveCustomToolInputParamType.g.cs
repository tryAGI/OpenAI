
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: custom
    /// </summary>
    public enum LiveCustomToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveCustomToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveCustomToolInputParamType value)
        {
            return value switch
            {
                LiveCustomToolInputParamType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveCustomToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => LiveCustomToolInputParamType.Custom,
                _ => null,
            };
        }
    }
}