
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageFileSearchCallsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKeyId,
        /// <summary>
        /// 
        /// </summary>
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        UserId,
        /// <summary>
        /// 
        /// </summary>
        VectorStoreId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageFileSearchCallsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageFileSearchCallsGroupByItem value)
        {
            return value switch
            {
                UsageFileSearchCallsGroupByItem.ApiKeyId => "api_key_id",
                UsageFileSearchCallsGroupByItem.ProjectId => "project_id",
                UsageFileSearchCallsGroupByItem.UserId => "user_id",
                UsageFileSearchCallsGroupByItem.VectorStoreId => "vector_store_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageFileSearchCallsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "api_key_id" => UsageFileSearchCallsGroupByItem.ApiKeyId,
                "project_id" => UsageFileSearchCallsGroupByItem.ProjectId,
                "user_id" => UsageFileSearchCallsGroupByItem.UserId,
                "vector_store_id" => UsageFileSearchCallsGroupByItem.VectorStoreId,
                _ => null,
            };
        }
    }
}