
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The desired organization data retention type.
    /// </summary>
    public enum UpdateOrganizationDataRetentionBodyRetentionType
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
    public static class UpdateOrganizationDataRetentionBodyRetentionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateOrganizationDataRetentionBodyRetentionType value)
        {
            return value switch
            {
                UpdateOrganizationDataRetentionBodyRetentionType.EnhancedModifiedAbuseMonitoring => "enhanced_modified_abuse_monitoring",
                UpdateOrganizationDataRetentionBodyRetentionType.EnhancedZeroDataRetention => "enhanced_zero_data_retention",
                UpdateOrganizationDataRetentionBodyRetentionType.ModifiedAbuseMonitoring => "modified_abuse_monitoring",
                UpdateOrganizationDataRetentionBodyRetentionType.ZeroDataRetention => "zero_data_retention",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateOrganizationDataRetentionBodyRetentionType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced_modified_abuse_monitoring" => UpdateOrganizationDataRetentionBodyRetentionType.EnhancedModifiedAbuseMonitoring,
                "enhanced_zero_data_retention" => UpdateOrganizationDataRetentionBodyRetentionType.EnhancedZeroDataRetention,
                "modified_abuse_monitoring" => UpdateOrganizationDataRetentionBodyRetentionType.ModifiedAbuseMonitoring,
                "zero_data_retention" => UpdateOrganizationDataRetentionBodyRetentionType.ZeroDataRetention,
                _ => null,
            };
        }
    }
}