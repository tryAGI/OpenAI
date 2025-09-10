
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateResponseGAMaxOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateResponseGAMaxOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseGAMaxOutputTokens value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseGAMaxOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseGAMaxOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeSessionCreateResponseGAMaxOutputTokens.Inf,
                _ => null,
            };
        }
    }
}