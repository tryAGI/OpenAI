
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpeechResponseStreamEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechAudioDelta,
        /// <summary>
        /// 
        /// </summary>
        SpeechAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechResponseStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechResponseStreamEventDiscriminatorType value)
        {
            return value switch
            {
                CreateSpeechResponseStreamEventDiscriminatorType.SpeechAudioDelta => "speech.audio.delta",
                CreateSpeechResponseStreamEventDiscriminatorType.SpeechAudioDone => "speech.audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechResponseStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "speech.audio.delta" => CreateSpeechResponseStreamEventDiscriminatorType.SpeechAudioDelta,
                "speech.audio.done" => CreateSpeechResponseStreamEventDiscriminatorType.SpeechAudioDone,
                _ => null,
            };
        }
    }
}