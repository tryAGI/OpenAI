
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionTurnItemResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AgentMessage,
        /// <summary>
        ///
        /// </summary>
        CloseSubagentCall,
        /// <summary>
        ///
        /// </summary>
        CommandExecution,
        /// <summary>
        ///
        /// </summary>
        CreateSubagentCall,
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
        /// <summary>
        ///
        /// </summary>
        InterruptSubagentCall,
        /// <summary>
        ///
        /// </summary>
        McpCall,
        /// <summary>
        ///
        /// </summary>
        Message,
        /// <summary>
        ///
        /// </summary>
        Reasoning,
        /// <summary>
        ///
        /// </summary>
        ResumeSubagentCall,
        /// <summary>
        ///
        /// </summary>
        SendSubagentInputCall,
        /// <summary>
        ///
        /// </summary>
        WaitForSubagentsCall,
        /// <summary>
        ///
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionTurnItemResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionTurnItemResourceDiscriminatorType value)
        {
            return value switch
            {
                SessionTurnItemResourceDiscriminatorType.AgentMessage => "agent_message",
                SessionTurnItemResourceDiscriminatorType.CloseSubagentCall => "close_subagent_call",
                SessionTurnItemResourceDiscriminatorType.CommandExecution => "command_execution",
                SessionTurnItemResourceDiscriminatorType.CreateSubagentCall => "create_subagent_call",
                SessionTurnItemResourceDiscriminatorType.FunctionCall => "function_call",
                SessionTurnItemResourceDiscriminatorType.FunctionCallOutput => "function_call_output",
                SessionTurnItemResourceDiscriminatorType.InterruptSubagentCall => "interrupt_subagent_call",
                SessionTurnItemResourceDiscriminatorType.McpCall => "mcp_call",
                SessionTurnItemResourceDiscriminatorType.Message => "message",
                SessionTurnItemResourceDiscriminatorType.Reasoning => "reasoning",
                SessionTurnItemResourceDiscriminatorType.ResumeSubagentCall => "resume_subagent_call",
                SessionTurnItemResourceDiscriminatorType.SendSubagentInputCall => "send_subagent_input_call",
                SessionTurnItemResourceDiscriminatorType.WaitForSubagentsCall => "wait_for_subagents_call",
                SessionTurnItemResourceDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionTurnItemResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent_message" => SessionTurnItemResourceDiscriminatorType.AgentMessage,
                "close_subagent_call" => SessionTurnItemResourceDiscriminatorType.CloseSubagentCall,
                "command_execution" => SessionTurnItemResourceDiscriminatorType.CommandExecution,
                "create_subagent_call" => SessionTurnItemResourceDiscriminatorType.CreateSubagentCall,
                "function_call" => SessionTurnItemResourceDiscriminatorType.FunctionCall,
                "function_call_output" => SessionTurnItemResourceDiscriminatorType.FunctionCallOutput,
                "interrupt_subagent_call" => SessionTurnItemResourceDiscriminatorType.InterruptSubagentCall,
                "mcp_call" => SessionTurnItemResourceDiscriminatorType.McpCall,
                "message" => SessionTurnItemResourceDiscriminatorType.Message,
                "reasoning" => SessionTurnItemResourceDiscriminatorType.Reasoning,
                "resume_subagent_call" => SessionTurnItemResourceDiscriminatorType.ResumeSubagentCall,
                "send_subagent_input_call" => SessionTurnItemResourceDiscriminatorType.SendSubagentInputCall,
                "wait_for_subagents_call" => SessionTurnItemResourceDiscriminatorType.WaitForSubagentsCall,
                "web_search_call" => SessionTurnItemResourceDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}