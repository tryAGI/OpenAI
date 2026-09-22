
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The delegation owner. Always `client` for tasks handled by your application.<br/>
    /// Default Value: client
    /// </summary>
    public enum LiveClientDelegationParamType
    {
        /// <summary>
        ///
        /// </summary>
        Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveClientDelegationParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveClientDelegationParamType value)
        {
            return value switch
            {
                LiveClientDelegationParamType.Client => "client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveClientDelegationParamType? ToEnum(string value)
        {
            return value switch
            {
                "client" => LiveClientDelegationParamType.Client,
                _ => null,
            };
        }
    }
}