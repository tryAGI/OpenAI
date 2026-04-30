
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageCostsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKeyId,
        /// <summary>
        /// 
        /// </summary>
        LineItem,
        /// <summary>
        /// 
        /// </summary>
        ProjectId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageCostsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCostsGroupByItem value)
        {
            return value switch
            {
                UsageCostsGroupByItem.ApiKeyId => "api_key_id",
                UsageCostsGroupByItem.LineItem => "line_item",
                UsageCostsGroupByItem.ProjectId => "project_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCostsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "api_key_id" => UsageCostsGroupByItem.ApiKeyId,
                "line_item" => UsageCostsGroupByItem.LineItem,
                "project_id" => UsageCostsGroupByItem.ProjectId,
                _ => null,
            };
        }
    }
}