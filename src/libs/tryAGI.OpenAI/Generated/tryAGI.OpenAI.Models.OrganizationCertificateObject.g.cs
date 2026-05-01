
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `organization.certificate`.
    /// </summary>
    public enum OrganizationCertificateObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationCertificate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationCertificateObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationCertificateObject value)
        {
            return value switch
            {
                OrganizationCertificateObject.OrganizationCertificate => "organization.certificate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationCertificateObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.certificate" => OrganizationCertificateObject.OrganizationCertificate,
                _ => null,
            };
        }
    }
}