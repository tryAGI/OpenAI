
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum ListOrganizationSpendAlertsOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListOrganizationSpendAlertsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListOrganizationSpendAlertsOrder value)
        {
            return value switch
            {
                ListOrganizationSpendAlertsOrder.Asc => "asc",
                ListOrganizationSpendAlertsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListOrganizationSpendAlertsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListOrganizationSpendAlertsOrder.Asc,
                "desc" => ListOrganizationSpendAlertsOrder.Desc,
                _ => null,
            };
        }
    }
}