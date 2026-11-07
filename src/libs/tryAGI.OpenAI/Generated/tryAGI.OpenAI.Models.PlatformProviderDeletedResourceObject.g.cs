
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: organization.workload_identity_provider.deleted
    /// </summary>
    public enum PlatformProviderDeletedResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        OrganizationWorkloadIdentityProviderDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlatformProviderDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlatformProviderDeletedResourceObject value)
        {
            return value switch
            {
                PlatformProviderDeletedResourceObject.OrganizationWorkloadIdentityProviderDeleted => "organization.workload_identity_provider.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlatformProviderDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.workload_identity_provider.deleted" => PlatformProviderDeletedResourceObject.OrganizationWorkloadIdentityProviderDeleted,
                _ => null,
            };
        }
    }
}