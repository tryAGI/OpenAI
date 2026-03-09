
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `chatkit.thread.deleted`.<br/>
    /// Default Value: chatkit.thread.deleted
    /// </summary>
    public enum DeletedThreadResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitThreadDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedThreadResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedThreadResourceObject value)
        {
            return value switch
            {
                DeletedThreadResourceObject.ChatkitThreadDeleted => "chatkit.thread.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedThreadResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.thread.deleted" => DeletedThreadResourceObject.ChatkitThreadDeleted,
                _ => null,
            };
        }
    }
}