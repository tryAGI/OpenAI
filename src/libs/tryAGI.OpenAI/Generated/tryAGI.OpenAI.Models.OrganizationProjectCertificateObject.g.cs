
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `organization.project.certificate`.
    /// </summary>
    public enum OrganizationProjectCertificateObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationProjectCertificate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationProjectCertificateObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectCertificateObject value)
        {
            return value switch
            {
                OrganizationProjectCertificateObject.OrganizationProjectCertificate => "organization.project.certificate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectCertificateObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.certificate" => OrganizationProjectCertificateObject.OrganizationProjectCertificate,
                _ => null,
            };
        }
    }
}