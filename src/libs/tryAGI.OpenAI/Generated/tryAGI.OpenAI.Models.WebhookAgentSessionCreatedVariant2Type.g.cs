
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type. Always `agent.session.created`.
    /// </summary>
    public enum WebhookAgentSessionCreatedVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAgentSessionCreatedVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAgentSessionCreatedVariant2Type value)
        {
            return value switch
            {
                WebhookAgentSessionCreatedVariant2Type.AgentSessionCreated => "agent.session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAgentSessionCreatedVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.created" => WebhookAgentSessionCreatedVariant2Type.AgentSessionCreated,
                _ => null,
            };
        }
    }
}