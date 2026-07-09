
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AdditionalTools,
        /// <summary>
        /// 
        /// </summary>
        AgentMessage,
        /// <summary>
        /// 
        /// </summary>
        ApplyPatchCall,
        /// <summary>
        /// 
        /// </summary>
        ApplyPatchCallOutput,
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreterCall,
        /// <summary>
        /// 
        /// </summary>
        Compaction,
        /// <summary>
        /// 
        /// </summary>
        ComputerCall,
        /// <summary>
        /// 
        /// </summary>
        ComputerCallOutput,
        /// <summary>
        /// 
        /// </summary>
        CustomToolCall,
        /// <summary>
        /// 
        /// </summary>
        CustomToolCallOutput,
        /// <summary>
        /// 
        /// </summary>
        FileSearchCall,
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
        ImageGenerationCall,
        /// <summary>
        /// 
        /// </summary>
        LocalShellCall,
        /// <summary>
        /// 
        /// </summary>
        LocalShellCallOutput,
        /// <summary>
        /// 
        /// </summary>
        McpApprovalRequest,
        /// <summary>
        /// 
        /// </summary>
        McpApprovalResponse,
        /// <summary>
        /// 
        /// </summary>
        McpCall,
        /// <summary>
        /// 
        /// </summary>
        McpListTools,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        MultiAgentCall,
        /// <summary>
        /// 
        /// </summary>
        MultiAgentCallOutput,
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        ShellCall,
        /// <summary>
        /// 
        /// </summary>
        ShellCallOutput,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchCall,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchOutput,
        /// <summary>
        /// 
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaItemDiscriminatorType value)
        {
            return value switch
            {
                BetaItemDiscriminatorType.AdditionalTools => "additional_tools",
                BetaItemDiscriminatorType.AgentMessage => "agent_message",
                BetaItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                BetaItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                BetaItemDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                BetaItemDiscriminatorType.Compaction => "compaction",
                BetaItemDiscriminatorType.ComputerCall => "computer_call",
                BetaItemDiscriminatorType.ComputerCallOutput => "computer_call_output",
                BetaItemDiscriminatorType.CustomToolCall => "custom_tool_call",
                BetaItemDiscriminatorType.CustomToolCallOutput => "custom_tool_call_output",
                BetaItemDiscriminatorType.FileSearchCall => "file_search_call",
                BetaItemDiscriminatorType.FunctionCall => "function_call",
                BetaItemDiscriminatorType.FunctionCallOutput => "function_call_output",
                BetaItemDiscriminatorType.ImageGenerationCall => "image_generation_call",
                BetaItemDiscriminatorType.LocalShellCall => "local_shell_call",
                BetaItemDiscriminatorType.LocalShellCallOutput => "local_shell_call_output",
                BetaItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                BetaItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                BetaItemDiscriminatorType.McpCall => "mcp_call",
                BetaItemDiscriminatorType.McpListTools => "mcp_list_tools",
                BetaItemDiscriminatorType.Message => "message",
                BetaItemDiscriminatorType.MultiAgentCall => "multi_agent_call",
                BetaItemDiscriminatorType.MultiAgentCallOutput => "multi_agent_call_output",
                BetaItemDiscriminatorType.Reasoning => "reasoning",
                BetaItemDiscriminatorType.ShellCall => "shell_call",
                BetaItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                BetaItemDiscriminatorType.ToolSearchCall => "tool_search_call",
                BetaItemDiscriminatorType.ToolSearchOutput => "tool_search_output",
                BetaItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => BetaItemDiscriminatorType.AdditionalTools,
                "agent_message" => BetaItemDiscriminatorType.AgentMessage,
                "apply_patch_call" => BetaItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => BetaItemDiscriminatorType.ApplyPatchCallOutput,
                "code_interpreter_call" => BetaItemDiscriminatorType.CodeInterpreterCall,
                "compaction" => BetaItemDiscriminatorType.Compaction,
                "computer_call" => BetaItemDiscriminatorType.ComputerCall,
                "computer_call_output" => BetaItemDiscriminatorType.ComputerCallOutput,
                "custom_tool_call" => BetaItemDiscriminatorType.CustomToolCall,
                "custom_tool_call_output" => BetaItemDiscriminatorType.CustomToolCallOutput,
                "file_search_call" => BetaItemDiscriminatorType.FileSearchCall,
                "function_call" => BetaItemDiscriminatorType.FunctionCall,
                "function_call_output" => BetaItemDiscriminatorType.FunctionCallOutput,
                "image_generation_call" => BetaItemDiscriminatorType.ImageGenerationCall,
                "local_shell_call" => BetaItemDiscriminatorType.LocalShellCall,
                "local_shell_call_output" => BetaItemDiscriminatorType.LocalShellCallOutput,
                "mcp_approval_request" => BetaItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => BetaItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => BetaItemDiscriminatorType.McpCall,
                "mcp_list_tools" => BetaItemDiscriminatorType.McpListTools,
                "message" => BetaItemDiscriminatorType.Message,
                "multi_agent_call" => BetaItemDiscriminatorType.MultiAgentCall,
                "multi_agent_call_output" => BetaItemDiscriminatorType.MultiAgentCallOutput,
                "reasoning" => BetaItemDiscriminatorType.Reasoning,
                "shell_call" => BetaItemDiscriminatorType.ShellCall,
                "shell_call_output" => BetaItemDiscriminatorType.ShellCallOutput,
                "tool_search_call" => BetaItemDiscriminatorType.ToolSearchCall,
                "tool_search_output" => BetaItemDiscriminatorType.ToolSearchOutput,
                "web_search_call" => BetaItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}