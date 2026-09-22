
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: list
    /// </summary>
    public enum ExternalStorageListResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalStorageListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalStorageListResourceObject value)
        {
            return value switch
            {
                ExternalStorageListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalStorageListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ExternalStorageListResourceObject.List,
                _ => null,
            };
        }
    }
}