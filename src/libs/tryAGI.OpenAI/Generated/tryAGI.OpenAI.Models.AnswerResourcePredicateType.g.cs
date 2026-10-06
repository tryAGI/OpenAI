
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `predicate`.<br/>
    /// Default Value: predicate
    /// </summary>
    public enum AnswerResourcePredicateType
    {
        /// <summary>
        ///
        /// </summary>
        Predicate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnswerResourcePredicateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnswerResourcePredicateType value)
        {
            return value switch
            {
                AnswerResourcePredicateType.Predicate => "predicate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnswerResourcePredicateType? ToEnum(string value)
        {
            return value switch
            {
                "predicate" => AnswerResourcePredicateType.Predicate,
                _ => null,
            };
        }
    }
}