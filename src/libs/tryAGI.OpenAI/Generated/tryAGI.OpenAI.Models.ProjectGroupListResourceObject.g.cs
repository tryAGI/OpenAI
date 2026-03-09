
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `list`.
    /// </summary>
    public enum ProjectGroupListResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectGroupListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectGroupListResourceObject value)
        {
            return value switch
            {
                ProjectGroupListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectGroupListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ProjectGroupListResourceObject.List,
                _ => null,
            };
        }
    }
}