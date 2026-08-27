
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the custom tool. Always `custom`.<br/>
    /// Default Value: custom
    /// </summary>
    public enum BetaCustomToolParamType
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCustomToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCustomToolParamType value)
        {
            return value switch
            {
                BetaCustomToolParamType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCustomToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => BetaCustomToolParamType.Custom,
                _ => null,
            };
        }
    }
}