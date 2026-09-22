
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveTextVerbosity
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
    public static class LiveTextVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveTextVerbosity value)
        {
            return value switch
            {
                LiveTextVerbosity.High => "high",
                LiveTextVerbosity.Low => "low",
                LiveTextVerbosity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveTextVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "high" => LiveTextVerbosity.High,
                "low" => LiveTextVerbosity.Low,
                "medium" => LiveTextVerbosity.Medium,
                _ => null,
            };
        }
    }
}