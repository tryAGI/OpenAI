
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Specifies the voice type. Supported voices are `alloy`, `echo`, <br/>
    /// `fable`, `onyx`, `nova`, and `shimmer`.
    /// </summary>
    public enum CreateChatCompletionRequestAudioVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        Echo,
        /// <summary>
        /// 
        /// </summary>
        Fable,
        /// <summary>
        /// 
        /// </summary>
        Onyx,
        /// <summary>
        /// 
        /// </summary>
        Nova,
        /// <summary>
        /// 
        /// </summary>
        Shimmer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestAudioVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestAudioVoice value)
        {
            return value switch
            {
                CreateChatCompletionRequestAudioVoice.Alloy => "alloy",
                CreateChatCompletionRequestAudioVoice.Echo => "echo",
                CreateChatCompletionRequestAudioVoice.Fable => "fable",
                CreateChatCompletionRequestAudioVoice.Onyx => "onyx",
                CreateChatCompletionRequestAudioVoice.Nova => "nova",
                CreateChatCompletionRequestAudioVoice.Shimmer => "shimmer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestAudioVoice? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => CreateChatCompletionRequestAudioVoice.Alloy,
                "echo" => CreateChatCompletionRequestAudioVoice.Echo,
                "fable" => CreateChatCompletionRequestAudioVoice.Fable,
                "onyx" => CreateChatCompletionRequestAudioVoice.Onyx,
                "nova" => CreateChatCompletionRequestAudioVoice.Nova,
                "shimmer" => CreateChatCompletionRequestAudioVoice.Shimmer,
                _ => null,
            };
        }
    }
}