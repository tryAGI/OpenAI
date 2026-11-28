
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: list
    /// </summary>
    public enum PlatformFederationRuleListResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlatformFederationRuleListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlatformFederationRuleListResourceObject value)
        {
            return value switch
            {
                PlatformFederationRuleListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlatformFederationRuleListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => PlatformFederationRuleListResourceObject.List,
                _ => null,
            };
        }
    }
}