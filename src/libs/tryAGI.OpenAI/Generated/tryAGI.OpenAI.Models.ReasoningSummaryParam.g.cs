
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The reasoning summary format requested from the model.
    /// </summary>
    public enum ReasoningSummaryParam
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
    public static class ReasoningSummaryParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningSummaryParam value)
        {
            return value switch
            {
                ReasoningSummaryParam.Auto => "auto",
                ReasoningSummaryParam.Concise => "concise",
                ReasoningSummaryParam.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningSummaryParam? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ReasoningSummaryParam.Auto,
                "concise" => ReasoningSummaryParam.Concise,
                "detailed" => ReasoningSummaryParam.Detailed,
                _ => null,
            };
        }
    }
}