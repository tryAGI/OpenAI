
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: organization.workload_identity_provider
    /// </summary>
    public enum PlatformProviderObject
    {
        /// <summary>
        ///
        /// </summary>
        OrganizationWorkloadIdentityProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlatformProviderObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlatformProviderObject value)
        {
            return value switch
            {
                PlatformProviderObject.OrganizationWorkloadIdentityProvider => "organization.workload_identity_provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlatformProviderObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.workload_identity_provider" => PlatformProviderObject.OrganizationWorkloadIdentityProvider,
                _ => null,
            };
        }
    }
}