
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `error`.
    /// </summary>
    public enum ChatCompletionModerationErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionModerationErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionModerationErrorType value)
        {
            return value switch
            {
                ChatCompletionModerationErrorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionModerationErrorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ChatCompletionModerationErrorType.Error,
                _ => null,
            };
        }
    }
}