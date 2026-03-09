
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceConsentDeletedResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        AudioVoiceConsent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceConsentDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceConsentDeletedResourceObject value)
        {
            return value switch
            {
                VoiceConsentDeletedResourceObject.AudioVoiceConsent => "audio.voice_consent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceConsentDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "audio.voice_consent" => VoiceConsentDeletedResourceObject.AudioVoiceConsent,
                _ => null,
            };
        }
    }
}