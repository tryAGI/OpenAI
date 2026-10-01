
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type. Always `agent.session.idle`.
    /// </summary>
    public enum WebhookAgentSessionIdleVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionIdle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAgentSessionIdleVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAgentSessionIdleVariant2Type value)
        {
            return value switch
            {
                WebhookAgentSessionIdleVariant2Type.AgentSessionIdle => "agent.session.idle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAgentSessionIdleVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.idle" => WebhookAgentSessionIdleVariant2Type.AgentSessionIdle,
                _ => null,
            };
        }
    }
}