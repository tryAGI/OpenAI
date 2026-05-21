
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The configured organization data retention type.
    /// </summary>
    public enum OrganizationDataRetentionType
    {
        /// <summary>
        /// 
        /// </summary>
        EnhancedModifiedAbuseMonitoring,
        /// <summary>
        /// 
        /// </summary>
        EnhancedZeroDataRetention,
        /// <summary>
        /// 
        /// </summary>
        ModifiedAbuseMonitoring,
        /// <summary>
        /// 
        /// </summary>
        ZeroDataRetention,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationDataRetentionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationDataRetentionType value)
        {
            return value switch
            {
                OrganizationDataRetentionType.EnhancedModifiedAbuseMonitoring => "enhanced_modified_abuse_monitoring",
                OrganizationDataRetentionType.EnhancedZeroDataRetention => "enhanced_zero_data_retention",
                OrganizationDataRetentionType.ModifiedAbuseMonitoring => "modified_abuse_monitoring",
                OrganizationDataRetentionType.ZeroDataRetention => "zero_data_retention",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationDataRetentionType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced_modified_abuse_monitoring" => OrganizationDataRetentionType.EnhancedModifiedAbuseMonitoring,
                "enhanced_zero_data_retention" => OrganizationDataRetentionType.EnhancedZeroDataRetention,
                "modified_abuse_monitoring" => OrganizationDataRetentionType.ModifiedAbuseMonitoring,
                "zero_data_retention" => OrganizationDataRetentionType.ZeroDataRetention,
                _ => null,
            };
        }
    }
}