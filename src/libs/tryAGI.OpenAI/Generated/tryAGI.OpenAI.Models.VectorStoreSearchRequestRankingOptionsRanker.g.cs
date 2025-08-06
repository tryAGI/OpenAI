
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Enable re-ranking; set to `none` to disable, which can help reduce latency.<br/>
    /// Default Value: auto
    /// </summary>
    public enum VectorStoreSearchRequestRankingOptionsRanker
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Default20241115,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreSearchRequestRankingOptionsRankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreSearchRequestRankingOptionsRanker value)
        {
            return value switch
            {
                VectorStoreSearchRequestRankingOptionsRanker.None => "none",
                VectorStoreSearchRequestRankingOptionsRanker.Auto => "auto",
                VectorStoreSearchRequestRankingOptionsRanker.Default20241115 => "default-2024-11-15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreSearchRequestRankingOptionsRanker? ToEnum(string value)
        {
            return value switch
            {
                "none" => VectorStoreSearchRequestRankingOptionsRanker.None,
                "auto" => VectorStoreSearchRequestRankingOptionsRanker.Auto,
                "default-2024-11-15" => VectorStoreSearchRequestRankingOptionsRanker.Default20241115,
                _ => null,
            };
        }
    }
}