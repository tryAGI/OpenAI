
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `audio.voice`.
    /// </summary>
    public enum VoiceResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        AudioVoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResourceObject value)
        {
            return value switch
            {
                VoiceResourceObject.AudioVoice => "audio.voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "audio.voice" => VoiceResourceObject.AudioVoice,
                _ => null,
            };
        }
    }
}