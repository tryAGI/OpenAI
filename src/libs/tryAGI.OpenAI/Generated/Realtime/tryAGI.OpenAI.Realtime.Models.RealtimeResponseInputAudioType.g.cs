
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputAudioType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputAudioType value)
        {
            return value switch
            {
                RealtimeResponseInputAudioType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputAudioType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => RealtimeResponseInputAudioType.InputAudio,
                _ => null,
            };
        }
    }
}