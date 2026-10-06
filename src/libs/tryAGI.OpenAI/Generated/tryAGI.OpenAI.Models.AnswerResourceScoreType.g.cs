
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `score`.<br/>
    /// Default Value: score
    /// </summary>
    public enum AnswerResourceScoreType
    {
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnswerResourceScoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnswerResourceScoreType value)
        {
            return value switch
            {
                AnswerResourceScoreType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnswerResourceScoreType? ToEnum(string value)
        {
            return value switch
            {
                "score" => AnswerResourceScoreType.Score,
                _ => null,
            };
        }
    }
}