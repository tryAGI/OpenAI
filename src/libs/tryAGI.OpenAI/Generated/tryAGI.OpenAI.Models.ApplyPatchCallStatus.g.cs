
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallStatus value)
        {
            return value switch
            {
                ApplyPatchCallStatus.InProgress => "in_progress",
                ApplyPatchCallStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ApplyPatchCallStatus.InProgress,
                "completed" => ApplyPatchCallStatus.Completed,
                _ => null,
            };
        }
    }
}