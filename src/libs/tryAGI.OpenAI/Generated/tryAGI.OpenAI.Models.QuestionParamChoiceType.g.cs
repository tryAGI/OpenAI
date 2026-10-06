
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `choice`.<br/>
    /// Default Value: choice
    /// </summary>
    public enum QuestionParamChoiceType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QuestionParamChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QuestionParamChoiceType value)
        {
            return value switch
            {
                QuestionParamChoiceType.Choice => "choice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QuestionParamChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => QuestionParamChoiceType.Choice,
                _ => null,
            };
        }
    }
}