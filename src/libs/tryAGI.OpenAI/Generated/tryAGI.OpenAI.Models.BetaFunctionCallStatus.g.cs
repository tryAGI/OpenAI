
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFunctionCallStatus
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
    public static class BetaFunctionCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionCallStatus value)
        {
            return value switch
            {
                BetaFunctionCallStatus.Completed => "completed",
                BetaFunctionCallStatus.InProgress => "in_progress",
                BetaFunctionCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaFunctionCallStatus.Completed,
                "in_progress" => BetaFunctionCallStatus.InProgress,
                "incomplete" => BetaFunctionCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}