
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.delegation.created`.<br/>
    /// Default Value: session.delegation.created
    /// </summary>
    public enum LiveDelegationCreatedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionDelegationCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDelegationCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDelegationCreatedType value)
        {
            return value switch
            {
                LiveDelegationCreatedType.SessionDelegationCreated => "session.delegation.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDelegationCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.delegation.created" => LiveDelegationCreatedType.SessionDelegationCreated,
                _ => null,
            };
        }
    }
}