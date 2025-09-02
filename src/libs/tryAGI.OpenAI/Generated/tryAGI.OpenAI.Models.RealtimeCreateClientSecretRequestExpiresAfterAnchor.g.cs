
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The anchor point for the ephemeral token expiration. Only `created_at` is currently supported.<br/>
    /// Default Value: created_at
    /// </summary>
    public enum RealtimeCreateClientSecretRequestExpiresAfterAnchor
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeCreateClientSecretRequestExpiresAfterAnchorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeCreateClientSecretRequestExpiresAfterAnchor value)
        {
            return value switch
            {
                RealtimeCreateClientSecretRequestExpiresAfterAnchor.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeCreateClientSecretRequestExpiresAfterAnchor? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => RealtimeCreateClientSecretRequestExpiresAfterAnchor.CreatedAt,
                _ => null,
            };
        }
    }
}