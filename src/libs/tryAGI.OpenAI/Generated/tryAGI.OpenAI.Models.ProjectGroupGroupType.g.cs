
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the group.
    /// </summary>
    public enum ProjectGroupGroupType
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
    public static class ProjectGroupGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectGroupGroupType value)
        {
            return value switch
            {
                ProjectGroupGroupType.Group => "group",
                ProjectGroupGroupType.TenantGroup => "tenant_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectGroupGroupType? ToEnum(string value)
        {
            return value switch
            {
                "group" => ProjectGroupGroupType.Group,
                "tenant_group" => ProjectGroupGroupType.TenantGroup,
                _ => null,
            };
        }
    }
}