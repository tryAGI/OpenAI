
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The anchor point for the ephemeral token expiration. Only `created_at` is currently supported.
    /// </summary>
    public enum RealtimeSessionCreateRequestClientSecretExpiresAfterAnchor
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestClientSecretExpiresAfterAnchorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestClientSecretExpiresAfterAnchor value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestClientSecretExpiresAfterAnchor.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestClientSecretExpiresAfterAnchor? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => RealtimeSessionCreateRequestClientSecretExpiresAfterAnchor.CreatedAt,
                _ => null,
            };
        }
    }
}