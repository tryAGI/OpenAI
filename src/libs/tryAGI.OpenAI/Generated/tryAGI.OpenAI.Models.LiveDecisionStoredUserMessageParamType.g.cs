
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: message
    /// </summary>
    public enum LiveDecisionStoredUserMessageParamType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionStoredUserMessageParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredUserMessageParamType value)
        {
            return value switch
            {
                LiveDecisionStoredUserMessageParamType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredUserMessageParamType? ToEnum(string value)
        {
            return value switch
            {
                "message" => LiveDecisionStoredUserMessageParamType.Message,
                _ => null,
            };
        }
    }
}