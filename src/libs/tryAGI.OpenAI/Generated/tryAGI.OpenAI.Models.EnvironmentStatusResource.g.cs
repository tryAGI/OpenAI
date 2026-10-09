
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The public lifecycle status of an execution environment.
    /// </summary>
    public enum EnvironmentStatusResource
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
    public static class EnvironmentStatusResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentStatusResource value)
        {
            return value switch
            {
                EnvironmentStatusResource.Connected => "connected",
                EnvironmentStatusResource.Disconnected => "disconnected",
                EnvironmentStatusResource.Expired => "expired",
                EnvironmentStatusResource.Failed => "failed",
                EnvironmentStatusResource.Pending => "pending",
                EnvironmentStatusResource.Ready => "ready",
                EnvironmentStatusResource.Suspended => "suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentStatusResource? ToEnum(string value)
        {
            return value switch
            {
                "connected" => EnvironmentStatusResource.Connected,
                "disconnected" => EnvironmentStatusResource.Disconnected,
                "expired" => EnvironmentStatusResource.Expired,
                "failed" => EnvironmentStatusResource.Failed,
                "pending" => EnvironmentStatusResource.Pending,
                "ready" => EnvironmentStatusResource.Ready,
                "suspended" => EnvironmentStatusResource.Suspended,
                _ => null,
            };
        }
    }
}