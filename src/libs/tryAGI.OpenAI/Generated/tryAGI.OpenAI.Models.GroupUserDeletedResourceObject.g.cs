
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `group.user.deleted`.
    /// </summary>
    public enum GroupUserDeletedResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        GroupUserDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupUserDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupUserDeletedResourceObject value)
        {
            return value switch
            {
                GroupUserDeletedResourceObject.GroupUserDeleted => "group.user.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupUserDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "group.user.deleted" => GroupUserDeletedResourceObject.GroupUserDeleted,
                _ => null,
            };
        }
    }
}