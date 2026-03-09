
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpeechRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Tts1,
        /// <summary>
        /// 
        /// </summary>
        Tts1Hd,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniTts,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniTts20251215,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestModel value)
        {
            return value switch
            {
                CreateSpeechRequestModel.Tts1 => "tts-1",
                CreateSpeechRequestModel.Tts1Hd => "tts-1-hd",
                CreateSpeechRequestModel.Gpt4oMiniTts => "gpt-4o-mini-tts",
                CreateSpeechRequestModel.Gpt4oMiniTts20251215 => "gpt-4o-mini-tts-2025-12-15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "tts-1" => CreateSpeechRequestModel.Tts1,
                "tts-1-hd" => CreateSpeechRequestModel.Tts1Hd,
                "gpt-4o-mini-tts" => CreateSpeechRequestModel.Gpt4oMiniTts,
                "gpt-4o-mini-tts-2025-12-15" => CreateSpeechRequestModel.Gpt4oMiniTts20251215,
                _ => null,
            };
        }
    }
}