
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComputerCallOutputStatus
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
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComputerCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComputerCallOutputStatus value)
        {
            return value switch
            {
                BetaComputerCallOutputStatus.Completed => "completed",
                BetaComputerCallOutputStatus.Failed => "failed",
                BetaComputerCallOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComputerCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaComputerCallOutputStatus.Completed,
                "failed" => BetaComputerCallOutputStatus.Failed,
                "incomplete" => BetaComputerCallOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}