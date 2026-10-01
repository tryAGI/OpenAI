
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The voice creation method. Defaults to `audio_sample` when omitted.<br/>
    /// Default Value: audio_sample
    /// </summary>
    public enum CreateVoiceFromConsentRequestType
    {
        /// <summary>
        ///
        /// </summary>
        AudioSample,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVoiceFromConsentRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoiceFromConsentRequestType value)
        {
            return value switch
            {
                CreateVoiceFromConsentRequestType.AudioSample => "audio_sample",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoiceFromConsentRequestType? ToEnum(string value)
        {
            return value switch
            {
                "audio_sample" => CreateVoiceFromConsentRequestType.AudioSample,
                _ => null,
            };
        }
    }
}