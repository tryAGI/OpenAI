
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Legacy response format parameter for retired image models. Unsupported for GPT image models, which always return base64-encoded images.
    /// </summary>
    public enum CreateImageEditRequestResponseFormat
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
    public static class CreateImageEditRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestResponseFormat value)
        {
            return value switch
            {
                CreateImageEditRequestResponseFormat.B64Json => "b64_json",
                CreateImageEditRequestResponseFormat.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                CreateImageEditRequestResponseFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "b64_json" => CreateImageEditRequestResponseFormat.B64Json,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => CreateImageEditRequestResponseFormat.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "url" => CreateImageEditRequestResponseFormat.Url,
                _ => null,
            };
        }
    }
}