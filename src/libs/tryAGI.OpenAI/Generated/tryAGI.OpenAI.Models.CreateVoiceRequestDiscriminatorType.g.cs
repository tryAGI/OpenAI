
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateVoiceRequestDiscriminatorType
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
    public static class CreateVoiceRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoiceRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateVoiceRequestDiscriminatorType.AudioSample => "audio_sample",
                CreateVoiceRequestDiscriminatorType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoiceRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_sample" => CreateVoiceRequestDiscriminatorType.AudioSample,
                "prompt" => CreateVoiceRequestDiscriminatorType.Prompt,
                _ => null,
            };
        }
    }
}