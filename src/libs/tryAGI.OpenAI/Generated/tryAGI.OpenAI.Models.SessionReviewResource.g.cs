
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The configured action review mode.
    /// </summary>
    public enum SessionReviewResource
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
    public static class SessionReviewResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionReviewResource value)
        {
            return value switch
            {
                SessionReviewResource.AutoReview => "auto_review",
                SessionReviewResource.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionReviewResource? ToEnum(string value)
        {
            return value switch
            {
                "auto_review" => SessionReviewResource.AutoReview,
                "none" => SessionReviewResource.None,
                _ => null,
            };
        }
    }
}