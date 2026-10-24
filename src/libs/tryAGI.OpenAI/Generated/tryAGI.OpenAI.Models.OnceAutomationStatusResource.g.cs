
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum OnceAutomationStatusResource
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OnceAutomationStatusResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OnceAutomationStatusResource value)
        {
            return value switch
            {
                OnceAutomationStatusResource.Active => "active",
                OnceAutomationStatusResource.Completed => "completed",
                OnceAutomationStatusResource.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OnceAutomationStatusResource? ToEnum(string value)
        {
            return value switch
            {
                "active" => OnceAutomationStatusResource.Active,
                "completed" => OnceAutomationStatusResource.Completed,
                "paused" => OnceAutomationStatusResource.Paused,
                _ => null,
            };
        }
    }
}