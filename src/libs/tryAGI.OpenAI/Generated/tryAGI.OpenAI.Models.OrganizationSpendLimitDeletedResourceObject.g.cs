
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `organization.spend_limit.deleted`.<br/>
    /// Default Value: organization.spend_limit.deleted
    /// </summary>
    public enum OrganizationSpendLimitDeletedResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationSpendLimitDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationSpendLimitDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationSpendLimitDeletedResourceObject value)
        {
            return value switch
            {
                OrganizationSpendLimitDeletedResourceObject.OrganizationSpendLimitDeleted => "organization.spend_limit.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationSpendLimitDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.spend_limit.deleted" => OrganizationSpendLimitDeletedResourceObject.OrganizationSpendLimitDeleted,
                _ => null,
            };
        }
    }
}