
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Review applied to eligible actions in a session.
    /// </summary>
    public enum SessionReviewParam
    {
        /// <summary>
        ///
        /// </summary>
        AutoReview,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionReviewParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionReviewParam value)
        {
            return value switch
            {
                SessionReviewParam.AutoReview => "auto_review",
                SessionReviewParam.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionReviewParam? ToEnum(string value)
        {
            return value switch
            {
                "auto_review" => SessionReviewParam.AutoReview,
                "none" => SessionReviewParam.None,
                _ => null,
            };
        }
    }
}