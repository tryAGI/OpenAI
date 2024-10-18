
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestUserMessageContentPartDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestUserMessageContentPartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestUserMessageContentPartDiscriminatorType value)
        {
            return value switch
            {
                ChatCompletionRequestUserMessageContentPartDiscriminatorType.Text => "text",
                ChatCompletionRequestUserMessageContentPartDiscriminatorType.ImageUrl => "image_url",
                ChatCompletionRequestUserMessageContentPartDiscriminatorType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestUserMessageContentPartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionRequestUserMessageContentPartDiscriminatorType.Text,
                "image_url" => ChatCompletionRequestUserMessageContentPartDiscriminatorType.ImageUrl,
                "input_audio" => ChatCompletionRequestUserMessageContentPartDiscriminatorType.InputAudio,
                _ => null,
            };
        }
    }
}