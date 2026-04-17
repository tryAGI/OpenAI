
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.dtmf_event_received`.
    /// </summary>
    public enum RealtimeServerEventInputAudioBufferDtmfEventReceivedType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferDtmfEventReceived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventInputAudioBufferDtmfEventReceivedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventInputAudioBufferDtmfEventReceivedType value)
        {
            return value switch
            {
                RealtimeServerEventInputAudioBufferDtmfEventReceivedType.InputAudioBufferDtmfEventReceived => "input_audio_buffer.dtmf_event_received",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventInputAudioBufferDtmfEventReceivedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.dtmf_event_received" => RealtimeServerEventInputAudioBufferDtmfEventReceivedType.InputAudioBufferDtmfEventReceived,
                _ => null,
            };
        }
    }
}