
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The project certificate activation result type.
    /// </summary>
    public enum OrganizationProjectCertificateActivationResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationProjectCertificateActivation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationProjectCertificateActivationResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationProjectCertificateActivationResponseObject value)
        {
            return value switch
            {
                OrganizationProjectCertificateActivationResponseObject.OrganizationProjectCertificateActivation => "organization.project.certificate.activation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationProjectCertificateActivationResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.certificate.activation" => OrganizationProjectCertificateActivationResponseObject.OrganizationProjectCertificateActivation,
                _ => null,
            };
        }
    }
}