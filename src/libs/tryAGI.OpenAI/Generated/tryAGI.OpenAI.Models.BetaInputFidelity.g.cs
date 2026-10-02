
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Control how much effort the model will exert to match the style and features, especially facial features, of input images. Supports `high` and `low` on `gpt-image-1` and `gpt-image-1.5`; `gpt-image-1-mini` supports only `low`. For `gpt-image-2`, omit this parameter. Defaults to `low` on supported models.
    /// </summary>
    public enum BetaInputFidelity
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
    public static class BetaInputFidelityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputFidelity value)
        {
            return value switch
            {
                BetaInputFidelity.High => "high",
                BetaInputFidelity.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputFidelity? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaInputFidelity.High,
                "low" => BetaInputFidelity.Low,
                _ => null,
            };
        }
    }
}