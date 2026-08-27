
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaProgramOutputItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaProgramOutputItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaProgramOutputItemStatus value)
        {
            return value switch
            {
                BetaProgramOutputItemStatus.Completed => "completed",
                BetaProgramOutputItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaProgramOutputItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaProgramOutputItemStatus.Completed,
                "incomplete" => BetaProgramOutputItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}