
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `chatkit.thread`.<br/>
    /// Default Value: chatkit.thread
    /// </summary>
    public enum ThreadResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitThread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadResourceObject value)
        {
            return value switch
            {
                ThreadResourceObject.ChatkitThread => "chatkit.thread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.thread" => ThreadResourceObject.ChatkitThread,
                _ => null,
            };
        }
    }
}