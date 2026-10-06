
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `refusal`.<br/>
    /// Default Value: refusal
    /// </summary>
    public enum AnswerResourceRefusalType
    {
        /// <summary>
        ///
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnswerResourceRefusalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnswerResourceRefusalType value)
        {
            return value switch
            {
                AnswerResourceRefusalType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnswerResourceRefusalType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => AnswerResourceRefusalType.Refusal,
                _ => null,
            };
        }
    }
}