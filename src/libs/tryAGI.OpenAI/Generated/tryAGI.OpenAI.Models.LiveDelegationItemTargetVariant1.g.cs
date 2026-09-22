
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: client
    /// </summary>
    public enum LiveDelegationItemTargetVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDelegationItemTargetVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDelegationItemTargetVariant1 value)
        {
            return value switch
            {
                LiveDelegationItemTargetVariant1.Client => "client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDelegationItemTargetVariant1? ToEnum(string value)
        {
            return value switch
            {
                "client" => LiveDelegationItemTargetVariant1.Client,
                _ => null,
            };
        }
    }
}