
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, always `delegation`.<br/>
    /// Default Value: delegation
    /// </summary>
    public enum LiveDelegationItemType
    {
        /// <summary>
        ///
        /// </summary>
        Delegation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDelegationItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDelegationItemType value)
        {
            return value switch
            {
                LiveDelegationItemType.Delegation => "delegation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDelegationItemType? ToEnum(string value)
        {
            return value switch
            {
                "delegation" => LiveDelegationItemType.Delegation,
                _ => null,
            };
        }
    }
}