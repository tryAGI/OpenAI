
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionMessageToolCallDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageToolCallDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageToolCallDiscriminatorType value)
        {
            return value switch
            {
                ChatCompletionMessageToolCallDiscriminatorType.Custom => "custom",
                ChatCompletionMessageToolCallDiscriminatorType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageToolCallDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ChatCompletionMessageToolCallDiscriminatorType.Custom,
                "function" => ChatCompletionMessageToolCallDiscriminatorType.Function,
                _ => null,
            };
        }
    }
}