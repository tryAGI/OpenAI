
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Why the service paused this schedule, or null for other schedules.<br/>
    /// Default Value: target_session_failed
    /// </summary>
    public enum AutomationResourceOncePauseReason
    {
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        ///
        /// </summary>
        TargetSessionFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationResourceOncePauseReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationResourceOncePauseReason value)
        {
            return value switch
            {
                AutomationResourceOncePauseReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                AutomationResourceOncePauseReason.TargetSessionFailed => "target_session_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationResourceOncePauseReason? ToEnum(string value)
        {
            return value switch
            {
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => AutomationResourceOncePauseReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "target_session_failed" => AutomationResourceOncePauseReason.TargetSessionFailed,
                _ => null,
            };
        }
    }
}