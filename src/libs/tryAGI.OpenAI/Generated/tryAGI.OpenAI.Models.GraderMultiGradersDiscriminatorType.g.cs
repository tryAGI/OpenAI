
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum GraderMultiGradersDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        LabelModel,
        /// <summary>
        ///
        /// </summary>
        Python,
        /// <summary>
        ///
        /// </summary>
        ScoreModel,
        /// <summary>
        ///
        /// </summary>
        StringCheck,
        /// <summary>
        ///
        /// </summary>
        TextSimilarity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraderMultiGradersDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraderMultiGradersDiscriminatorType value)
        {
            return value switch
            {
                GraderMultiGradersDiscriminatorType.LabelModel => "label_model",
                GraderMultiGradersDiscriminatorType.Python => "python",
                GraderMultiGradersDiscriminatorType.ScoreModel => "score_model",
                GraderMultiGradersDiscriminatorType.StringCheck => "string_check",
                GraderMultiGradersDiscriminatorType.TextSimilarity => "text_similarity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraderMultiGradersDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "label_model" => GraderMultiGradersDiscriminatorType.LabelModel,
                "python" => GraderMultiGradersDiscriminatorType.Python,
                "score_model" => GraderMultiGradersDiscriminatorType.ScoreModel,
                "string_check" => GraderMultiGradersDiscriminatorType.StringCheck,
                "text_similarity" => GraderMultiGradersDiscriminatorType.TextSimilarity,
                _ => null,
            };
        }
    }
}