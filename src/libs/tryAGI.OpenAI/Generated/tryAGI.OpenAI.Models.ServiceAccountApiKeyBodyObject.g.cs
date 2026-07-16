
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `organization.project.service_account.api_key`<br/>
    /// Default Value: organization.project.service_account.api_key
    /// </summary>
    public enum ServiceAccountApiKeyBodyObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationProjectServiceAccountApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceAccountApiKeyBodyObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceAccountApiKeyBodyObject value)
        {
            return value switch
            {
                ServiceAccountApiKeyBodyObject.OrganizationProjectServiceAccountApiKey => "organization.project.service_account.api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceAccountApiKeyBodyObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.service_account.api_key" => ServiceAccountApiKeyBodyObject.OrganizationProjectServiceAccountApiKey,
                _ => null,
            };
        }
    }
}