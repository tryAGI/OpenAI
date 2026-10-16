
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: message
    /// </summary>
    public enum LiveDecisionStoredInputItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionStoredInputItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredInputItemParamType value)
        {
            return value switch
            {
                LiveDecisionStoredInputItemParamType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredInputItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "message" => LiveDecisionStoredInputItemParamType.Message,
                _ => null,
            };
        }
    }
}