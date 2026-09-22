
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The order in which paginated resources are returned.
    /// </summary>
    public enum ListOrderParam
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListOrderParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListOrderParam value)
        {
            return value switch
            {
                ListOrderParam.Asc => "asc",
                ListOrderParam.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListOrderParam? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListOrderParam.Asc,
                "desc" => ListOrderParam.Desc,
                _ => null,
            };
        }
    }
}