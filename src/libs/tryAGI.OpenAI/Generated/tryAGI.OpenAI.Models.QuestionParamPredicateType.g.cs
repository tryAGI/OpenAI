
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `predicate`.<br/>
    /// Default Value: predicate
    /// </summary>
    public enum QuestionParamPredicateType
    {
        /// <summary>
        ///
        /// </summary>
        Predicate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QuestionParamPredicateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QuestionParamPredicateType value)
        {
            return value switch
            {
                QuestionParamPredicateType.Predicate => "predicate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QuestionParamPredicateType? ToEnum(string value)
        {
            return value switch
            {
                "predicate" => QuestionParamPredicateType.Predicate,
                _ => null,
            };
        }
    }
}