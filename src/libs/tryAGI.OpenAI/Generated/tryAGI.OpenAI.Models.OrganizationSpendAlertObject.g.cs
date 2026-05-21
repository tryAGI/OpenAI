
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `organization.spend_alert`.
    /// </summary>
    public enum OrganizationSpendAlertObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationSpendAlert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationSpendAlertObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationSpendAlertObject value)
        {
            return value switch
            {
                OrganizationSpendAlertObject.OrganizationSpendAlert => "organization.spend_alert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationSpendAlertObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.spend_alert" => OrganizationSpendAlertObject.OrganizationSpendAlert,
                _ => null,
            };
        }
    }
}