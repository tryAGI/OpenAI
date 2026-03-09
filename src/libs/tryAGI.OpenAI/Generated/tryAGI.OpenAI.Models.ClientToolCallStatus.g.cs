
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
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
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
                ClientToolCallStatus.InProgress => "in_progress",
                ClientToolCallStatus.Completed => "completed",
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
                "in_progress" => ClientToolCallStatus.InProgress,
                "completed" => ClientToolCallStatus.Completed,
                _ => null,
            };
        }
    }
}