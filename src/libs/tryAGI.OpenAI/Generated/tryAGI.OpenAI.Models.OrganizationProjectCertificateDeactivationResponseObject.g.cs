
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The project certificate deactivation result type.
    /// </summary>
    public enum OrganizationProjectCertificateDeactivationResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationProjectCertificateDeactivation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationProjectCertificateDeactivationResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectCertificateDeactivationResponseObject value)
        {
            return value switch
            {
                OrganizationProjectCertificateDeactivationResponseObject.OrganizationProjectCertificateDeactivation => "organization.project.certificate.deactivation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectCertificateDeactivationResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.certificate.deactivation" => OrganizationProjectCertificateDeactivationResponseObject.OrganizationProjectCertificateDeactivation,
                _ => null,
            };
        }
    }
}