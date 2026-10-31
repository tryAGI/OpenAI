
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: completed
    /// </summary>
    public enum RealtimeResponseInputFunctionCallOutputStatus
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
    public static class RealtimeResponseInputFunctionCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputFunctionCallOutputStatus value)
        {
            return value switch
            {
                RealtimeResponseInputFunctionCallOutputStatus.Completed => "completed",
                RealtimeResponseInputFunctionCallOutputStatus.Incomplete => "incomplete",
                RealtimeResponseInputFunctionCallOutputStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputFunctionCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeResponseInputFunctionCallOutputStatus.Completed,
                "incomplete" => RealtimeResponseInputFunctionCallOutputStatus.Incomplete,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => RealtimeResponseInputFunctionCallOutputStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}