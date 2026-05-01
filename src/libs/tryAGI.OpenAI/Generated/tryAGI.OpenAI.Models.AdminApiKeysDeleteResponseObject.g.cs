
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Example: organization.admin_api_key.deleted
    /// </summary>
    public enum AdminApiKeysDeleteResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationAdminApiKeyDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminApiKeysDeleteResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminApiKeysDeleteResponseObject value)
        {
            return value switch
            {
                AdminApiKeysDeleteResponseObject.OrganizationAdminApiKeyDeleted => "organization.admin_api_key.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminApiKeysDeleteResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.admin_api_key.deleted" => AdminApiKeysDeleteResponseObject.OrganizationAdminApiKeyDeleted,
                _ => null,
            };
        }
    }
}