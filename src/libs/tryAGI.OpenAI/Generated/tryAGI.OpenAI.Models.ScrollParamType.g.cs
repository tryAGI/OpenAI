
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a scroll action, this property is always set to `scroll`.<br/>
    /// Default Value: scroll
    /// </summary>
    public enum ScrollParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Scroll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrollParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrollParamType value)
        {
            return value switch
            {
                ScrollParamType.Scroll => "scroll",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrollParamType? ToEnum(string value)
        {
            return value switch
            {
                "scroll" => ScrollParamType.Scroll,
                _ => null,
            };
        }
    }
}