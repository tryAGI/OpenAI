
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaOutputMessageContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOutputMessageContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputMessageContentDiscriminatorType value)
        {
            return value switch
            {
                BetaOutputMessageContentDiscriminatorType.OutputText => "output_text",
                BetaOutputMessageContentDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputMessageContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => BetaOutputMessageContentDiscriminatorType.OutputText,
                "refusal" => BetaOutputMessageContentDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}