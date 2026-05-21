
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The configured project data retention type.
    /// </summary>
    public enum ProjectDataRetentionType
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
    public static class ProjectDataRetentionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectDataRetentionType value)
        {
            return value switch
            {
                ProjectDataRetentionType.EnhancedModifiedAbuseMonitoring => "enhanced_modified_abuse_monitoring",
                ProjectDataRetentionType.EnhancedZeroDataRetention => "enhanced_zero_data_retention",
                ProjectDataRetentionType.ModifiedAbuseMonitoring => "modified_abuse_monitoring",
                ProjectDataRetentionType.None => "none",
                ProjectDataRetentionType.OrganizationDefault => "organization_default",
                ProjectDataRetentionType.ZeroDataRetention => "zero_data_retention",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectDataRetentionType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced_modified_abuse_monitoring" => ProjectDataRetentionType.EnhancedModifiedAbuseMonitoring,
                "enhanced_zero_data_retention" => ProjectDataRetentionType.EnhancedZeroDataRetention,
                "modified_abuse_monitoring" => ProjectDataRetentionType.ModifiedAbuseMonitoring,
                "none" => ProjectDataRetentionType.None,
                "organization_default" => ProjectDataRetentionType.OrganizationDefault,
                "zero_data_retention" => ProjectDataRetentionType.ZeroDataRetention,
                _ => null,
            };
        }
    }
}