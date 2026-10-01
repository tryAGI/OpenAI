
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// How the voice was created. Voices created from text prompts are supported only in Live.
    /// </summary>
    public enum VoiceResourceType
    {
        /// <summary>
        ///
        /// </summary>
        AudioSample,
        /// <summary>
        ///
        /// </summary>
        Prompt,
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
                VoiceResourceType.Prompt => "prompt",
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
                "prompt" => VoiceResourceType.Prompt,
                _ => null,
            };
        }
    }
}