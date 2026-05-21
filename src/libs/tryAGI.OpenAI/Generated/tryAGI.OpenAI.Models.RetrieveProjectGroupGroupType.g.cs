
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: group
    /// </summary>
    public enum RetrieveProjectGroupGroupType
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
    public static class RetrieveProjectGroupGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrieveProjectGroupGroupType value)
        {
            return value switch
            {
                RetrieveProjectGroupGroupType.Group => "group",
                RetrieveProjectGroupGroupType.TenantGroup => "tenant_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrieveProjectGroupGroupType? ToEnum(string value)
        {
            return value switch
            {
                "group" => RetrieveProjectGroupGroupType.Group,
                "tenant_group" => RetrieveProjectGroupGroupType.TenantGroup,
                _ => null,
            };
        }
    }
}