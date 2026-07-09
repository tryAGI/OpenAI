
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum BetaAutoCodeInterpreterToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAutoCodeInterpreterToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAutoCodeInterpreterToolParamType value)
        {
            return value switch
            {
                BetaAutoCodeInterpreterToolParamType.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAutoCodeInterpreterToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaAutoCodeInterpreterToolParamType.Auto,
                _ => null,
            };
        }
    }
}