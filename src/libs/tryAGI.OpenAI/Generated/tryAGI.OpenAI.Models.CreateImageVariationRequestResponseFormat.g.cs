
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.<br/>
    /// Default Value: url<br/>
    /// Example: url
    /// </summary>
    public enum CreateImageVariationRequestResponseFormat
    {
        /// <summary>
        ///
        /// </summary>
        B64Json,
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageVariationRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageVariationRequestResponseFormat value)
        {
            return value switch
            {
                CreateImageVariationRequestResponseFormat.B64Json => "b64_json",
                CreateImageVariationRequestResponseFormat.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                CreateImageVariationRequestResponseFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageVariationRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "b64_json" => CreateImageVariationRequestResponseFormat.B64Json,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => CreateImageVariationRequestResponseFormat.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "url" => CreateImageVariationRequestResponseFormat.Url,
                _ => null,
            };
        }
    }
}