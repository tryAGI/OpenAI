
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `role.deleted`.
    /// </summary>
    public enum RoleDeletedResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        RoleDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoleDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoleDeletedResourceObject value)
        {
            return value switch
            {
                RoleDeletedResourceObject.RoleDeleted => "role.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoleDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "role.deleted" => RoleDeletedResourceObject.RoleDeleted,
                _ => null,
            };
        }
    }
}