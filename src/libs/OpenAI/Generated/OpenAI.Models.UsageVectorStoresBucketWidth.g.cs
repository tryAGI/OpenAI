
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    public enum UsageVectorStoresBucketWidth
    {
        /// <summary>
        /// 
        /// </summary>
        x1m,
        /// <summary>
        /// 
        /// </summary>
        x1h,
        /// <summary>
        /// 
        /// </summary>
        x1d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageVectorStoresBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageVectorStoresBucketWidth value)
        {
            return value switch
            {
                UsageVectorStoresBucketWidth.x1m => "1m",
                UsageVectorStoresBucketWidth.x1h => "1h",
                UsageVectorStoresBucketWidth.x1d => "1d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageVectorStoresBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1m" => UsageVectorStoresBucketWidth.x1m,
                "1h" => UsageVectorStoresBucketWidth.x1h,
                "1d" => UsageVectorStoresBucketWidth.x1d,
                _ => null,
            };
        }
    }
}