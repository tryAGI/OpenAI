
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `organization.data_retention`.
    /// </summary>
    public enum OrganizationDataRetentionObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationDataRetention,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationDataRetentionObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationDataRetentionObject value)
        {
            return value switch
            {
                OrganizationDataRetentionObject.OrganizationDataRetention => "organization.data_retention",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationDataRetentionObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.data_retention" => OrganizationDataRetentionObject.OrganizationDataRetention,
                _ => null,
            };
        }
    }
}