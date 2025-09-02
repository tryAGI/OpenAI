
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateResponseAudioInputNoiseReductionType
    {
        /// <summary>
        /// 
        /// </summary>
        NearField,
        /// <summary>
        /// 
        /// </summary>
        FarField,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateResponseAudioInputNoiseReductionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateResponseAudioInputNoiseReductionType value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateResponseAudioInputNoiseReductionType.NearField => "near_field",
                RealtimeTranscriptionSessionCreateResponseAudioInputNoiseReductionType.FarField => "far_field",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateResponseAudioInputNoiseReductionType? ToEnum(string value)
        {
            return value switch
            {
                "near_field" => RealtimeTranscriptionSessionCreateResponseAudioInputNoiseReductionType.NearField,
                "far_field" => RealtimeTranscriptionSessionCreateResponseAudioInputNoiseReductionType.FarField,
                _ => null,
            };
        }
    }
}