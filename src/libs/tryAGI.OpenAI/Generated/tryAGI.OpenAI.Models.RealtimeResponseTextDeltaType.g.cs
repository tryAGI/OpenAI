
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be "response.text.delta".<br/>
    /// Example: response.text.delta
    /// </summary>
    public enum RealtimeResponseTextDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseTextDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseTextDeltaType value)
        {
            return value switch
            {
                RealtimeResponseTextDeltaType.ResponseTextDelta => "response.text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseTextDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.text.delta" => RealtimeResponseTextDeltaType.ResponseTextDelta,
                _ => null,
            };
        }
    }
}