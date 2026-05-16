
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageWebSearchCallsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKeyId,
        /// <summary>
        /// 
        /// </summary>
        ContextLevel,
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
        UserId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageWebSearchCallsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageWebSearchCallsGroupByItem value)
        {
            return value switch
            {
                UsageWebSearchCallsGroupByItem.ApiKeyId => "api_key_id",
                UsageWebSearchCallsGroupByItem.ContextLevel => "context_level",
                UsageWebSearchCallsGroupByItem.Model => "model",
                UsageWebSearchCallsGroupByItem.ProjectId => "project_id",
                UsageWebSearchCallsGroupByItem.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageWebSearchCallsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "api_key_id" => UsageWebSearchCallsGroupByItem.ApiKeyId,
                "context_level" => UsageWebSearchCallsGroupByItem.ContextLevel,
                "model" => UsageWebSearchCallsGroupByItem.Model,
                "project_id" => UsageWebSearchCallsGroupByItem.ProjectId,
                "user_id" => UsageWebSearchCallsGroupByItem.UserId,
                _ => null,
            };
        }
    }
}