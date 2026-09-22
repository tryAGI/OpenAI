
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaWebSearchCallStatus
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
        Searching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchCallStatus value)
        {
            return value switch
            {
                BetaWebSearchCallStatus.Completed => "completed",
                BetaWebSearchCallStatus.Failed => "failed",
                BetaWebSearchCallStatus.InProgress => "in_progress",
                BetaWebSearchCallStatus.Incomplete => "incomplete",
                BetaWebSearchCallStatus.Searching => "searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaWebSearchCallStatus.Completed,
                "failed" => BetaWebSearchCallStatus.Failed,
                "in_progress" => BetaWebSearchCallStatus.InProgress,
                "incomplete" => BetaWebSearchCallStatus.Incomplete,
                "searching" => BetaWebSearchCallStatus.Searching,
                _ => null,
            };
        }
    }
}