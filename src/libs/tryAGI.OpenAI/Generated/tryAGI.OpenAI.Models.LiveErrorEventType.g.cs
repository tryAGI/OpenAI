
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `error`.<br/>
    /// Default Value: error
    /// </summary>
    public enum LiveErrorEventType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveErrorEventType value)
        {
            return value switch
            {
                LiveErrorEventType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "error" => LiveErrorEventType.Error,
                _ => null,
            };
        }
    }
}