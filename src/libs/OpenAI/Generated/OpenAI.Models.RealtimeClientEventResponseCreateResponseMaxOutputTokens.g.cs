
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeClientEventResponseCreateResponseMaxOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventResponseCreateResponseMaxOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventResponseCreateResponseMaxOutputTokens value)
        {
            return value switch
            {
                RealtimeClientEventResponseCreateResponseMaxOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventResponseCreateResponseMaxOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeClientEventResponseCreateResponseMaxOutputTokens.Inf,
                _ => null,
            };
        }
    }
}