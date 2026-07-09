
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaApplyPatchCallOutputStatus
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
    public static class BetaApplyPatchCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchCallOutputStatus value)
        {
            return value switch
            {
                BetaApplyPatchCallOutputStatus.Completed => "completed",
                BetaApplyPatchCallOutputStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaApplyPatchCallOutputStatus.Completed,
                "failed" => BetaApplyPatchCallOutputStatus.Failed,
                _ => null,
            };
        }
    }
}