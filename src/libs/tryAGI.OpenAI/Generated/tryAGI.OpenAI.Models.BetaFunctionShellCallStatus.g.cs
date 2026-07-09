
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFunctionShellCallStatus
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
    public static class BetaFunctionShellCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallStatus value)
        {
            return value switch
            {
                BetaFunctionShellCallStatus.Completed => "completed",
                BetaFunctionShellCallStatus.InProgress => "in_progress",
                BetaFunctionShellCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaFunctionShellCallStatus.Completed,
                "in_progress" => BetaFunctionShellCallStatus.InProgress,
                "incomplete" => BetaFunctionShellCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}