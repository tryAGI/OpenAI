
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaApplyPatchCallStatus
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
    public static class BetaApplyPatchCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApplyPatchCallStatus value)
        {
            return value switch
            {
                BetaApplyPatchCallStatus.Completed => "completed",
                BetaApplyPatchCallStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApplyPatchCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BetaApplyPatchCallStatus.Completed,
                "in_progress" => BetaApplyPatchCallStatus.InProgress,
                _ => null,
            };
        }
    }
}