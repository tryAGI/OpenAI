
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Outcome values reported for apply_patch tool call outputs.
    /// </summary>
    public enum ApplyPatchCallOutputStatusParam
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
    public static class ApplyPatchCallOutputStatusParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplyPatchCallOutputStatusParam value)
        {
            return value switch
            {
                ApplyPatchCallOutputStatusParam.Completed => "completed",
                ApplyPatchCallOutputStatusParam.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplyPatchCallOutputStatusParam? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ApplyPatchCallOutputStatusParam.Completed,
                "failed" => ApplyPatchCallOutputStatusParam.Failed,
                _ => null,
            };
        }
    }
}