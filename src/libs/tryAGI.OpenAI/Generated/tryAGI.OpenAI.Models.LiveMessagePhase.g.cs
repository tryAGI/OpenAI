
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveMessagePhase
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
    public static class LiveMessagePhaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveMessagePhase value)
        {
            return value switch
            {
                LiveMessagePhase.Commentary => "commentary",
                LiveMessagePhase.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveMessagePhase? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => LiveMessagePhase.Commentary,
                "final_answer" => LiveMessagePhase.FinalAnswer,
                _ => null,
            };
        }
    }
}