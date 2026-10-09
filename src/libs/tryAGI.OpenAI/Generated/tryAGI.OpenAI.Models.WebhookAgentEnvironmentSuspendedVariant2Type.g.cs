
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type. Always `agent.environment.suspended`.
    /// </summary>
    public enum WebhookAgentEnvironmentSuspendedVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AgentEnvironmentSuspended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAgentEnvironmentSuspendedVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAgentEnvironmentSuspendedVariant2Type value)
        {
            return value switch
            {
                WebhookAgentEnvironmentSuspendedVariant2Type.AgentEnvironmentSuspended => "agent.environment.suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAgentEnvironmentSuspendedVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent.environment.suspended" => WebhookAgentEnvironmentSuspendedVariant2Type.AgentEnvironmentSuspended,
                _ => null,
            };
        }
    }
}