
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: list
    /// </summary>
    public enum ListExternalKeysResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListExternalKeysResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExternalKeysResourceObject value)
        {
            return value switch
            {
                ListExternalKeysResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExternalKeysResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListExternalKeysResourceObject.List,
                _ => null,
            };
        }
    }
}