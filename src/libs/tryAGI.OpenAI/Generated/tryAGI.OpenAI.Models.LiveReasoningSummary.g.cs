
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveReasoningSummary
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
    public static class LiveReasoningSummaryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveReasoningSummary value)
        {
            return value switch
            {
                LiveReasoningSummary.Auto => "auto",
                LiveReasoningSummary.Concise => "concise",
                LiveReasoningSummary.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveReasoningSummary? ToEnum(string value)
        {
            return value switch
            {
                "auto" => LiveReasoningSummary.Auto,
                "concise" => LiveReasoningSummary.Concise,
                "detailed" => LiveReasoningSummary.Detailed,
                _ => null,
            };
        }
    }
}