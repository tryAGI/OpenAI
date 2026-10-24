
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: input_json
    /// </summary>
    public enum LiveDecisionInputJsonParamType
    {
        /// <summary>
        ///
        /// </summary>
        InputJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionInputJsonParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionInputJsonParamType value)
        {
            return value switch
            {
                LiveDecisionInputJsonParamType.InputJson => "input_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionInputJsonParamType? ToEnum(string value)
        {
            return value switch
            {
                "input_json" => LiveDecisionInputJsonParamType.InputJson,
                _ => null,
            };
        }
    }
}