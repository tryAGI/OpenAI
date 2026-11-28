
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: reasoning
    /// </summary>
    public enum BetaReasoningInputTransformationType
    {
        /// <summary>
        ///
        /// </summary>
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaReasoningInputTransformationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningInputTransformationType value)
        {
            return value switch
            {
                BetaReasoningInputTransformationType.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningInputTransformationType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning" => BetaReasoningInputTransformationType.Reasoning,
                _ => null,
            };
        }
    }
}