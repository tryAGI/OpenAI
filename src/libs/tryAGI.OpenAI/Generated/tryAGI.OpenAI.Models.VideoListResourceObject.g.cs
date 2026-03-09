
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of object returned, must be `list`.<br/>
    /// Default Value: list
    /// </summary>
    public enum VideoListResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoListResourceObject value)
        {
            return value switch
            {
                VideoListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => VideoListResourceObject.List,
                _ => null,
            };
        }
    }
}