
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: organization.external_storage.deleted
    /// </summary>
    public enum ExternalStorageDeletedResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        OrganizationExternalStorageDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalStorageDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalStorageDeletedResourceObject value)
        {
            return value switch
            {
                ExternalStorageDeletedResourceObject.OrganizationExternalStorageDeleted => "organization.external_storage.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalStorageDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.external_storage.deleted" => ExternalStorageDeletedResourceObject.OrganizationExternalStorageDeleted,
                _ => null,
            };
        }
    }
}