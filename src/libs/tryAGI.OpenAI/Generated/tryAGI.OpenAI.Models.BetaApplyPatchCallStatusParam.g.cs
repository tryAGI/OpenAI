
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Status values reported for apply_patch tool calls.
    /// </summary>
    public enum BetaApplyPatchCallStatusParam
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaApplyPatchCallStatusParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchCallStatusParam value)
        {
            return value switch
            {
                BetaApplyPatchCallStatusParam.Completed => "completed",
                BetaApplyPatchCallStatusParam.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchCallStatusParam? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaApplyPatchCallStatusParam.Completed,
                "in_progress" => BetaApplyPatchCallStatusParam.InProgress,
                _ => null,
            };
        }
    }
}