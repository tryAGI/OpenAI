
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageStatus
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
    public static class MessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStatus value)
        {
            return value switch
            {
                MessageStatus.Completed => "completed",
                MessageStatus.InProgress => "in_progress",
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
                "completed" => MessageStatus.Completed,
                "in_progress" => MessageStatus.InProgress,
                "incomplete" => MessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}