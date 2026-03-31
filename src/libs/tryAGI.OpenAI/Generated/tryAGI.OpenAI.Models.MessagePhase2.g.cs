
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagePhase2
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
    public static class MessagePhase2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagePhase2 value)
        {
            return value switch
            {
                MessagePhase2.Commentary => "commentary",
                MessagePhase2.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagePhase2? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => MessagePhase2.Commentary,
                "final_answer" => MessagePhase2.FinalAnswer,
                _ => null,
            };
        }
    }
}