
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveFunctionCallItemStatus
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
    public static class LiveFunctionCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveFunctionCallItemStatus value)
        {
            return value switch
            {
                LiveFunctionCallItemStatus.Completed => "completed",
                LiveFunctionCallItemStatus.InProgress => "in_progress",
                LiveFunctionCallItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveFunctionCallItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => LiveFunctionCallItemStatus.Completed,
                "in_progress" => LiveFunctionCallItemStatus.InProgress,
                "incomplete" => LiveFunctionCallItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}