
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatCompletionMessageListDataItemRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        Tool,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageListDataItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageListDataItemRole value)
        {
            return value switch
            {
                ChatCompletionMessageListDataItemRole.Assistant => "assistant",
                ChatCompletionMessageListDataItemRole.Developer => "developer",
                ChatCompletionMessageListDataItemRole.Function => "function",
                ChatCompletionMessageListDataItemRole.System => "system",
                ChatCompletionMessageListDataItemRole.Tool => "tool",
                ChatCompletionMessageListDataItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageListDataItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionMessageListDataItemRole.Assistant,
                "developer" => ChatCompletionMessageListDataItemRole.Developer,
                "function" => ChatCompletionMessageListDataItemRole.Function,
                "system" => ChatCompletionMessageListDataItemRole.System,
                "tool" => ChatCompletionMessageListDataItemRole.Tool,
                "user" => ChatCompletionMessageListDataItemRole.User,
                _ => null,
            };
        }
    }
}