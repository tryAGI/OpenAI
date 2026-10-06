
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: function
    /// </summary>
    public enum ToolSearchOutputFunctionToolParamType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchOutputFunctionToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchOutputFunctionToolParamType value)
        {
            return value switch
            {
                ToolSearchOutputFunctionToolParamType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchOutputFunctionToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolSearchOutputFunctionToolParamType.Function,
                _ => null,
            };
        }
    }
}