
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: message
    /// </summary>
    public enum LiveDecisionSystemMessageParamType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionSystemMessageParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionSystemMessageParamType value)
        {
            return value switch
            {
                LiveDecisionSystemMessageParamType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionSystemMessageParamType? ToEnum(string value)
        {
            return value switch
            {
                "message" => LiveDecisionSystemMessageParamType.Message,
                _ => null,
            };
        }
    }
}