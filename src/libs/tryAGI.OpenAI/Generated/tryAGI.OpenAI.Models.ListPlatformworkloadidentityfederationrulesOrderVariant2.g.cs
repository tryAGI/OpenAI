
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListPlatformworkloadidentityfederationrulesOrderVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPlatformworkloadidentityfederationrulesOrderVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPlatformworkloadidentityfederationrulesOrderVariant2 value)
        {
            return value switch
            {
                ListPlatformworkloadidentityfederationrulesOrderVariant2.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPlatformworkloadidentityfederationrulesOrderVariant2? ToEnum(string value)
        {
            return value switch
            {
                "desc" => ListPlatformworkloadidentityfederationrulesOrderVariant2.Desc,
                _ => null,
            };
        }
    }
}