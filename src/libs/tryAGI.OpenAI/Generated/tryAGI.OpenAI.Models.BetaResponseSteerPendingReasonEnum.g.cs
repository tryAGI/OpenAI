
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseSteerPendingReasonEnum
    {
        /// <summary>
        ///
        /// </summary>
        WaitingForRequiredInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerPendingReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerPendingReasonEnum value)
        {
            return value switch
            {
                BetaResponseSteerPendingReasonEnum.WaitingForRequiredInput => "waiting_for_required_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerPendingReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "waiting_for_required_input" => BetaResponseSteerPendingReasonEnum.WaitingForRequiredInput,
                _ => null,
            };
        }
    }
}