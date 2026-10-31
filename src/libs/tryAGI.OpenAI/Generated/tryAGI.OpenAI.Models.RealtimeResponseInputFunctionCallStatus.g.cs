
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: completed
    /// </summary>
    public enum RealtimeResponseInputFunctionCallStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
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
    public static class RealtimeResponseInputFunctionCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputFunctionCallStatus value)
        {
            return value switch
            {
                RealtimeResponseInputFunctionCallStatus.Completed => "completed",
                RealtimeResponseInputFunctionCallStatus.Incomplete => "incomplete",
                RealtimeResponseInputFunctionCallStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputFunctionCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeResponseInputFunctionCallStatus.Completed,
                "incomplete" => RealtimeResponseInputFunctionCallStatus.Incomplete,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => RealtimeResponseInputFunctionCallStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}