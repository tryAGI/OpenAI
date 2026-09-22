
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The phase of an assistant message.
    /// </summary>
    public enum MessagePhaseResource
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
    public static class MessagePhaseResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagePhaseResource value)
        {
            return value switch
            {
                MessagePhaseResource.Commentary => "commentary",
                MessagePhaseResource.FinalAnswer => "final_answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagePhaseResource? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => MessagePhaseResource.Commentary,
                "final_answer" => MessagePhaseResource.FinalAnswer,
                _ => null,
            };
        }
    }
}