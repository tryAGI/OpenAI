
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The completion status of the summary part. Omitted when the part completed<br/>
    /// normally and set to `incomplete` when generation was interrupted.
    /// </summary>
    public enum ResponseReasoningSummaryPartDoneEventStatus
    {
        /// <summary>
        ///
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningSummaryPartDoneEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningSummaryPartDoneEventStatus value)
        {
            return value switch
            {
                ResponseReasoningSummaryPartDoneEventStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningSummaryPartDoneEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "incomplete" => ResponseReasoningSummaryPartDoneEventStatus.Incomplete,
                _ => null,
            };
        }
    }
}