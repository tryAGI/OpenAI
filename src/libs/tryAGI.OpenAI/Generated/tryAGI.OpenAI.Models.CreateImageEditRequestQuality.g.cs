
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The quality of the image that will be generated for GPT image models. Defaults to `auto`.<br/>
    /// Default Value: auto<br/>
    /// Example: high
    /// </summary>
    public enum CreateImageEditRequestQuality
    {
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageEditRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestQuality value)
        {
            return value switch
            {
                CreateImageEditRequestQuality.Standard => "standard",
                CreateImageEditRequestQuality.Low => "low",
                CreateImageEditRequestQuality.Medium => "medium",
                CreateImageEditRequestQuality.High => "high",
                CreateImageEditRequestQuality.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "standard" => CreateImageEditRequestQuality.Standard,
                "low" => CreateImageEditRequestQuality.Low,
                "medium" => CreateImageEditRequestQuality.Medium,
                "high" => CreateImageEditRequestQuality.High,
                "auto" => CreateImageEditRequestQuality.Auto,
                _ => null,
            };
        }
    }
}