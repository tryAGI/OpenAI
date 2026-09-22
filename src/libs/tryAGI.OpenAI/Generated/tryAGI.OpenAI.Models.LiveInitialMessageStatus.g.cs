
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveInitialMessageStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialMessageStatus value)
        {
            return value switch
            {
                LiveInitialMessageStatus.Completed => "completed",
                LiveInitialMessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => LiveInitialMessageStatus.Completed,
                "incomplete" => LiveInitialMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}