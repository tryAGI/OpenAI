
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// For custom tool calling, the type is always `custom`.
    /// </summary>
    public enum BetaToolChoiceCustomType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolChoiceCustomTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolChoiceCustomType value)
        {
            return value switch
            {
                BetaToolChoiceCustomType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolChoiceCustomType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => BetaToolChoiceCustomType.Custom,
                _ => null,
            };
        }
    }
}