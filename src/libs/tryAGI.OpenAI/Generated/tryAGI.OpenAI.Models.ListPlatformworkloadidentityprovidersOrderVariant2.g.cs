
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListPlatformworkloadidentityprovidersOrderVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPlatformworkloadidentityprovidersOrderVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPlatformworkloadidentityprovidersOrderVariant2 value)
        {
            return value switch
            {
                ListPlatformworkloadidentityprovidersOrderVariant2.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPlatformworkloadidentityprovidersOrderVariant2? ToEnum(string value)
        {
            return value switch
            {
                "desc" => ListPlatformworkloadidentityprovidersOrderVariant2.Desc,
                _ => null,
            };
        }
    }
}