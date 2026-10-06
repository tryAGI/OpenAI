
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: function
    /// </summary>
    public enum BetaToolSearchOutputFunctionToolParamType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolSearchOutputFunctionToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchOutputFunctionToolParamType value)
        {
            return value switch
            {
                BetaToolSearchOutputFunctionToolParamType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchOutputFunctionToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "function" => BetaToolSearchOutputFunctionToolParamType.Function,
                _ => null,
            };
        }
    }
}