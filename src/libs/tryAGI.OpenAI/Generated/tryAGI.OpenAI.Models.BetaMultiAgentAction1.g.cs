
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaMultiAgentAction1
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
    public static class BetaMultiAgentAction1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMultiAgentAction1 value)
        {
            return value switch
            {
                BetaMultiAgentAction1.FollowupTask => "followup_task",
                BetaMultiAgentAction1.InterruptAgent => "interrupt_agent",
                BetaMultiAgentAction1.ListAgents => "list_agents",
                BetaMultiAgentAction1.SendMessage => "send_message",
                BetaMultiAgentAction1.SpawnAgent => "spawn_agent",
                BetaMultiAgentAction1.WaitAgent => "wait_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMultiAgentAction1? ToEnum(string value)
        {
            return value switch
            {
                "followup_task" => BetaMultiAgentAction1.FollowupTask,
                "interrupt_agent" => BetaMultiAgentAction1.InterruptAgent,
                "list_agents" => BetaMultiAgentAction1.ListAgents,
                "send_message" => BetaMultiAgentAction1.SendMessage,
                "spawn_agent" => BetaMultiAgentAction1.SpawnAgent,
                "wait_agent" => BetaMultiAgentAction1.WaitAgent,
                _ => null,
            };
        }
    }
}