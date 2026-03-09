
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `group`.
    /// </summary>
    public enum GroupObject
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupObject value)
        {
            return value switch
            {
                GroupObject.Group => "group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupObject? ToEnum(string value)
        {
            return value switch
            {
                "group" => GroupObject.Group,
                _ => null,
            };
        }
    }
}