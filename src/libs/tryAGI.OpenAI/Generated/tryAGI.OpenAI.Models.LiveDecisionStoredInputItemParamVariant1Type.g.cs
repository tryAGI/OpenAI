
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionStoredInputItemParamVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionStoredInputItemParamVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredInputItemParamVariant1Type value)
        {
            return value switch
            {
                LiveDecisionStoredInputItemParamVariant1Type.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredInputItemParamVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "message" => LiveDecisionStoredInputItemParamVariant1Type.Message,
                _ => null,
            };
        }
    }
}