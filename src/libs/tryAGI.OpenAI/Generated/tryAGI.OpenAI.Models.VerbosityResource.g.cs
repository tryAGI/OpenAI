
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The amount of text produced by an agent.
    /// </summary>
    public enum VerbosityResource
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
    public static class VerbosityResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VerbosityResource value)
        {
            return value switch
            {
                VerbosityResource.High => "high",
                VerbosityResource.Low => "low",
                VerbosityResource.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VerbosityResource? ToEnum(string value)
        {
            return value switch
            {
                "high" => VerbosityResource.High,
                "low" => VerbosityResource.Low,
                "medium" => VerbosityResource.Medium,
                _ => null,
            };
        }
    }
}