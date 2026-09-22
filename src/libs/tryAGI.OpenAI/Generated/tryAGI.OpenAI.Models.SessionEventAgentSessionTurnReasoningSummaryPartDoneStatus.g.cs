
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Present as `incomplete` when summary generation was interrupted.
    /// </summary>
    public enum SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus
    {
        /// <summary>
        ///
        /// </summary>
        Incomplete,
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnReasoningSummaryPartDoneStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus.Incomplete => "incomplete",
                SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus? ToEnum(string value)
        {
            return value switch
            {
                "incomplete" => SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus.Incomplete,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}