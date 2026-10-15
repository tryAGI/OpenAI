
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: refusal
    /// </summary>
    public enum DecisionInputRefusalType
    {
        /// <summary>
        ///
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputRefusalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputRefusalType value)
        {
            return value switch
            {
                DecisionInputRefusalType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputRefusalType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => DecisionInputRefusalType.Refusal,
                _ => null,
            };
        }
    }
}