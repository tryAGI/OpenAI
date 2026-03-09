
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Labels an `assistant` message as intermediate commentary (`commentary`) or the final answer (`final_answer`).<br/>
    /// For models like `gpt-5.3-codex` and beyond, when sending follow-up requests, preserve and resend<br/>
    /// phase on all assistant messages — dropping it can degrade performance. Not used for user messages.
    /// </summary>
    public enum MessagePhase
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
    public static class MessagePhaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagePhase value)
        {
            return value switch
            {
                MessagePhase.Commentary => "commentary",
                MessagePhase.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagePhase? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => MessagePhase.Commentary,
                "final_answer" => MessagePhase.FinalAnswer,
                _ => null,
            };
        }
    }
}