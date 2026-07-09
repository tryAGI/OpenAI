
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaItemFieldDiscriminatorType
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
        Program,
        /// <summary>
        /// 
        /// </summary>
        ProgramOutput,
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
    public static class BetaItemFieldDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaItemFieldDiscriminatorType value)
        {
            return value switch
            {
                BetaItemFieldDiscriminatorType.AdditionalTools => "additional_tools",
                BetaItemFieldDiscriminatorType.AgentMessage => "agent_message",
                BetaItemFieldDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                BetaItemFieldDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                BetaItemFieldDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                BetaItemFieldDiscriminatorType.Compaction => "compaction",
                BetaItemFieldDiscriminatorType.ComputerCall => "computer_call",
                BetaItemFieldDiscriminatorType.CustomToolCall => "custom_tool_call",
                BetaItemFieldDiscriminatorType.CustomToolCallOutput => "custom_tool_call_output",
                BetaItemFieldDiscriminatorType.FileSearchCall => "file_search_call",
                BetaItemFieldDiscriminatorType.FunctionCall => "function_call",
                BetaItemFieldDiscriminatorType.FunctionCallOutput => "function_call_output",
                BetaItemFieldDiscriminatorType.ImageGenerationCall => "image_generation_call",
                BetaItemFieldDiscriminatorType.LocalShellCall => "local_shell_call",
                BetaItemFieldDiscriminatorType.LocalShellCallOutput => "local_shell_call_output",
                BetaItemFieldDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                BetaItemFieldDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                BetaItemFieldDiscriminatorType.McpCall => "mcp_call",
                BetaItemFieldDiscriminatorType.McpListTools => "mcp_list_tools",
                BetaItemFieldDiscriminatorType.Message => "message",
                BetaItemFieldDiscriminatorType.MultiAgentCall => "multi_agent_call",
                BetaItemFieldDiscriminatorType.MultiAgentCallOutput => "multi_agent_call_output",
                BetaItemFieldDiscriminatorType.Program => "program",
                BetaItemFieldDiscriminatorType.ProgramOutput => "program_output",
                BetaItemFieldDiscriminatorType.Reasoning => "reasoning",
                BetaItemFieldDiscriminatorType.ShellCall => "shell_call",
                BetaItemFieldDiscriminatorType.ShellCallOutput => "shell_call_output",
                BetaItemFieldDiscriminatorType.ToolSearchCall => "tool_search_call",
                BetaItemFieldDiscriminatorType.ToolSearchOutput => "tool_search_output",
                BetaItemFieldDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaItemFieldDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => BetaItemFieldDiscriminatorType.AdditionalTools,
                "agent_message" => BetaItemFieldDiscriminatorType.AgentMessage,
                "apply_patch_call" => BetaItemFieldDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => BetaItemFieldDiscriminatorType.ApplyPatchCallOutput,
                "code_interpreter_call" => BetaItemFieldDiscriminatorType.CodeInterpreterCall,
                "compaction" => BetaItemFieldDiscriminatorType.Compaction,
                "computer_call" => BetaItemFieldDiscriminatorType.ComputerCall,
                "custom_tool_call" => BetaItemFieldDiscriminatorType.CustomToolCall,
                "custom_tool_call_output" => BetaItemFieldDiscriminatorType.CustomToolCallOutput,
                "file_search_call" => BetaItemFieldDiscriminatorType.FileSearchCall,
                "function_call" => BetaItemFieldDiscriminatorType.FunctionCall,
                "function_call_output" => BetaItemFieldDiscriminatorType.FunctionCallOutput,
                "image_generation_call" => BetaItemFieldDiscriminatorType.ImageGenerationCall,
                "local_shell_call" => BetaItemFieldDiscriminatorType.LocalShellCall,
                "local_shell_call_output" => BetaItemFieldDiscriminatorType.LocalShellCallOutput,
                "mcp_approval_request" => BetaItemFieldDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => BetaItemFieldDiscriminatorType.McpApprovalResponse,
                "mcp_call" => BetaItemFieldDiscriminatorType.McpCall,
                "mcp_list_tools" => BetaItemFieldDiscriminatorType.McpListTools,
                "message" => BetaItemFieldDiscriminatorType.Message,
                "multi_agent_call" => BetaItemFieldDiscriminatorType.MultiAgentCall,
                "multi_agent_call_output" => BetaItemFieldDiscriminatorType.MultiAgentCallOutput,
                "program" => BetaItemFieldDiscriminatorType.Program,
                "program_output" => BetaItemFieldDiscriminatorType.ProgramOutput,
                "reasoning" => BetaItemFieldDiscriminatorType.Reasoning,
                "shell_call" => BetaItemFieldDiscriminatorType.ShellCall,
                "shell_call_output" => BetaItemFieldDiscriminatorType.ShellCallOutput,
                "tool_search_call" => BetaItemFieldDiscriminatorType.ToolSearchCall,
                "tool_search_output" => BetaItemFieldDiscriminatorType.ToolSearchOutput,
                "web_search_call" => BetaItemFieldDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}