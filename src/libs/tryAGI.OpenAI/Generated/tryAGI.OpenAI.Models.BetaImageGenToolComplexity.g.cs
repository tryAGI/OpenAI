
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Computation spent planning the image, independently of rendering quality.<br/>
    /// Overrides the outer response's `reasoning.effort` for image generation.<br/>
    /// When omitted, inherits a supported outer reasoning effort or uses the<br/>
    /// image model's configured default.<br/>
    /// For SVG output, controls the reference image, not the SVG author's<br/>
    /// reasoning.
    /// </summary>
    public enum BetaImageGenToolComplexity
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
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageGenToolComplexityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolComplexity value)
        {
            return value switch
            {
                BetaImageGenToolComplexity.High => "high",
                BetaImageGenToolComplexity.Low => "low",
                BetaImageGenToolComplexity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolComplexity? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaImageGenToolComplexity.High,
                "low" => BetaImageGenToolComplexity.Low,
                "medium" => BetaImageGenToolComplexity.Medium,
                _ => null,
            };
        }
    }
}