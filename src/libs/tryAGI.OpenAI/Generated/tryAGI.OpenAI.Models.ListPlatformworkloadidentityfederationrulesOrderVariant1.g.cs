
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum ListPlatformworkloadidentityfederationrulesOrderVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPlatformworkloadidentityfederationrulesOrderVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPlatformworkloadidentityfederationrulesOrderVariant1 value)
        {
            return value switch
            {
                ListPlatformworkloadidentityfederationrulesOrderVariant1.Asc => "asc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPlatformworkloadidentityfederationrulesOrderVariant1? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListPlatformworkloadidentityfederationrulesOrderVariant1.Asc,
                _ => null,
            };
        }
    }
}