
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The organization certificate deactivation result type.
    /// </summary>
    public enum OrganizationCertificateDeactivationResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationCertificateDeactivation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationCertificateDeactivationResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationCertificateDeactivationResponseObject value)
        {
            return value switch
            {
                OrganizationCertificateDeactivationResponseObject.OrganizationCertificateDeactivation => "organization.certificate.deactivation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationCertificateDeactivationResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.certificate.deactivation" => OrganizationCertificateDeactivationResponseObject.OrganizationCertificateDeactivation,
                _ => null,
            };
        }
    }
}