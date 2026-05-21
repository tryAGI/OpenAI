
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the group.
    /// </summary>
    public enum GroupResponseGroupType
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
        /// <summary>
        /// 
        /// </summary>
        TenantGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupResponseGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupResponseGroupType value)
        {
            return value switch
            {
                GroupResponseGroupType.Group => "group",
                GroupResponseGroupType.TenantGroup => "tenant_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupResponseGroupType? ToEnum(string value)
        {
            return value switch
            {
                "group" => GroupResponseGroupType.Group,
                "tenant_group" => GroupResponseGroupType.TenantGroup,
                _ => null,
            };
        }
    }
}