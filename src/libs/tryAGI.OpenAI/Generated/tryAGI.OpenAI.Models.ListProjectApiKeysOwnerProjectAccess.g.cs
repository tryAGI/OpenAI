
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListProjectApiKeysOwnerProjectAccess
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectApiKeysOwnerProjectAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectApiKeysOwnerProjectAccess value)
        {
            return value switch
            {
                ListProjectApiKeysOwnerProjectAccess.Active => "active",
                ListProjectApiKeysOwnerProjectAccess.Any => "any",
                ListProjectApiKeysOwnerProjectAccess.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectApiKeysOwnerProjectAccess? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListProjectApiKeysOwnerProjectAccess.Active,
                "any" => ListProjectApiKeysOwnerProjectAccess.Any,
                "inactive" => ListProjectApiKeysOwnerProjectAccess.Inactive,
                _ => null,
            };
        }
    }
}