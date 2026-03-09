
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a click action, this property is always `click`.<br/>
    /// Default Value: click
    /// </summary>
    public enum ClickParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Click,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClickParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClickParamType value)
        {
            return value switch
            {
                ClickParamType.Click => "click",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClickParamType? ToEnum(string value)
        {
            return value switch
            {
                "click" => ClickParamType.Click,
                _ => null,
            };
        }
    }
}