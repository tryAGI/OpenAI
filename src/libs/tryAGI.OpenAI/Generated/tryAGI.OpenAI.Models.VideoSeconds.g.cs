
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoSeconds
    {
        /// <summary>
        /// 
        /// </summary>
        x4,
        /// <summary>
        /// 
        /// </summary>
        x8,
        /// <summary>
        /// 
        /// </summary>
        x12,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoSecondsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSeconds value)
        {
            return value switch
            {
                VideoSeconds.x4 => "4",
                VideoSeconds.x8 => "8",
                VideoSeconds.x12 => "12",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSeconds? ToEnum(string value)
        {
            return value switch
            {
                "4" => VideoSeconds.x4,
                "8" => VideoSeconds.x8,
                "12" => VideoSeconds.x12,
                _ => null,
            };
        }
    }
}