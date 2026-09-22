
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ExternalStorageOrder
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
    public static class ExternalStorageOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalStorageOrder value)
        {
            return value switch
            {
                ExternalStorageOrder.Asc => "asc",
                ExternalStorageOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalStorageOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ExternalStorageOrder.Asc,
                "desc" => ExternalStorageOrder.Desc,
                _ => null,
            };
        }
    }
}