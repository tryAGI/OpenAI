
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: function
    /// </summary>
    public enum LiveFunctionToolChoiceParamType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveFunctionToolChoiceParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveFunctionToolChoiceParamType value)
        {
            return value switch
            {
                LiveFunctionToolChoiceParamType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveFunctionToolChoiceParamType? ToEnum(string value)
        {
            return value switch
            {
                "function" => LiveFunctionToolChoiceParamType.Function,
                _ => null,
            };
        }
    }
}