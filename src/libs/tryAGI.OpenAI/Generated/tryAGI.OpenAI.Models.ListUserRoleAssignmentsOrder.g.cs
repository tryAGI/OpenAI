
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListUserRoleAssignmentsOrder
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
    public static class ListUserRoleAssignmentsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListUserRoleAssignmentsOrder value)
        {
            return value switch
            {
                ListUserRoleAssignmentsOrder.Asc => "asc",
                ListUserRoleAssignmentsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListUserRoleAssignmentsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListUserRoleAssignmentsOrder.Asc,
                "desc" => ListUserRoleAssignmentsOrder.Desc,
                _ => null,
            };
        }
    }
}