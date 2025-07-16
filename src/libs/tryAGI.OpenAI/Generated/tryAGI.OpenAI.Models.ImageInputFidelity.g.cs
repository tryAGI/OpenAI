
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Control how much effort the model will exert to match the style and features,<br/>
    /// especially facial features, of input images. This parameter is only supported<br/>
    /// for `gpt-image-1`. Supports `high` and `low`. Defaults to `low`.<br/>
    /// Default Value: low
    /// </summary>
    public enum ImageInputFidelity
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageInputFidelityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageInputFidelity value)
        {
            return value switch
            {
                ImageInputFidelity.High => "high",
                ImageInputFidelity.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageInputFidelity? ToEnum(string value)
        {
            return value switch
            {
                "high" => ImageInputFidelity.High,
                "low" => ImageInputFidelity.Low,
                _ => null,
            };
        }
    }
}