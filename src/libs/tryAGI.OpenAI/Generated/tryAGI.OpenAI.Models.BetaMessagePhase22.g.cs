
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaMessagePhase22
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
    public static class BetaMessagePhase22Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessagePhase22 value)
        {
            return value switch
            {
                BetaMessagePhase22.Commentary => "commentary",
                BetaMessagePhase22.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessagePhase22? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => BetaMessagePhase22.Commentary,
                "final_answer" => BetaMessagePhase22.FinalAnswer,
                _ => null,
            };
        }
    }
}