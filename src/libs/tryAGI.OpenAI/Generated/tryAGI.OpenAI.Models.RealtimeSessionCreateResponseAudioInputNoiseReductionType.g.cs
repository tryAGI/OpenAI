
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateResponseAudioInputNoiseReductionType
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
    public static class RealtimeSessionCreateResponseAudioInputNoiseReductionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseAudioInputNoiseReductionType value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseAudioInputNoiseReductionType.NearField => "near_field",
                RealtimeSessionCreateResponseAudioInputNoiseReductionType.FarField => "far_field",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseAudioInputNoiseReductionType? ToEnum(string value)
        {
            return value switch
            {
                "near_field" => RealtimeSessionCreateResponseAudioInputNoiseReductionType.NearField,
                "far_field" => RealtimeSessionCreateResponseAudioInputNoiseReductionType.FarField,
                _ => null,
            };
        }
    }
}