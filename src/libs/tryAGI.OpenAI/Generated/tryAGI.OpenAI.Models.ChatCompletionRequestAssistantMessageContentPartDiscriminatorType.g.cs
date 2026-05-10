
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestAssistantMessageContentPartDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Refusal,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestAssistantMessageContentPartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestAssistantMessageContentPartDiscriminatorType value)
        {
            return value switch
            {
                ChatCompletionRequestAssistantMessageContentPartDiscriminatorType.Refusal => "refusal",
                ChatCompletionRequestAssistantMessageContentPartDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestAssistantMessageContentPartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => ChatCompletionRequestAssistantMessageContentPartDiscriminatorType.Refusal,
                "text" => ChatCompletionRequestAssistantMessageContentPartDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}