
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: message
    /// </summary>
    public enum LiveDecisionDeveloperMessageParamType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionDeveloperMessageParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionDeveloperMessageParamType value)
        {
            return value switch
            {
                LiveDecisionDeveloperMessageParamType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionDeveloperMessageParamType? ToEnum(string value)
        {
            return value switch
            {
                "message" => LiveDecisionDeveloperMessageParamType.Message,
                _ => null,
            };
        }
    }
}