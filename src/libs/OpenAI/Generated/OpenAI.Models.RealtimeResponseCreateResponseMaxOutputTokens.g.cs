
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeResponseCreateResponseMaxOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseCreateResponseMaxOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateResponseMaxOutputTokens value)
        {
            return value switch
            {
                RealtimeResponseCreateResponseMaxOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreateResponseMaxOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeResponseCreateResponseMaxOutputTokens.Inf,
                _ => null,
            };
        }
    }
}