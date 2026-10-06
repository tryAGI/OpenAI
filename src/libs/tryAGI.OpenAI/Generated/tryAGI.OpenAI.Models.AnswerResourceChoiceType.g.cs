
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `choice`.<br/>
    /// Default Value: choice
    /// </summary>
    public enum AnswerResourceChoiceType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnswerResourceChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnswerResourceChoiceType value)
        {
            return value switch
            {
                AnswerResourceChoiceType.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnswerResourceChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => AnswerResourceChoiceType.Choice,
                _ => null,
            };
        }
    }
}