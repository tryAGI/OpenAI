
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum MessageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
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
    public static class MessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStatus value)
        {
            return value switch
            {
                MessageStatus.InProgress => "in_progress",
                MessageStatus.Completed => "completed",
                MessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => MessageStatus.InProgress,
                "completed" => MessageStatus.Completed,
                "incomplete" => MessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}