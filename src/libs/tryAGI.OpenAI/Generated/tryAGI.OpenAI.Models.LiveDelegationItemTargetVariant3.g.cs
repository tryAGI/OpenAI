
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: decisions
    /// </summary>
    public enum LiveDelegationItemTargetVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Decisions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDelegationItemTargetVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDelegationItemTargetVariant3 value)
        {
            return value switch
            {
                LiveDelegationItemTargetVariant3.Decisions => "decisions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDelegationItemTargetVariant3? ToEnum(string value)
        {
            return value switch
            {
                "decisions" => LiveDelegationItemTargetVariant3.Decisions,
                _ => null,
            };
        }
    }
}