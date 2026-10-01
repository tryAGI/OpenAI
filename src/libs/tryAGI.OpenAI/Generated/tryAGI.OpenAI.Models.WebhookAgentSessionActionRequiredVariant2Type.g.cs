
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type. Always `agent.session.action_required`.
    /// </summary>
    public enum WebhookAgentSessionActionRequiredVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionActionRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAgentSessionActionRequiredVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAgentSessionActionRequiredVariant2Type value)
        {
            return value switch
            {
                WebhookAgentSessionActionRequiredVariant2Type.AgentSessionActionRequired => "agent.session.action_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAgentSessionActionRequiredVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.action_required" => WebhookAgentSessionActionRequiredVariant2Type.AgentSessionActionRequired,
                _ => null,
            };
        }
    }
}