
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type. Always `agent.session.in_progress`.
    /// </summary>
    public enum WebhookAgentSessionInProgressVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAgentSessionInProgressVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAgentSessionInProgressVariant2Type value)
        {
            return value switch
            {
                WebhookAgentSessionInProgressVariant2Type.AgentSessionInProgress => "agent.session.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAgentSessionInProgressVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.in_progress" => WebhookAgentSessionInProgressVariant2Type.AgentSessionInProgress,
                _ => null,
            };
        }
    }
}