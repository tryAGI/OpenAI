
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionModerationInputDiscriminatorType
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
    public static class ChatCompletionModerationInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionModerationInputDiscriminatorType value)
        {
            return value switch
            {
                ChatCompletionModerationInputDiscriminatorType.Error => "error",
                ChatCompletionModerationInputDiscriminatorType.ModerationResults => "moderation_results",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionModerationInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ChatCompletionModerationInputDiscriminatorType.Error,
                "moderation_results" => ChatCompletionModerationInputDiscriminatorType.ModerationResults,
                _ => null,
            };
        }
    }
}