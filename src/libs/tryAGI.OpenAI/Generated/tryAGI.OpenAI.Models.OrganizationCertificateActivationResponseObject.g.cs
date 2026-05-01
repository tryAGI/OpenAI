
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The organization certificate activation result type.
    /// </summary>
    public enum OrganizationCertificateActivationResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationCertificateActivation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationCertificateActivationResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationCertificateActivationResponseObject value)
        {
            return value switch
            {
                OrganizationCertificateActivationResponseObject.OrganizationCertificateActivation => "organization.certificate.activation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationCertificateActivationResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.certificate.activation" => OrganizationCertificateActivationResponseObject.OrganizationCertificateActivation,
                _ => null,
            };
        }
    }
}