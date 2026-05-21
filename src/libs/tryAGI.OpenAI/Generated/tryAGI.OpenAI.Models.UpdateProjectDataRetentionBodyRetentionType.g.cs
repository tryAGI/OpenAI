
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The desired project data retention type.
    /// </summary>
    public enum UpdateProjectDataRetentionBodyRetentionType
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
        None,
        /// <summary>
        /// 
        /// </summary>
        OrganizationDefault,
        /// <summary>
        /// 
        /// </summary>
        ZeroDataRetention,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectDataRetentionBodyRetentionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectDataRetentionBodyRetentionType value)
        {
            return value switch
            {
                UpdateProjectDataRetentionBodyRetentionType.EnhancedModifiedAbuseMonitoring => "enhanced_modified_abuse_monitoring",
                UpdateProjectDataRetentionBodyRetentionType.EnhancedZeroDataRetention => "enhanced_zero_data_retention",
                UpdateProjectDataRetentionBodyRetentionType.ModifiedAbuseMonitoring => "modified_abuse_monitoring",
                UpdateProjectDataRetentionBodyRetentionType.None => "none",
                UpdateProjectDataRetentionBodyRetentionType.OrganizationDefault => "organization_default",
                UpdateProjectDataRetentionBodyRetentionType.ZeroDataRetention => "zero_data_retention",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectDataRetentionBodyRetentionType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced_modified_abuse_monitoring" => UpdateProjectDataRetentionBodyRetentionType.EnhancedModifiedAbuseMonitoring,
                "enhanced_zero_data_retention" => UpdateProjectDataRetentionBodyRetentionType.EnhancedZeroDataRetention,
                "modified_abuse_monitoring" => UpdateProjectDataRetentionBodyRetentionType.ModifiedAbuseMonitoring,
                "none" => UpdateProjectDataRetentionBodyRetentionType.None,
                "organization_default" => UpdateProjectDataRetentionBodyRetentionType.OrganizationDefault,
                "zero_data_retention" => UpdateProjectDataRetentionBodyRetentionType.ZeroDataRetention,
                _ => null,
            };
        }
    }
}