
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum QuestionParamDiscriminatorType
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
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QuestionParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QuestionParamDiscriminatorType value)
        {
            return value switch
            {
                QuestionParamDiscriminatorType.Choice => "choice",
                QuestionParamDiscriminatorType.Predicate => "predicate",
                QuestionParamDiscriminatorType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QuestionParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => QuestionParamDiscriminatorType.Choice,
                "predicate" => QuestionParamDiscriminatorType.Predicate,
                "score" => QuestionParamDiscriminatorType.Score,
                _ => null,
            };
        }
    }
}