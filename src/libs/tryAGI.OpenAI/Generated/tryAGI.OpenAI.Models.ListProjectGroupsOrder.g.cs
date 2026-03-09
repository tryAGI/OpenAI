
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum ListProjectGroupsOrder
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
    public static class ListProjectGroupsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectGroupsOrder value)
        {
            return value switch
            {
                ListProjectGroupsOrder.Asc => "asc",
                ListProjectGroupsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectGroupsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListProjectGroupsOrder.Asc,
                "desc" => ListProjectGroupsOrder.Desc,
                _ => null,
            };
        }
    }
}