
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: removed
    /// </summary>
    public enum BetaReasoningInputTransformationAction
    {
        /// <summary>
        ///
        /// </summary>
        Removed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaReasoningInputTransformationActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningInputTransformationAction value)
        {
            return value switch
            {
                BetaReasoningInputTransformationAction.Removed => "removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningInputTransformationAction? ToEnum(string value)
        {
            return value switch
            {
                "removed" => BetaReasoningInputTransformationAction.Removed,
                _ => null,
            };
        }
    }
}