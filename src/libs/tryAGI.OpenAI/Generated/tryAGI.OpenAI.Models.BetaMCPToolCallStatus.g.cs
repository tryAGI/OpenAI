
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaMCPToolCallStatus
    {
        /// <summary>
        ///
        /// </summary>
        Calling,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMCPToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMCPToolCallStatus value)
        {
            return value switch
            {
                BetaMCPToolCallStatus.Calling => "calling",
                BetaMCPToolCallStatus.Completed => "completed",
                BetaMCPToolCallStatus.Failed => "failed",
                BetaMCPToolCallStatus.InProgress => "in_progress",
                BetaMCPToolCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMCPToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "calling" => BetaMCPToolCallStatus.Calling,
                "completed" => BetaMCPToolCallStatus.Completed,
                "failed" => BetaMCPToolCallStatus.Failed,
                "in_progress" => BetaMCPToolCallStatus.InProgress,
                "incomplete" => BetaMCPToolCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}