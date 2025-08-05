
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the detail level of the image. Learn more in the [Vision guide](https://platform.openai.com/docs/guides/vision#low-or-high-fidelity-image-understanding).<br/>
    /// Default Value: auto
    /// </summary>
    public enum ChatCompletionRequestMessageContentPartImageImageUrlDetail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// //platform.openai.com/docs/guides/vision#low-or-high-fidelity-image-understanding).
        /// </summary>
        Low,
        /// <summary>
        /// //platform.openai.com/docs/guides/vision#low-or-high-fidelity-image-understanding).
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageContentPartImageImageUrlDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageContentPartImageImageUrlDetail value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto => "auto",
                ChatCompletionRequestMessageContentPartImageImageUrlDetail.Low => "low",
                ChatCompletionRequestMessageContentPartImageImageUrlDetail.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageContentPartImageImageUrlDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto,
                "low" => ChatCompletionRequestMessageContentPartImageImageUrlDetail.Low,
                "high" => ChatCompletionRequestMessageContentPartImageImageUrlDetail.High,
                _ => null,
            };
        }
    }
}