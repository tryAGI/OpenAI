
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Anchor timestamp after which the expiration policy applies. Supported anchors: `created_at`. Note that the anchor is the file creation time, not the time the batch is created.
    /// </summary>
    public enum BatchFileExpirationAfterAnchor
    {
        /// <summary>
        /// `created_at`. Note that the anchor is the file creation time, not the time the batch is created.
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchFileExpirationAfterAnchorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchFileExpirationAfterAnchor value)
        {
            return value switch
            {
                BatchFileExpirationAfterAnchor.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchFileExpirationAfterAnchor? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => BatchFileExpirationAfterAnchor.CreatedAt,
                _ => null,
            };
        }
    }
}