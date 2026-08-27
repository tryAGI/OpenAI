
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Status values reported for shell tool calls.
    /// </summary>
    public enum BetaFunctionShellCallItemStatus
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
    public static class BetaFunctionShellCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallItemStatus value)
        {
            return value switch
            {
                BetaFunctionShellCallItemStatus.Completed => "completed",
                BetaFunctionShellCallItemStatus.InProgress => "in_progress",
                BetaFunctionShellCallItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaFunctionShellCallItemStatus.Completed,
                "in_progress" => BetaFunctionShellCallItemStatus.InProgress,
                "incomplete" => BetaFunctionShellCallItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}