
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `group.user`.
    /// </summary>
    public enum GroupUserAssignmentObject
    {
        /// <summary>
        /// 
        /// </summary>
        GroupUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupUserAssignmentObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupUserAssignmentObject value)
        {
            return value switch
            {
                GroupUserAssignmentObject.GroupUser => "group.user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupUserAssignmentObject? ToEnum(string value)
        {
            return value switch
            {
                "group.user" => GroupUserAssignmentObject.GroupUser,
                _ => null,
            };
        }
    }
}