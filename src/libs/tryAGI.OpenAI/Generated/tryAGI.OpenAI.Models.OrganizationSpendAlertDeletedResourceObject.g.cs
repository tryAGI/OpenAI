
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `organization.spend_alert.deleted`.
    /// </summary>
    public enum OrganizationSpendAlertDeletedResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationSpendAlertDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationSpendAlertDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationSpendAlertDeletedResourceObject value)
        {
            return value switch
            {
                OrganizationSpendAlertDeletedResourceObject.OrganizationSpendAlertDeleted => "organization.spend_alert.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationSpendAlertDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.spend_alert.deleted" => OrganizationSpendAlertDeletedResourceObject.OrganizationSpendAlertDeleted,
                _ => null,
            };
        }
    }
}