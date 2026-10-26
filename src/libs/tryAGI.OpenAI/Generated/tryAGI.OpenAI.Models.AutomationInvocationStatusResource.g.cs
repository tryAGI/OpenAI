
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AutomationInvocationStatusResource
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationInvocationStatusResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationInvocationStatusResource value)
        {
            return value switch
            {
                AutomationInvocationStatusResource.Completed => "completed",
                AutomationInvocationStatusResource.Failed => "failed",
                AutomationInvocationStatusResource.Queued => "queued",
                AutomationInvocationStatusResource.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationInvocationStatusResource? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutomationInvocationStatusResource.Completed,
                "failed" => AutomationInvocationStatusResource.Failed,
                "queued" => AutomationInvocationStatusResource.Queued,
                "skipped" => AutomationInvocationStatusResource.Skipped,
                _ => null,
            };
        }
    }
}