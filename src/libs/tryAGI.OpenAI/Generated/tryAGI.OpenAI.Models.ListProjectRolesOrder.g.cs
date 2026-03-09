
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum ListProjectRolesOrder
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
    public static class ListProjectRolesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectRolesOrder value)
        {
            return value switch
            {
                ListProjectRolesOrder.Asc => "asc",
                ListProjectRolesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectRolesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListProjectRolesOrder.Asc,
                "desc" => ListProjectRolesOrder.Desc,
                _ => null,
            };
        }
    }
}