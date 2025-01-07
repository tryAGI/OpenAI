
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The voice the model uses to respond. Cannot be changed once the model has responded with audio at least once.<br/>
    /// Example: alloy
    /// </summary>
    public enum RealtimeSessionVoice
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
    public static class RealtimeSessionVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionVoice value)
        {
            return value switch
            {
                RealtimeSessionVoice.Alloy => "alloy",
                RealtimeSessionVoice.Echo => "echo",
                RealtimeSessionVoice.Shimmer => "shimmer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => RealtimeSessionVoice.Alloy,
                "echo" => RealtimeSessionVoice.Echo,
                "shimmer" => RealtimeSessionVoice.Shimmer,
                _ => null,
            };
        }
    }
}