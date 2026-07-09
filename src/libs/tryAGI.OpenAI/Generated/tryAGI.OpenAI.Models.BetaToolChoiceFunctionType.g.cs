
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// For function calling, the type is always `function`.
    /// </summary>
    public enum BetaToolChoiceFunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolChoiceFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolChoiceFunctionType value)
        {
            return value switch
            {
                BetaToolChoiceFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolChoiceFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => BetaToolChoiceFunctionType.Function,
                _ => null,
            };
        }
    }
}