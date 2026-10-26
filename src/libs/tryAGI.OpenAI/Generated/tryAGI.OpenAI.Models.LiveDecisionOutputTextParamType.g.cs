
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: output_text
    /// </summary>
    public enum LiveDecisionOutputTextParamType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionOutputTextParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionOutputTextParamType value)
        {
            return value switch
            {
                LiveDecisionOutputTextParamType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionOutputTextParamType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => LiveDecisionOutputTextParamType.OutputText,
                _ => null,
            };
        }
    }
}