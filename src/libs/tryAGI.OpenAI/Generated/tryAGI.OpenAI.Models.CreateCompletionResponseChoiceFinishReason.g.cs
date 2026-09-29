
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateCompletionResponseChoiceFinishReason
    {
        /// <summary>
        ///
        /// </summary>
        ContentFilter,
        /// <summary>
        ///
        /// </summary>
        Length,
        /// <summary>
        ///
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCompletionResponseChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCompletionResponseChoiceFinishReason value)
        {
            return value switch
            {
                CreateCompletionResponseChoiceFinishReason.ContentFilter => "content_filter",
                CreateCompletionResponseChoiceFinishReason.Length => "length",
                CreateCompletionResponseChoiceFinishReason.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCompletionResponseChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => CreateCompletionResponseChoiceFinishReason.ContentFilter,
                "length" => CreateCompletionResponseChoiceFinishReason.Length,
                "stop" => CreateCompletionResponseChoiceFinishReason.Stop,
                _ => null,
            };
        }
    }
}