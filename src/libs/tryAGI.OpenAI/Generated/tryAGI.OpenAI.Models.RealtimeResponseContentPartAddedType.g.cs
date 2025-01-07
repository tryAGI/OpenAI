
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be "response.content_part.added".<br/>
    /// Example: response.content_part.added
    /// </summary>
    public enum RealtimeResponseContentPartAddedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseContentPartAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseContentPartAddedType value)
        {
            return value switch
            {
                RealtimeResponseContentPartAddedType.ResponseContentPartAdded => "response.content_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseContentPartAddedType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.added" => RealtimeResponseContentPartAddedType.ResponseContentPartAdded,
                _ => null,
            };
        }
    }
}