
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Control how much effort the model will exert to match the style and features, especially facial features, of input images. Supports `high` and `low` on `gpt-image-1.5`; `gpt-image-1-mini` supports only `low`. For `gpt-image-2`, omit this parameter. Defaults to `low` on supported models.
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