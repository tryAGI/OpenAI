
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `group.role`.
    /// </summary>
    public enum GroupRoleAssignmentObject
    {
        /// <summary>
        /// 
        /// </summary>
        GroupRole,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupRoleAssignmentObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupRoleAssignmentObject value)
        {
            return value switch
            {
                GroupRoleAssignmentObject.GroupRole => "group.role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupRoleAssignmentObject? ToEnum(string value)
        {
            return value switch
            {
                "group.role" => GroupRoleAssignmentObject.GroupRole,
                _ => null,
            };
        }
    }
}