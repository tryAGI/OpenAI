
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The amount of text the model should produce.
    /// </summary>
    public enum VerbosityParam
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
    public static class VerbosityParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VerbosityParam value)
        {
            return value switch
            {
                VerbosityParam.High => "high",
                VerbosityParam.Low => "low",
                VerbosityParam.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VerbosityParam? ToEnum(string value)
        {
            return value switch
            {
                "high" => VerbosityParam.High,
                "low" => VerbosityParam.Low,
                "medium" => VerbosityParam.Medium,
                _ => null,
            };
        }
    }
}