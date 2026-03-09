
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `chatkit.session`.<br/>
    /// Default Value: chatkit.session
    /// </summary>
    public enum ChatSessionResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatSessionResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSessionResourceObject value)
        {
            return value switch
            {
                ChatSessionResourceObject.ChatkitSession => "chatkit.session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSessionResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.session" => ChatSessionResourceObject.ChatkitSession,
                _ => null,
            };
        }
    }
}