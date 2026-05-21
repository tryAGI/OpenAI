
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageWebSearchCallsResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageWebSearchesResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageWebSearchCallsResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageWebSearchCallsResultObject value)
        {
            return value switch
            {
                UsageWebSearchCallsResultObject.OrganizationUsageWebSearchesResult => "organization.usage.web_searches.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageWebSearchCallsResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.web_searches.result" => UsageWebSearchCallsResultObject.OrganizationUsageWebSearchesResult,
                _ => null,
            };
        }
    }
}