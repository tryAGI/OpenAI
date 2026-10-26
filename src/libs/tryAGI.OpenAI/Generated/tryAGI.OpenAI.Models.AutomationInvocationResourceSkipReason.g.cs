
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Why an occurrence was skipped, or null when it was not skipped.<br/>
    /// Default Value: pending_delivery
    /// </summary>
    public enum AutomationInvocationResourceSkipReason
    {
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        ///
        /// </summary>
        PendingDelivery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationInvocationResourceSkipReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationInvocationResourceSkipReason value)
        {
            return value switch
            {
                AutomationInvocationResourceSkipReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                AutomationInvocationResourceSkipReason.PendingDelivery => "pending_delivery",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationInvocationResourceSkipReason? ToEnum(string value)
        {
            return value switch
            {
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => AutomationInvocationResourceSkipReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "pending_delivery" => AutomationInvocationResourceSkipReason.PendingDelivery,
                _ => null,
            };
        }
    }
}