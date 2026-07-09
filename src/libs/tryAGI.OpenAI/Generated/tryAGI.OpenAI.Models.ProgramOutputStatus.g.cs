
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProgramOutputStatus
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
    public static class ProgramOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProgramOutputStatus value)
        {
            return value switch
            {
                ProgramOutputStatus.Completed => "completed",
                ProgramOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProgramOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ProgramOutputStatus.Completed,
                "incomplete" => ProgramOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}