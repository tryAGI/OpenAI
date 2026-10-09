
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type. Always `agent.environment.expired`.
    /// </summary>
    public enum WebhookAgentEnvironmentExpiredVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AgentEnvironmentExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAgentEnvironmentExpiredVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAgentEnvironmentExpiredVariant2Type value)
        {
            return value switch
            {
                WebhookAgentEnvironmentExpiredVariant2Type.AgentEnvironmentExpired => "agent.environment.expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAgentEnvironmentExpiredVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent.environment.expired" => WebhookAgentEnvironmentExpiredVariant2Type.AgentEnvironmentExpired,
                _ => null,
            };
        }
    }
}