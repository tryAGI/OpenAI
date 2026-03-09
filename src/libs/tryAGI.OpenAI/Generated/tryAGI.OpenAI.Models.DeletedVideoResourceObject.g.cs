
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type that signals the deletion response.<br/>
    /// Default Value: video.deleted
    /// </summary>
    public enum DeletedVideoResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        VideoDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedVideoResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedVideoResourceObject value)
        {
            return value switch
            {
                DeletedVideoResourceObject.VideoDeleted => "video.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedVideoResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "video.deleted" => DeletedVideoResourceObject.VideoDeleted,
                _ => null,
            };
        }
    }
}