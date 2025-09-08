
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeBetaResponseCreateParamsConversation
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaResponseCreateParamsConversationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaResponseCreateParamsConversation value)
        {
            return value switch
            {
                RealtimeBetaResponseCreateParamsConversation.Auto => "auto",
                RealtimeBetaResponseCreateParamsConversation.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaResponseCreateParamsConversation? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeBetaResponseCreateParamsConversation.Auto,
                "none" => RealtimeBetaResponseCreateParamsConversation.None,
                _ => null,
            };
        }
    }
}