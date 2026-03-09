
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Control how much effort the model will exert to match the style and features, especially facial features, of input images. This parameter is only supported for `gpt-image-1` and `gpt-image-1.5` and later models, unsupported for `gpt-image-1-mini`. Supports `high` and `low`. Defaults to `low`.
    /// </summary>
    public enum InputFidelity
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
    public static class InputFidelityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFidelity value)
        {
            return value switch
            {
                InputFidelity.High => "high",
                InputFidelity.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFidelity? ToEnum(string value)
        {
            return value switch
            {
                "high" => InputFidelity.High,
                "low" => InputFidelity.Low,
                _ => null,
            };
        }
    }
}