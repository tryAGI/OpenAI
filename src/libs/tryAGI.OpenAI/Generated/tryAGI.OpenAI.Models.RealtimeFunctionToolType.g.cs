
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the tool, i.e. `function`.
    /// </summary>
    public enum RealtimeFunctionToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeFunctionToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeFunctionToolType value)
        {
            return value switch
            {
                RealtimeFunctionToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeFunctionToolType? ToEnum(string value)
        {
            return value switch
            {
                "function" => RealtimeFunctionToolType.Function,
                _ => null,
            };
        }
    }
}