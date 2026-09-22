
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The current status of a session.
    /// </summary>
    public enum SessionStatusResource
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Idle,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        RequiresAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionStatusResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionStatusResource value)
        {
            return value switch
            {
                SessionStatusResource.Failed => "failed",
                SessionStatusResource.Idle => "idle",
                SessionStatusResource.InProgress => "in_progress",
                SessionStatusResource.RequiresAction => "requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionStatusResource? ToEnum(string value)
        {
            return value switch
            {
                "failed" => SessionStatusResource.Failed,
                "idle" => SessionStatusResource.Idle,
                "in_progress" => SessionStatusResource.InProgress,
                "requires_action" => SessionStatusResource.RequiresAction,
                _ => null,
            };
        }
    }
}