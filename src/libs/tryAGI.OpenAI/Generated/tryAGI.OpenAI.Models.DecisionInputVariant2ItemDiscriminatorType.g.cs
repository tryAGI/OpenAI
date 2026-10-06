
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionInputVariant2ItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                DecisionInputVariant2ItemDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "message" => DecisionInputVariant2ItemDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}