
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The voice the model uses to respond.
    /// </summary>
    public enum RealtimeResponseCreateResponseVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        Echo,
        /// <summary>
        /// 
        /// </summary>
        Shimmer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseCreateResponseVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateResponseVoice value)
        {
            return value switch
            {
                RealtimeResponseCreateResponseVoice.Alloy => "alloy",
                RealtimeResponseCreateResponseVoice.Echo => "echo",
                RealtimeResponseCreateResponseVoice.Shimmer => "shimmer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreateResponseVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => RealtimeResponseCreateResponseVoice.Alloy,
                "echo" => RealtimeResponseCreateResponseVoice.Echo,
                "shimmer" => RealtimeResponseCreateResponseVoice.Shimmer,
                _ => null,
            };
        }
    }
}