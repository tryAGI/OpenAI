
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `organization.spend_limit`.<br/>
    /// Default Value: organization.spend_limit
    /// </summary>
    public enum OrganizationSpendLimitResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationSpendLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationSpendLimitResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationSpendLimitResourceObject value)
        {
            return value switch
            {
                OrganizationSpendLimitResourceObject.OrganizationSpendLimit => "organization.spend_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationSpendLimitResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.spend_limit" => OrganizationSpendLimitResourceObject.OrganizationSpendLimit,
                _ => null,
            };
        }
    }
}