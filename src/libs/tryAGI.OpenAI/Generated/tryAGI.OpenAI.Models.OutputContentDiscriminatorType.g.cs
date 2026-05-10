
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
        /// <summary>
        /// 
        /// </summary>
        ReasoningText,
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputContentDiscriminatorType value)
        {
            return value switch
            {
                OutputContentDiscriminatorType.OutputText => "output_text",
                OutputContentDiscriminatorType.ReasoningText => "reasoning_text",
                OutputContentDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => OutputContentDiscriminatorType.OutputText,
                "reasoning_text" => OutputContentDiscriminatorType.ReasoningText,
                "refusal" => OutputContentDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}