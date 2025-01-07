
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.<br/>
    /// Default Value: url<br/>
    /// Example: url
    /// </summary>
    public enum CreateImageEditRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        B64Json,
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
                CreateImageEditRequestResponseFormat.Url => "url",
                CreateImageEditRequestResponseFormat.B64Json => "b64_json",
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
                "url" => CreateImageEditRequestResponseFormat.Url,
                "b64_json" => CreateImageEditRequestResponseFormat.B64Json,
                _ => null,
            };
        }
    }
}