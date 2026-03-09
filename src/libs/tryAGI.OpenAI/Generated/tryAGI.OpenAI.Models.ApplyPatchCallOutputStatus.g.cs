
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplyPatchCallOutputStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplyPatchCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOutputStatus value)
        {
            return value switch
            {
                ApplyPatchCallOutputStatus.Completed => "completed",
                ApplyPatchCallOutputStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ApplyPatchCallOutputStatus.Completed,
                "failed" => ApplyPatchCallOutputStatus.Failed,
                _ => null,
            };
        }
    }
}