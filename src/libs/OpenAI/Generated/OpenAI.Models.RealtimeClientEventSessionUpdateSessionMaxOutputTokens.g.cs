
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeClientEventSessionUpdateSessionMaxOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventSessionUpdateSessionMaxOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventSessionUpdateSessionMaxOutputTokens value)
        {
            return value switch
            {
                RealtimeClientEventSessionUpdateSessionMaxOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventSessionUpdateSessionMaxOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeClientEventSessionUpdateSessionMaxOutputTokens.Inf,
                _ => null,
            };
        }
    }
}