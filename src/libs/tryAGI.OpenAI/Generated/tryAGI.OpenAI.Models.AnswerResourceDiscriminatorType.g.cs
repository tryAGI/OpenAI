
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AnswerResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
        /// <summary>
        ///
        /// </summary>
        Predicate,
        /// <summary>
        ///
        /// </summary>
        Refusal,
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnswerResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnswerResourceDiscriminatorType value)
        {
            return value switch
            {
                AnswerResourceDiscriminatorType.Choice => "choice",
                AnswerResourceDiscriminatorType.Predicate => "predicate",
                AnswerResourceDiscriminatorType.Refusal => "refusal",
                AnswerResourceDiscriminatorType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnswerResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => AnswerResourceDiscriminatorType.Choice,
                "predicate" => AnswerResourceDiscriminatorType.Predicate,
                "refusal" => AnswerResourceDiscriminatorType.Refusal,
                "score" => AnswerResourceDiscriminatorType.Score,
                _ => null,
            };
        }
    }
}