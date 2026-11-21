
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum ListPlatformworkloadidentityprovidersOrderVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPlatformworkloadidentityprovidersOrderVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPlatformworkloadidentityprovidersOrderVariant1 value)
        {
            return value switch
            {
                ListPlatformworkloadidentityprovidersOrderVariant1.Asc => "asc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPlatformworkloadidentityprovidersOrderVariant1? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListPlatformworkloadidentityprovidersOrderVariant1.Asc,
                _ => null,
            };
        }
    }
}