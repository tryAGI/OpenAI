
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: organization.workload_identity_federation_rule
    /// </summary>
    public enum PlatformFederationRuleObject
    {
        /// <summary>
        ///
        /// </summary>
        OrganizationWorkloadIdentityFederationRule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlatformFederationRuleObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlatformFederationRuleObject value)
        {
            return value switch
            {
                PlatformFederationRuleObject.OrganizationWorkloadIdentityFederationRule => "organization.workload_identity_federation_rule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlatformFederationRuleObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.workload_identity_federation_rule" => PlatformFederationRuleObject.OrganizationWorkloadIdentityFederationRule,
                _ => null,
            };
        }
    }
}