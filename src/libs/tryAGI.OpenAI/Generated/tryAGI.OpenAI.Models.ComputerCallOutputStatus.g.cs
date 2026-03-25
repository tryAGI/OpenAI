
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ComputerCallOutputStatus
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
    public static class ComputerCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerCallOutputStatus value)
        {
            return value switch
            {
                ComputerCallOutputStatus.Completed => "completed",
                ComputerCallOutputStatus.Failed => "failed",
                ComputerCallOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ComputerCallOutputStatus.Completed,
                "failed" => ComputerCallOutputStatus.Failed,
                "incomplete" => ComputerCallOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}