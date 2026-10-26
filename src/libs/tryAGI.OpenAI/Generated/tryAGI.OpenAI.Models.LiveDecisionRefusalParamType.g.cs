
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: refusal
    /// </summary>
    public enum LiveDecisionRefusalParamType
    {
        /// <summary>
        ///
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionRefusalParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionRefusalParamType value)
        {
            return value switch
            {
                LiveDecisionRefusalParamType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionRefusalParamType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => LiveDecisionRefusalParamType.Refusal,
                _ => null,
            };
        }
    }
}