
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `video`.<br/>
    /// Default Value: video
    /// </summary>
    public enum VideoResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoResourceObject value)
        {
            return value switch
            {
                VideoResourceObject.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "video" => VideoResourceObject.Video,
                _ => null,
            };
        }
    }
}