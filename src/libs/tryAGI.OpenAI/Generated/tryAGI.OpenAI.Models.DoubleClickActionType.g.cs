
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the event type. For a double click action, this property is always set to `double_click`.<br/>
    /// Default Value: double_click
    /// </summary>
    public enum DoubleClickActionType
    {
        /// <summary>
        /// 
        /// </summary>
        DoubleClick,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DoubleClickActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DoubleClickActionType value)
        {
            return value switch
            {
                DoubleClickActionType.DoubleClick => "double_click",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DoubleClickActionType? ToEnum(string value)
        {
            return value switch
            {
                "double_click" => DoubleClickActionType.DoubleClick,
                _ => null,
            };
        }
    }
}