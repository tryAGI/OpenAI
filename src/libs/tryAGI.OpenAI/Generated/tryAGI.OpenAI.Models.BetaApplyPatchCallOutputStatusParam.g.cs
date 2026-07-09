
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Outcome values reported for apply_patch tool call outputs.
    /// </summary>
    public enum BetaApplyPatchCallOutputStatusParam
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
    public static class BetaApplyPatchCallOutputStatusParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchCallOutputStatusParam value)
        {
            return value switch
            {
                BetaApplyPatchCallOutputStatusParam.Completed => "completed",
                BetaApplyPatchCallOutputStatusParam.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchCallOutputStatusParam? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaApplyPatchCallOutputStatusParam.Completed,
                "failed" => BetaApplyPatchCallOutputStatusParam.Failed,
                _ => null,
            };
        }
    }
}