
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum VoiceResourceType
    {
        /// <summary>
        ///
        /// </summary>
        AudioSample,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResourceType value)
        {
            return value switch
            {
                VoiceResourceType.AudioSample => "audio_sample",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResourceType? ToEnum(string value)
        {
            return value switch
            {
                "audio_sample" => VoiceResourceType.AudioSample,
                _ => null,
            };
        }
    }
}