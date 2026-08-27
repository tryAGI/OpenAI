
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls which reasoning items are rendered back to the model on later turns.<br/>
    /// If omitted or set to `auto`, the model determines the context mode. The<br/>
    /// `gpt-5.6` model family defaults to `all_turns`; earlier models default to<br/>
    /// `current_turn`.<br/>
    /// When returned on a response, this is the effective reasoning context mode<br/>
    /// used for the response.
    /// </summary>
    public enum BetaReasoningContext2
    {
        /// <summary>
        ///
        /// </summary>
        AllTurns,
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        CurrentTurn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaReasoningContext2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningContext2 value)
        {
            return value switch
            {
                BetaReasoningContext2.AllTurns => "all_turns",
                BetaReasoningContext2.Auto => "auto",
                BetaReasoningContext2.CurrentTurn => "current_turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningContext2? ToEnum(string value)
        {
            return value switch
            {
                "all_turns" => BetaReasoningContext2.AllTurns,
                "auto" => BetaReasoningContext2.Auto,
                "current_turn" => BetaReasoningContext2.CurrentTurn,
                _ => null,
            };
        }
    }
}