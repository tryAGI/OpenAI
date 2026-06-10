
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `moderation_results`.
    /// </summary>
    public enum ChatCompletionModerationResultsType
    {
        /// <summary>
        /// 
        /// </summary>
        ModerationResults,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionModerationResultsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionModerationResultsType value)
        {
            return value switch
            {
                ChatCompletionModerationResultsType.ModerationResults => "moderation_results",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionModerationResultsType? ToEnum(string value)
        {
            return value switch
            {
                "moderation_results" => ChatCompletionModerationResultsType.ModerationResults,
                _ => null,
            };
        }
    }
}