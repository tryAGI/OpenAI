
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "response.created".<br/>
    /// Example: response.created
    /// </summary>
    public enum RealtimeResponseCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreatedType value)
        {
            return value switch
            {
                RealtimeResponseCreatedType.ResponseCreated => "response.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "response.created" => RealtimeResponseCreatedType.ResponseCreated,
                _ => null,
            };
        }
    }
}