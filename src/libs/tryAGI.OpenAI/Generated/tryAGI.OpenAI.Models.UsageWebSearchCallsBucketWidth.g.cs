
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    public enum UsageWebSearchCallsBucketWidth
    {
        /// <summary>
        /// 
        /// </summary>
        x1d,
        /// <summary>
        /// 
        /// </summary>
        x1h,
        /// <summary>
        /// 
        /// </summary>
        x1m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageWebSearchCallsBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageWebSearchCallsBucketWidth value)
        {
            return value switch
            {
                UsageWebSearchCallsBucketWidth.x1d => "1d",
                UsageWebSearchCallsBucketWidth.x1h => "1h",
                UsageWebSearchCallsBucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageWebSearchCallsBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => UsageWebSearchCallsBucketWidth.x1d,
                "1h" => UsageWebSearchCallsBucketWidth.x1h,
                "1m" => UsageWebSearchCallsBucketWidth.x1m,
                _ => null,
            };
        }
    }
}