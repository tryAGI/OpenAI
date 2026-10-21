
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `audio.voice.deleted`.
    /// </summary>
    public enum VoiceDeletedResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AudioVoiceDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceDeletedResourceObject value)
        {
            return value switch
            {
                VoiceDeletedResourceObject.AudioVoiceDeleted => "audio.voice.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "audio.voice.deleted" => VoiceDeletedResourceObject.AudioVoiceDeleted,
                _ => null,
            };
        }
    }
}