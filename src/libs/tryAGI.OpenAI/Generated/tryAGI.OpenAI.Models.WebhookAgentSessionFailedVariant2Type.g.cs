
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type. Always `agent.session.failed`.
    /// </summary>
    public enum WebhookAgentSessionFailedVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAgentSessionFailedVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAgentSessionFailedVariant2Type value)
        {
            return value switch
            {
                WebhookAgentSessionFailedVariant2Type.AgentSessionFailed => "agent.session.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAgentSessionFailedVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.failed" => WebhookAgentSessionFailedVariant2Type.AgentSessionFailed,
                _ => null,
            };
        }
    }
}