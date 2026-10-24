
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: message
    /// </summary>
    public enum LiveDecisionStoredSystemMessageParamType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionStoredSystemMessageParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredSystemMessageParamType value)
        {
            return value switch
            {
                LiveDecisionStoredSystemMessageParamType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredSystemMessageParamType? ToEnum(string value)
        {
            return value switch
            {
                "message" => LiveDecisionStoredSystemMessageParamType.Message,
                _ => null,
            };
        }
    }
}