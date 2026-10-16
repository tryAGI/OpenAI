
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Set to `prompt` to create a voice from a text description.
    /// </summary>
    public enum CreateVoicePromptRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVoicePromptRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoicePromptRequestType value)
        {
            return value switch
            {
                CreateVoicePromptRequestType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoicePromptRequestType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => CreateVoicePromptRequestType.Prompt,
                _ => null,
            };
        }
    }
}