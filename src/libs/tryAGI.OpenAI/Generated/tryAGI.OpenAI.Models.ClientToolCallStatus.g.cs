
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientToolCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolCallStatus value)
        {
            return value switch
            {
                ClientToolCallStatus.Completed => "completed",
                ClientToolCallStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ClientToolCallStatus.Completed,
                "in_progress" => ClientToolCallStatus.InProgress,
                _ => null,
            };
        }
    }
}