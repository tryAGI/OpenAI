
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: function
    /// </summary>
    public enum FunctionToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionToolParamType value)
        {
            return value switch
            {
                FunctionToolParamType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "function" => FunctionToolParamType.Function,
                _ => null,
            };
        }
    }
}