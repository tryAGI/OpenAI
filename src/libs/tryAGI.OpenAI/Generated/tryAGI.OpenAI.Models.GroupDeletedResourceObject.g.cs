
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `group.deleted`.
    /// </summary>
    public enum GroupDeletedResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        GroupDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupDeletedResourceObject value)
        {
            return value switch
            {
                GroupDeletedResourceObject.GroupDeleted => "group.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "group.deleted" => GroupDeletedResourceObject.GroupDeleted,
                _ => null,
            };
        }
    }
}