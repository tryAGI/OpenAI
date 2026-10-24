
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: input_image
    /// </summary>
    public enum LiveDecisionUserInputImageParamType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionUserInputImageParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionUserInputImageParamType value)
        {
            return value switch
            {
                LiveDecisionUserInputImageParamType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionUserInputImageParamType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => LiveDecisionUserInputImageParamType.InputImage,
                _ => null,
            };
        }
    }
}