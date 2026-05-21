
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum ListProjectSpendAlertsOrder
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
    public static class ListProjectSpendAlertsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectSpendAlertsOrder value)
        {
            return value switch
            {
                ListProjectSpendAlertsOrder.Asc => "asc",
                ListProjectSpendAlertsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectSpendAlertsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListProjectSpendAlertsOrder.Asc,
                "desc" => ListProjectSpendAlertsOrder.Desc,
                _ => null,
            };
        }
    }
}