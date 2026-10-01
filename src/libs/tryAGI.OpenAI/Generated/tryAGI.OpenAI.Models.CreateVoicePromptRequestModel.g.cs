
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateVoicePromptRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        x20261001,
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVoicePromptRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoicePromptRequestModel value)
        {
            return value switch
            {
                CreateVoicePromptRequestModel.x20261001 => "2026-10-01",
                CreateVoicePromptRequestModel.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoicePromptRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "2026-10-01" => CreateVoicePromptRequestModel.x20261001,
                "auto" => CreateVoicePromptRequestModel.Auto,
                _ => null,
            };
        }
    }
}