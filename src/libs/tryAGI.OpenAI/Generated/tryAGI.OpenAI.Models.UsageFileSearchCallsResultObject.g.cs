
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageFileSearchCallsResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageFileSearchesResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageFileSearchCallsResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageFileSearchCallsResultObject value)
        {
            return value switch
            {
                UsageFileSearchCallsResultObject.OrganizationUsageFileSearchesResult => "organization.usage.file_searches.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageFileSearchCallsResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.file_searches.result" => UsageFileSearchCallsResultObject.OrganizationUsageFileSearchesResult,
                _ => null,
            };
        }
    }
}