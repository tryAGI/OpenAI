
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoModelEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Sora2,
        /// <summary>
        /// 
        /// </summary>
        Sora2Pro,
        /// <summary>
        /// 
        /// </summary>
        Sora220251006,
        /// <summary>
        /// 
        /// </summary>
        Sora2Pro20251006,
        /// <summary>
        /// 
        /// </summary>
        Sora220251208,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoModelEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoModelEnum value)
        {
            return value switch
            {
                VideoModelEnum.Sora2 => "sora-2",
                VideoModelEnum.Sora2Pro => "sora-2-pro",
                VideoModelEnum.Sora220251006 => "sora-2-2025-10-06",
                VideoModelEnum.Sora2Pro20251006 => "sora-2-pro-2025-10-06",
                VideoModelEnum.Sora220251208 => "sora-2-2025-12-08",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoModelEnum? ToEnum(string value)
        {
            return value switch
            {
                "sora-2" => VideoModelEnum.Sora2,
                "sora-2-pro" => VideoModelEnum.Sora2Pro,
                "sora-2-2025-10-06" => VideoModelEnum.Sora220251006,
                "sora-2-pro-2025-10-06" => VideoModelEnum.Sora2Pro20251006,
                "sora-2-2025-12-08" => VideoModelEnum.Sora220251208,
                _ => null,
            };
        }
    }
}