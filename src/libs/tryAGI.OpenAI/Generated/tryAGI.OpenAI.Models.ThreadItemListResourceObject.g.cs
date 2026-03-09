
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of object returned, must be `list`.<br/>
    /// Default Value: list
    /// </summary>
    public enum ThreadItemListResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadItemListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadItemListResourceObject value)
        {
            return value switch
            {
                ThreadItemListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadItemListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ThreadItemListResourceObject.List,
                _ => null,
            };
        }
    }
}