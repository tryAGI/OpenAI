
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Allowed tool configuration type. Always `allowed_tools`.
    /// </summary>
    public enum ChatCompletionAllowedToolsChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        AllowedTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionAllowedToolsChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionAllowedToolsChoiceType value)
        {
            return value switch
            {
                ChatCompletionAllowedToolsChoiceType.AllowedTools => "allowed_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionAllowedToolsChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "allowed_tools" => ChatCompletionAllowedToolsChoiceType.AllowedTools,
                _ => null,
            };
        }
    }
}