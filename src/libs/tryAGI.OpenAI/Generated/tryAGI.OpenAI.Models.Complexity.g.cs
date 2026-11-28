
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Computation spent planning the image, independently of rendering quality. Uses the image model's configured default when omitted. For SVG output, controls the reference image, independently of the SVG author's reasoning.
    /// </summary>
    public enum Complexity
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
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComplexityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Complexity value)
        {
            return value switch
            {
                Complexity.High => "high",
                Complexity.Low => "low",
                Complexity.Medium => "medium",
                Complexity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Complexity? ToEnum(string value)
        {
            return value switch
            {
                "high" => Complexity.High,
                "low" => Complexity.Low,
                "medium" => Complexity.Medium,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => Complexity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}