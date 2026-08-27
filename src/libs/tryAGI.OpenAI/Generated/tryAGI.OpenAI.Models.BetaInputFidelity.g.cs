
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Control how much effort the model will exert to match the style and features, especially facial features, of input images. This parameter is only supported for `gpt-image-1` and `gpt-image-1.5` and later models, unsupported for `gpt-image-1-mini`. Supports `high` and `low`. Defaults to `low`.
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