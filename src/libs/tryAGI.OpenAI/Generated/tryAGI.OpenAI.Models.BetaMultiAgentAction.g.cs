
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaMultiAgentAction
    {
        /// <summary>
        ///
        /// </summary>
        FollowupTask,
        /// <summary>
        ///
        /// </summary>
        InterruptAgent,
        /// <summary>
        ///
        /// </summary>
        ListAgents,
        /// <summary>
        ///
        /// </summary>
        SendMessage,
        /// <summary>
        ///
        /// </summary>
        SpawnAgent,
        /// <summary>
        ///
        /// </summary>
        WaitAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMultiAgentActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMultiAgentAction value)
        {
            return value switch
            {
                BetaMultiAgentAction.FollowupTask => "followup_task",
                BetaMultiAgentAction.InterruptAgent => "interrupt_agent",
                BetaMultiAgentAction.ListAgents => "list_agents",
                BetaMultiAgentAction.SendMessage => "send_message",
                BetaMultiAgentAction.SpawnAgent => "spawn_agent",
                BetaMultiAgentAction.WaitAgent => "wait_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMultiAgentAction? ToEnum(string value)
        {
            return value switch
            {
                "followup_task" => BetaMultiAgentAction.FollowupTask,
                "interrupt_agent" => BetaMultiAgentAction.InterruptAgent,
                "list_agents" => BetaMultiAgentAction.ListAgents,
                "send_message" => BetaMultiAgentAction.SendMessage,
                "spawn_agent" => BetaMultiAgentAction.SpawnAgent,
                "wait_agent" => BetaMultiAgentAction.WaitAgent,
                _ => null,
            };
        }
    }
}