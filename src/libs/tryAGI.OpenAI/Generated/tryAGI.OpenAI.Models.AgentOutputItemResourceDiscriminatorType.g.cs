
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentOutputItemResourceDiscriminatorType
    {
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
    public static class AgentOutputItemResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentOutputItemResourceDiscriminatorType value)
        {
            return value switch
            {
                AgentOutputItemResourceDiscriminatorType.CloseSubagentCall => "close_subagent_call",
                AgentOutputItemResourceDiscriminatorType.CommandExecution => "command_execution",
                AgentOutputItemResourceDiscriminatorType.CreateSubagentCall => "create_subagent_call",
                AgentOutputItemResourceDiscriminatorType.FunctionCall => "function_call",
                AgentOutputItemResourceDiscriminatorType.InterruptSubagentCall => "interrupt_subagent_call",
                AgentOutputItemResourceDiscriminatorType.McpCall => "mcp_call",
                AgentOutputItemResourceDiscriminatorType.Message => "message",
                AgentOutputItemResourceDiscriminatorType.Reasoning => "reasoning",
                AgentOutputItemResourceDiscriminatorType.ResumeSubagentCall => "resume_subagent_call",
                AgentOutputItemResourceDiscriminatorType.SendSubagentInputCall => "send_subagent_input_call",
                AgentOutputItemResourceDiscriminatorType.WaitForSubagentsCall => "wait_for_subagents_call",
                AgentOutputItemResourceDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentOutputItemResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "close_subagent_call" => AgentOutputItemResourceDiscriminatorType.CloseSubagentCall,
                "command_execution" => AgentOutputItemResourceDiscriminatorType.CommandExecution,
                "create_subagent_call" => AgentOutputItemResourceDiscriminatorType.CreateSubagentCall,
                "function_call" => AgentOutputItemResourceDiscriminatorType.FunctionCall,
                "interrupt_subagent_call" => AgentOutputItemResourceDiscriminatorType.InterruptSubagentCall,
                "mcp_call" => AgentOutputItemResourceDiscriminatorType.McpCall,
                "message" => AgentOutputItemResourceDiscriminatorType.Message,
                "reasoning" => AgentOutputItemResourceDiscriminatorType.Reasoning,
                "resume_subagent_call" => AgentOutputItemResourceDiscriminatorType.ResumeSubagentCall,
                "send_subagent_input_call" => AgentOutputItemResourceDiscriminatorType.SendSubagentInputCall,
                "wait_for_subagents_call" => AgentOutputItemResourceDiscriminatorType.WaitForSubagentsCall,
                "web_search_call" => AgentOutputItemResourceDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}