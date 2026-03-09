
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `audio.voice_consent`.
    /// </summary>
    public enum VoiceConsentResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        AudioVoiceConsent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceConsentResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceConsentResourceObject value)
        {
            return value switch
            {
                VoiceConsentResourceObject.AudioVoiceConsent => "audio.voice_consent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceConsentResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "audio.voice_consent" => VoiceConsentResourceObject.AudioVoiceConsent,
                _ => null,
            };
        }
    }
}