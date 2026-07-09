
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a click action, this property is always `click`.<br/>
    /// Default Value: click
    /// </summary>
    public enum BetaClickParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Click,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClickParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClickParamType value)
        {
            return value switch
            {
                BetaClickParamType.Click => "click",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClickParamType? ToEnum(string value)
        {
            return value switch
            {
                "click" => BetaClickParamType.Click,
                _ => null,
            };
        }
    }
}