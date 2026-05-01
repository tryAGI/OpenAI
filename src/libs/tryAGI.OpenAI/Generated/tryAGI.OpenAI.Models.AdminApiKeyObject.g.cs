
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `organization.admin_api_key`
    /// </summary>
    public enum AdminApiKeyObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationAdminApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminApiKeyObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminApiKeyObject value)
        {
            return value switch
            {
                AdminApiKeyObject.OrganizationAdminApiKey => "organization.admin_api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminApiKeyObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.admin_api_key" => AdminApiKeyObject.OrganizationAdminApiKey,
                _ => null,
            };
        }
    }
}