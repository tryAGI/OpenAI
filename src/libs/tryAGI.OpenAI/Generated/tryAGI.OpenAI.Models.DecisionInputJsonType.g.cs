
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: input_json
    /// </summary>
    public enum DecisionInputJsonType
    {
        /// <summary>
        ///
        /// </summary>
        InputJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputJsonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputJsonType value)
        {
            return value switch
            {
                DecisionInputJsonType.InputJson => "input_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputJsonType? ToEnum(string value)
        {
            return value switch
            {
                "input_json" => DecisionInputJsonType.InputJson,
                _ => null,
            };
        }
    }
}