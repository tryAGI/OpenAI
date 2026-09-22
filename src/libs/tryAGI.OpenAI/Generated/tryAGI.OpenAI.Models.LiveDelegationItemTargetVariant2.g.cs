
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: responses
    /// </summary>
    public enum LiveDelegationItemTargetVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Responses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDelegationItemTargetVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDelegationItemTargetVariant2 value)
        {
            return value switch
            {
                LiveDelegationItemTargetVariant2.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDelegationItemTargetVariant2? ToEnum(string value)
        {
            return value switch
            {
                "responses" => LiveDelegationItemTargetVariant2.Responses,
                _ => null,
            };
        }
    }
}