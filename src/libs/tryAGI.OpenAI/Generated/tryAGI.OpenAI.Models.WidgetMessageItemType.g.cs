
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `chatkit.widget`.<br/>
    /// Default Value: chatkit.widget
    /// </summary>
    public enum WidgetMessageItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitWidget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WidgetMessageItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetMessageItemType value)
        {
            return value switch
            {
                WidgetMessageItemType.ChatkitWidget => "chatkit.widget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetMessageItemType? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.widget" => WidgetMessageItemType.ChatkitWidget,
                _ => null,
            };
        }
    }
}