
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a scroll action, this property is always set to `scroll`.<br/>
    /// Default Value: scroll
    /// </summary>
    public enum BetaScrollParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Scroll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaScrollParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaScrollParamType value)
        {
            return value switch
            {
                BetaScrollParamType.Scroll => "scroll",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaScrollParamType? ToEnum(string value)
        {
            return value switch
            {
                "scroll" => BetaScrollParamType.Scroll,
                _ => null,
            };
        }
    }
}