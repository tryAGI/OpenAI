
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Optional input status. Omission or null defaults to completed.<br/>
    /// Default Value: completed
    /// </summary>
    public enum RealtimeResponseInputMessageFieldsStatus
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
    public static class RealtimeResponseInputMessageFieldsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputMessageFieldsStatus value)
        {
            return value switch
            {
                RealtimeResponseInputMessageFieldsStatus.Completed => "completed",
                RealtimeResponseInputMessageFieldsStatus.Incomplete => "incomplete",
                RealtimeResponseInputMessageFieldsStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputMessageFieldsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeResponseInputMessageFieldsStatus.Completed,
                "incomplete" => RealtimeResponseInputMessageFieldsStatus.Incomplete,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => RealtimeResponseInputMessageFieldsStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}