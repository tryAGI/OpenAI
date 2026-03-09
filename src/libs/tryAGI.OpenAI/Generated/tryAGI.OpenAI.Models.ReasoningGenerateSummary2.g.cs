
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// **Deprecated:** use `summary` instead.<br/>
    /// A summary of the reasoning performed by the model. This can be<br/>
    /// useful for debugging and understanding the model's reasoning process.<br/>
    /// One of `auto`, `concise`, or `detailed`.
    /// </summary>
    public enum ReasoningGenerateSummary2
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
    public static class ReasoningGenerateSummary2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningGenerateSummary2 value)
        {
            return value switch
            {
                ReasoningGenerateSummary2.Auto => "auto",
                ReasoningGenerateSummary2.Concise => "concise",
                ReasoningGenerateSummary2.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningGenerateSummary2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ReasoningGenerateSummary2.Auto,
                "concise" => ReasoningGenerateSummary2.Concise,
                "detailed" => ReasoningGenerateSummary2.Detailed,
                _ => null,
            };
        }
    }
}