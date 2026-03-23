
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalShellCallStatus
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
    public static class LocalShellCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellCallStatus value)
        {
            return value switch
            {
                LocalShellCallStatus.Completed => "completed",
                LocalShellCallStatus.InProgress => "in_progress",
                LocalShellCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => LocalShellCallStatus.Completed,
                "in_progress" => LocalShellCallStatus.InProgress,
                "incomplete" => LocalShellCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}