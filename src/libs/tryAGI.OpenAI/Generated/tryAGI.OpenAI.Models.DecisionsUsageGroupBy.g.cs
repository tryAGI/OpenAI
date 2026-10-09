
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsUsageGroupBy
    {
        /// <summary>
        ///
        /// </summary>
        ApiKeyId,
        /// <summary>
        ///
        /// </summary>
        ApiSource,
        /// <summary>
        ///
        /// </summary>
        Batch,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        ProjectId,
        /// <summary>
        ///
        /// </summary>
        ServiceTier,
        /// <summary>
        ///
        /// </summary>
        UserId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsUsageGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsUsageGroupBy value)
        {
            return value switch
            {
                DecisionsUsageGroupBy.ApiKeyId => "api_key_id",
                DecisionsUsageGroupBy.ApiSource => "api_source",
                DecisionsUsageGroupBy.Batch => "batch",
                DecisionsUsageGroupBy.Model => "model",
                DecisionsUsageGroupBy.ProjectId => "project_id",
                DecisionsUsageGroupBy.ServiceTier => "service_tier",
                DecisionsUsageGroupBy.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsUsageGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "api_key_id" => DecisionsUsageGroupBy.ApiKeyId,
                "api_source" => DecisionsUsageGroupBy.ApiSource,
                "batch" => DecisionsUsageGroupBy.Batch,
                "model" => DecisionsUsageGroupBy.Model,
                "project_id" => DecisionsUsageGroupBy.ProjectId,
                "service_tier" => DecisionsUsageGroupBy.ServiceTier,
                "user_id" => DecisionsUsageGroupBy.UserId,
                _ => null,
            };
        }
    }
}