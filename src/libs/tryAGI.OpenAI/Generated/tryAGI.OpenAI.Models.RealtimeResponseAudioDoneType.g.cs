
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be "response.audio.done".<br/>
    /// Example: response.audio.done
    /// </summary>
    public enum RealtimeResponseAudioDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseAudioDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseAudioDoneType value)
        {
            return value switch
            {
                RealtimeResponseAudioDoneType.ResponseAudioDone => "response.audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseAudioDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.done" => RealtimeResponseAudioDoneType.ResponseAudioDone,
                _ => null,
            };
        }
    }
}