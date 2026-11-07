
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeResponseInputImageDetail
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputImageDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputImageDetail value)
        {
            return value switch
            {
                RealtimeResponseInputImageDetail.Auto => "auto",
                RealtimeResponseInputImageDetail.High => "high",
                RealtimeResponseInputImageDetail.Low => "low",
                RealtimeResponseInputImageDetail.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputImageDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeResponseInputImageDetail.Auto,
                "high" => RealtimeResponseInputImageDetail.High,
                "low" => RealtimeResponseInputImageDetail.Low,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => RealtimeResponseInputImageDetail.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}