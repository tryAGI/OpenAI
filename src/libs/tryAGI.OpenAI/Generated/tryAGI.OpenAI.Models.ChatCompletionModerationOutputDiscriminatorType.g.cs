
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionModerationOutputDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        ModerationResults,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionModerationOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionModerationOutputDiscriminatorType value)
        {
            return value switch
            {
                ChatCompletionModerationOutputDiscriminatorType.Error => "error",
                ChatCompletionModerationOutputDiscriminatorType.ModerationResults => "moderation_results",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionModerationOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ChatCompletionModerationOutputDiscriminatorType.Error,
                "moderation_results" => ChatCompletionModerationOutputDiscriminatorType.ModerationResults,
                _ => null,
            };
        }
    }
}