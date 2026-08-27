
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the code interpreter tool call. Valid values are `in_progress`, `completed`, `incomplete`, `interpreting`, and `failed`.
    /// </summary>
    public enum BetaCodeInterpreterToolCallStatus
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
        Interpreting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCodeInterpreterToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCodeInterpreterToolCallStatus value)
        {
            return value switch
            {
                BetaCodeInterpreterToolCallStatus.Completed => "completed",
                BetaCodeInterpreterToolCallStatus.Failed => "failed",
                BetaCodeInterpreterToolCallStatus.InProgress => "in_progress",
                BetaCodeInterpreterToolCallStatus.Incomplete => "incomplete",
                BetaCodeInterpreterToolCallStatus.Interpreting => "interpreting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCodeInterpreterToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaCodeInterpreterToolCallStatus.Completed,
                "failed" => BetaCodeInterpreterToolCallStatus.Failed,
                "in_progress" => BetaCodeInterpreterToolCallStatus.InProgress,
                "incomplete" => BetaCodeInterpreterToolCallStatus.Incomplete,
                "interpreting" => BetaCodeInterpreterToolCallStatus.Interpreting,
                _ => null,
            };
        }
    }
}