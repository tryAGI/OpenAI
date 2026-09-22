
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: organization.external_storage
    /// </summary>
    public enum ExternalStorageResponseObject
    {
        /// <summary>
        ///
        /// </summary>
        OrganizationExternalStorage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalStorageResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalStorageResponseObject value)
        {
            return value switch
            {
                ExternalStorageResponseObject.OrganizationExternalStorage => "organization.external_storage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalStorageResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.external_storage" => ExternalStorageResponseObject.OrganizationExternalStorage,
                _ => null,
            };
        }
    }
}