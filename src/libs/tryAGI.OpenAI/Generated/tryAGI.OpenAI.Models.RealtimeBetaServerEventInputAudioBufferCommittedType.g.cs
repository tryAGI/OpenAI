
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.committed`.
    /// </summary>
    public enum RealtimeBetaServerEventInputAudioBufferCommittedType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCommitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventInputAudioBufferCommittedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventInputAudioBufferCommittedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventInputAudioBufferCommittedType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventInputAudioBufferCommittedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.committed" => RealtimeBetaServerEventInputAudioBufferCommittedType.InputAudioBufferCommitted,
                _ => null,
            };
        }
    }
}