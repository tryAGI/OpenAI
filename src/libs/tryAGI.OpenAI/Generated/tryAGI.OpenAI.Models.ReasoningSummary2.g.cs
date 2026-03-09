
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A summary of the reasoning performed by the model. This can be<br/>
    /// useful for debugging and understanding the model's reasoning process.<br/>
    /// One of `auto`, `concise`, or `detailed`.<br/>
    /// `concise` is supported for `computer-use-preview` models and all reasoning models after `gpt-5`.
    /// </summary>
    public enum ReasoningSummary2
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
    public static class ReasoningSummary2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningSummary2 value)
        {
            return value switch
            {
                ReasoningSummary2.Auto => "auto",
                ReasoningSummary2.Concise => "concise",
                ReasoningSummary2.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningSummary2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ReasoningSummary2.Auto,
                "concise" => ReasoningSummary2.Concise,
                "detailed" => ReasoningSummary2.Detailed,
                _ => null,
            };
        }
    }
}