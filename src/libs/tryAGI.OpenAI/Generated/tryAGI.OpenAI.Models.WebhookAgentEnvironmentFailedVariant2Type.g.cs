
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type. Always `agent.environment.failed`.
    /// </summary>
    public enum WebhookAgentEnvironmentFailedVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AgentEnvironmentFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAgentEnvironmentFailedVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAgentEnvironmentFailedVariant2Type value)
        {
            return value switch
            {
                WebhookAgentEnvironmentFailedVariant2Type.AgentEnvironmentFailed => "agent.environment.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAgentEnvironmentFailedVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent.environment.failed" => WebhookAgentEnvironmentFailedVariant2Type.AgentEnvironmentFailed,
                _ => null,
            };
        }
    }
}