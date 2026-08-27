
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the function tool. Always `function`.<br/>
    /// Default Value: function
    /// </summary>
    public enum BetaFunctionToolType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFunctionToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionToolType value)
        {
            return value switch
            {
                BetaFunctionToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionToolType? ToEnum(string value)
        {
            return value switch
            {
                "function" => BetaFunctionToolType.Function,
                _ => null,
            };
        }
    }
}