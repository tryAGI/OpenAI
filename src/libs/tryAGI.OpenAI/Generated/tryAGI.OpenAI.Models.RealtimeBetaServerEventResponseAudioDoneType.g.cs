
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.output_audio.done`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseAudioDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseAudioDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseAudioDoneType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseAudioDoneType.ResponseOutputAudioDone => "response.output_audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseAudioDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio.done" => RealtimeBetaServerEventResponseAudioDoneType.ResponseOutputAudioDone,
                _ => null,
            };
        }
    }
}