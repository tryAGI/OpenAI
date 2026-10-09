
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type. Always `agent.environment.ready`.
    /// </summary>
    public enum WebhookAgentEnvironmentReadyVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AgentEnvironmentReady,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAgentEnvironmentReadyVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAgentEnvironmentReadyVariant2Type value)
        {
            return value switch
            {
                WebhookAgentEnvironmentReadyVariant2Type.AgentEnvironmentReady => "agent.environment.ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAgentEnvironmentReadyVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent.environment.ready" => WebhookAgentEnvironmentReadyVariant2Type.AgentEnvironmentReady,
                _ => null,
            };
        }
    }
}