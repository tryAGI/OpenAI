
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebSearchCallStatus
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
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Incomplete,
        /// <summary>
        ///
        /// </summary>
        Searching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchCallStatus value)
        {
            return value switch
            {
                WebSearchCallStatus.Completed => "completed",
                WebSearchCallStatus.Failed => "failed",
                WebSearchCallStatus.InProgress => "in_progress",
                WebSearchCallStatus.Incomplete => "incomplete",
                WebSearchCallStatus.Searching => "searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebSearchCallStatus.Completed,
                "failed" => WebSearchCallStatus.Failed,
                "in_progress" => WebSearchCallStatus.InProgress,
                "incomplete" => WebSearchCallStatus.Incomplete,
                "searching" => WebSearchCallStatus.Searching,
                _ => null,
            };
        }
    }
}