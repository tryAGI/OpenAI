
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProgramOutputItemStatus
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
    public static class ProgramOutputItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProgramOutputItemStatus value)
        {
            return value switch
            {
                ProgramOutputItemStatus.Completed => "completed",
                ProgramOutputItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProgramOutputItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ProgramOutputItemStatus.Completed,
                "incomplete" => ProgramOutputItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}