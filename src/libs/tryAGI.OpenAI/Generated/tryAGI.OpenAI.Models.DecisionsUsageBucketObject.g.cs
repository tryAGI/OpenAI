
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: bucket
    /// </summary>
    public enum DecisionsUsageBucketObject
    {
        /// <summary>
        ///
        /// </summary>
        Bucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsUsageBucketObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsUsageBucketObject value)
        {
            return value switch
            {
                DecisionsUsageBucketObject.Bucket => "bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsUsageBucketObject? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => DecisionsUsageBucketObject.Bucket,
                _ => null,
            };
        }
    }
}