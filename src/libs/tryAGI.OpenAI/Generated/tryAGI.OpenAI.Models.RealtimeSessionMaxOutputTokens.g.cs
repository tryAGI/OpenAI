
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionMaxOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionMaxOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionMaxOutputTokens value)
        {
            return value switch
            {
                RealtimeSessionMaxOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionMaxOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeSessionMaxOutputTokens.Inf,
                _ => null,
            };
        }
    }
}