
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The reasoning summary format requested from an agent.
    /// </summary>
    public enum ReasoningSummaryResource
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Concise,
        /// <summary>
        ///
        /// </summary>
        Detailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningSummaryResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningSummaryResource value)
        {
            return value switch
            {
                ReasoningSummaryResource.Auto => "auto",
                ReasoningSummaryResource.Concise => "concise",
                ReasoningSummaryResource.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningSummaryResource? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ReasoningSummaryResource.Auto,
                "concise" => ReasoningSummaryResource.Concise,
                "detailed" => ReasoningSummaryResource.Detailed,
                _ => null,
            };
        }
    }
}