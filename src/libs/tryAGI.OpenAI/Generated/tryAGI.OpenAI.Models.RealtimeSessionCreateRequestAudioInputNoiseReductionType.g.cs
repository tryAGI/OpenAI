
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
    /// </summary>
    public enum RealtimeSessionCreateRequestAudioInputNoiseReductionType
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
    public static class RealtimeSessionCreateRequestAudioInputNoiseReductionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestAudioInputNoiseReductionType value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestAudioInputNoiseReductionType.NearField => "near_field",
                RealtimeSessionCreateRequestAudioInputNoiseReductionType.FarField => "far_field",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestAudioInputNoiseReductionType? ToEnum(string value)
        {
            return value switch
            {
                "near_field" => RealtimeSessionCreateRequestAudioInputNoiseReductionType.NearField,
                "far_field" => RealtimeSessionCreateRequestAudioInputNoiseReductionType.FarField,
                _ => null,
            };
        }
    }
}