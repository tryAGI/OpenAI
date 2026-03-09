
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Status values reported for apply_patch tool calls.
    /// </summary>
    public enum ApplyPatchCallStatusParam
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
    public static class ApplyPatchCallStatusParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallStatusParam value)
        {
            return value switch
            {
                ApplyPatchCallStatusParam.InProgress => "in_progress",
                ApplyPatchCallStatusParam.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallStatusParam? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ApplyPatchCallStatusParam.InProgress,
                "completed" => ApplyPatchCallStatusParam.Completed,
                _ => null,
            };
        }
    }
}