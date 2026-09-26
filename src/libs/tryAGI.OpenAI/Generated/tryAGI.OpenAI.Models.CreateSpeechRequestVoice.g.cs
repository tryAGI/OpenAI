
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSpeechRequestVoice
    {
        /// <summary>
        ///
        /// </summary>
        Fable,
        /// <summary>
        ///
        /// </summary>
        Nova,
        /// <summary>
        ///
        /// </summary>
        Onyx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechRequestVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestVoice value)
        {
            return value switch
            {
                CreateSpeechRequestVoice.Fable => "fable",
                CreateSpeechRequestVoice.Nova => "nova",
                CreateSpeechRequestVoice.Onyx => "onyx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechRequestVoice? ToEnum(string value)
        {
            return value switch
            {
                "fable" => CreateSpeechRequestVoice.Fable,
                "nova" => CreateSpeechRequestVoice.Nova,
                "onyx" => CreateSpeechRequestVoice.Onyx,
                _ => null,
            };
        }
    }
}