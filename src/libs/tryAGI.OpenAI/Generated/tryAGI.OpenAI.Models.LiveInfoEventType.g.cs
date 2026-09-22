
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `info`.<br/>
    /// Default Value: info
    /// </summary>
    public enum LiveInfoEventType
    {
        /// <summary>
        ///
        /// </summary>
        Info,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInfoEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInfoEventType value)
        {
            return value switch
            {
                LiveInfoEventType.Info => "info",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInfoEventType? ToEnum(string value)
        {
            return value switch
            {
                "info" => LiveInfoEventType.Info,
                _ => null,
            };
        }
    }
}