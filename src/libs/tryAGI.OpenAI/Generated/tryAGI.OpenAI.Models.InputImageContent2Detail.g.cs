
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
    /// </summary>
    public enum InputImageContent2Detail
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
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
    public static class InputImageContent2DetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputImageContent2Detail value)
        {
            return value switch
            {
                InputImageContent2Detail.Low => "low",
                InputImageContent2Detail.High => "high",
                InputImageContent2Detail.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputImageContent2Detail? ToEnum(string value)
        {
            return value switch
            {
                "low" => InputImageContent2Detail.Low,
                "high" => InputImageContent2Detail.High,
                "auto" => InputImageContent2Detail.Auto,
                _ => null,
            };
        }
    }
}