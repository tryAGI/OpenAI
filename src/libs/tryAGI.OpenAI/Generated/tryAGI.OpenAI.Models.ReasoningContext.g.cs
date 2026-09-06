
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
    public enum ReasoningContext
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
    public static class ReasoningContextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningContext value)
        {
            return value switch
            {
                ReasoningContext.AllTurns => "all_turns",
                ReasoningContext.Auto => "auto",
                ReasoningContext.CurrentTurn => "current_turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningContext? ToEnum(string value)
        {
            return value switch
            {
                "all_turns" => ReasoningContext.AllTurns,
                "auto" => ReasoningContext.Auto,
                "current_turn" => ReasoningContext.CurrentTurn,
                _ => null,
            };
        }
    }
}