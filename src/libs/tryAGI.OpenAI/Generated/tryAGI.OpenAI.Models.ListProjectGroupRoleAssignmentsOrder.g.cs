
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectGroupRoleAssignmentsOrder
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
    public static class ListProjectGroupRoleAssignmentsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectGroupRoleAssignmentsOrder value)
        {
            return value switch
            {
                ListProjectGroupRoleAssignmentsOrder.Asc => "asc",
                ListProjectGroupRoleAssignmentsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectGroupRoleAssignmentsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListProjectGroupRoleAssignmentsOrder.Asc,
                "desc" => ListProjectGroupRoleAssignmentsOrder.Desc,
                _ => null,
            };
        }
    }
}