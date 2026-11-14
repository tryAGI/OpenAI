
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: organization.workload_identity_federation_rule.deleted
    /// </summary>
    public enum PlatformFederationRuleDeletedResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        OrganizationWorkloadIdentityFederationRuleDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlatformFederationRuleDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlatformFederationRuleDeletedResourceObject value)
        {
            return value switch
            {
                PlatformFederationRuleDeletedResourceObject.OrganizationWorkloadIdentityFederationRuleDeleted => "organization.workload_identity_federation_rule.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlatformFederationRuleDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.workload_identity_federation_rule.deleted" => PlatformFederationRuleDeletedResourceObject.OrganizationWorkloadIdentityFederationRuleDeleted,
                _ => null,
            };
        }
    }
}