
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The detail level of the image to be sent to the model. One of `high`,<br/>
    /// `low`, or `auto`. Defaults to `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum InputImageDetail
    {
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
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputImageDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputImageDetail value)
        {
            return value switch
            {
                InputImageDetail.High => "high",
                InputImageDetail.Low => "low",
                InputImageDetail.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputImageDetail? ToEnum(string value)
        {
            return value switch
            {
                "high" => InputImageDetail.High,
                "low" => InputImageDetail.Low,
                "auto" => InputImageDetail.Auto,
                _ => null,
            };
        }
    }
}