
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool type. Always `function`.<br/>
    /// Default Value: function
    /// </summary>
    public enum LiveFunctionToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveFunctionToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveFunctionToolInputParamType value)
        {
            return value switch
            {
                LiveFunctionToolInputParamType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveFunctionToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "function" => LiveFunctionToolInputParamType.Function,
                _ => null,
            };
        }
    }
}