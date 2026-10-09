
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The connection status of a session environment.
    /// </summary>
    public enum SessionEnvironmentStatusResource
    {
        /// <summary>
        ///
        /// </summary>
        Connected,
        /// <summary>
        ///
        /// </summary>
        Disconnected,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Ready,
        /// <summary>
        ///
        /// </summary>
        Suspended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEnvironmentStatusResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEnvironmentStatusResource value)
        {
            return value switch
            {
                SessionEnvironmentStatusResource.Connected => "connected",
                SessionEnvironmentStatusResource.Disconnected => "disconnected",
                SessionEnvironmentStatusResource.Expired => "expired",
                SessionEnvironmentStatusResource.Failed => "failed",
                SessionEnvironmentStatusResource.Pending => "pending",
                SessionEnvironmentStatusResource.Ready => "ready",
                SessionEnvironmentStatusResource.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEnvironmentStatusResource? ToEnum(string value)
        {
            return value switch
            {
                "connected" => SessionEnvironmentStatusResource.Connected,
                "disconnected" => SessionEnvironmentStatusResource.Disconnected,
                "expired" => SessionEnvironmentStatusResource.Expired,
                "failed" => SessionEnvironmentStatusResource.Failed,
                "pending" => SessionEnvironmentStatusResource.Pending,
                "ready" => SessionEnvironmentStatusResource.Ready,
                "suspended" => SessionEnvironmentStatusResource.Suspended,
                _ => null,
            };
        }
    }
}