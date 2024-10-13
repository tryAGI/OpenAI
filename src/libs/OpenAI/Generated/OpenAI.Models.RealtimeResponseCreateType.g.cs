
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be 'response.create'.
    /// </summary>
    public enum RealtimeResponseCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateType value)
        {
            return value switch
            {
                RealtimeResponseCreateType.ResponseCreate => "response.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreateType? ToEnum(string value)
        {
            return value switch
            {
                "response.create" => RealtimeResponseCreateType.ResponseCreate,
                _ => null,
            };
        }
    }
}