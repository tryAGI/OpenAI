
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls which reasoning items are rendered back to the model on later turns.<br/>
    /// When returned on a response, this is the effective reasoning context mode<br/>
    /// used for the response.
    /// </summary>
    public enum ReasoningContext2
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
    public static class ReasoningContext2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningContext2 value)
        {
            return value switch
            {
                ReasoningContext2.AllTurns => "all_turns",
                ReasoningContext2.Auto => "auto",
                ReasoningContext2.CurrentTurn => "current_turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningContext2? ToEnum(string value)
        {
            return value switch
            {
                "all_turns" => ReasoningContext2.AllTurns,
                "auto" => ReasoningContext2.Auto,
                "current_turn" => ReasoningContext2.CurrentTurn,
                _ => null,
            };
        }
    }
}