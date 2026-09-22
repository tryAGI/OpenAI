
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of an agent output item.
    /// </summary>
    public enum OutputItemStatusResource
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemStatusResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemStatusResource value)
        {
            return value switch
            {
                OutputItemStatusResource.Completed => "completed",
                OutputItemStatusResource.InProgress => "in_progress",
                OutputItemStatusResource.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemStatusResource? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputItemStatusResource.Completed,
                "in_progress" => OutputItemStatusResource.InProgress,
                "incomplete" => OutputItemStatusResource.Incomplete,
                _ => null,
            };
        }
    }
}