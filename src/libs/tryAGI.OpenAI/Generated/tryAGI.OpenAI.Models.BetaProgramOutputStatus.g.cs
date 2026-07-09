
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaProgramOutputStatus
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
    public static class BetaProgramOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaProgramOutputStatus value)
        {
            return value switch
            {
                BetaProgramOutputStatus.Completed => "completed",
                BetaProgramOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaProgramOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaProgramOutputStatus.Completed,
                "incomplete" => BetaProgramOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}