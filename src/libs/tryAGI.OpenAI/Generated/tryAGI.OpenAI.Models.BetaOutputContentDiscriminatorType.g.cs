
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaOutputContentDiscriminatorType
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
    public static class BetaOutputContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputContentDiscriminatorType value)
        {
            return value switch
            {
                BetaOutputContentDiscriminatorType.OutputText => "output_text",
                BetaOutputContentDiscriminatorType.ReasoningText => "reasoning_text",
                BetaOutputContentDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => BetaOutputContentDiscriminatorType.OutputText,
                "reasoning_text" => BetaOutputContentDiscriminatorType.ReasoningText,
                "refusal" => BetaOutputContentDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}