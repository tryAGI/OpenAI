
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the refusal. Always `refusal`.<br/>
    /// Default Value: refusal
    /// </summary>
    public enum BetaRefusalContentType
    {
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRefusalContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRefusalContentType value)
        {
            return value switch
            {
                BetaRefusalContentType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRefusalContentType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => BetaRefusalContentType.Refusal,
                _ => null,
            };
        }
    }
}