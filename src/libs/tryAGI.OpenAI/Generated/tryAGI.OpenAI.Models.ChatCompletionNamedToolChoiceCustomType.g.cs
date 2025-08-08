
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// For custom tool calling, the type is always `custom`.
    /// </summary>
    public enum ChatCompletionNamedToolChoiceCustomType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionNamedToolChoiceCustomTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionNamedToolChoiceCustomType value)
        {
            return value switch
            {
                ChatCompletionNamedToolChoiceCustomType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionNamedToolChoiceCustomType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ChatCompletionNamedToolChoiceCustomType.Custom,
                _ => null,
            };
        }
    }
}