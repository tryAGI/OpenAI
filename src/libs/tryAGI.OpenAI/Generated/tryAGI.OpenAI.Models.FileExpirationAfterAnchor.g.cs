
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Anchor timestamp after which the expiration policy applies. Supported anchors: `created_at`.
    /// </summary>
    public enum FileExpirationAfterAnchor
    {
        /// <summary>
        /// `created_at`.
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileExpirationAfterAnchorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileExpirationAfterAnchor value)
        {
            return value switch
            {
                FileExpirationAfterAnchor.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileExpirationAfterAnchor? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => FileExpirationAfterAnchor.CreatedAt,
                _ => null,
            };
        }
    }
}