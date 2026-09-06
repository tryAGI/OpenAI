
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaMessagePhase2
    {
        /// <summary>
        ///
        /// </summary>
        Commentary,
        /// <summary>
        ///
        /// </summary>
        FinalAnswer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessagePhase2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessagePhase2 value)
        {
            return value switch
            {
                BetaMessagePhase2.Commentary => "commentary",
                BetaMessagePhase2.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessagePhase2? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => BetaMessagePhase2.Commentary,
                "final_answer" => BetaMessagePhase2.FinalAnswer,
                _ => null,
            };
        }
    }
}