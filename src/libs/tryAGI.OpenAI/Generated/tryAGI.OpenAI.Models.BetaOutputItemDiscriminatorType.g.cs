
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaOutputItemDiscriminatorType
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
        FileSearchCall,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
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
    public static class BetaOutputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputItemDiscriminatorType value)
        {
            return value switch
            {
                BetaOutputItemDiscriminatorType.AdditionalTools => "additional_tools",
                BetaOutputItemDiscriminatorType.AgentMessage => "agent_message",
                BetaOutputItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                BetaOutputItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                BetaOutputItemDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                BetaOutputItemDiscriminatorType.Compaction => "compaction",
                BetaOutputItemDiscriminatorType.ComputerCall => "computer_call",
                BetaOutputItemDiscriminatorType.CustomToolCall => "custom_tool_call",
                BetaOutputItemDiscriminatorType.FileSearchCall => "file_search_call",
                BetaOutputItemDiscriminatorType.FunctionCall => "function_call",
                BetaOutputItemDiscriminatorType.ImageGenerationCall => "image_generation_call",
                BetaOutputItemDiscriminatorType.LocalShellCall => "local_shell_call",
                BetaOutputItemDiscriminatorType.LocalShellCallOutput => "local_shell_call_output",
                BetaOutputItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                BetaOutputItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                BetaOutputItemDiscriminatorType.McpCall => "mcp_call",
                BetaOutputItemDiscriminatorType.McpListTools => "mcp_list_tools",
                BetaOutputItemDiscriminatorType.Message => "message",
                BetaOutputItemDiscriminatorType.MultiAgentCall => "multi_agent_call",
                BetaOutputItemDiscriminatorType.MultiAgentCallOutput => "multi_agent_call_output",
                BetaOutputItemDiscriminatorType.Program => "program",
                BetaOutputItemDiscriminatorType.ProgramOutput => "program_output",
                BetaOutputItemDiscriminatorType.Reasoning => "reasoning",
                BetaOutputItemDiscriminatorType.ShellCall => "shell_call",
                BetaOutputItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                BetaOutputItemDiscriminatorType.ToolSearchCall => "tool_search_call",
                BetaOutputItemDiscriminatorType.ToolSearchOutput => "tool_search_output",
                BetaOutputItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => BetaOutputItemDiscriminatorType.AdditionalTools,
                "agent_message" => BetaOutputItemDiscriminatorType.AgentMessage,
                "apply_patch_call" => BetaOutputItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => BetaOutputItemDiscriminatorType.ApplyPatchCallOutput,
                "code_interpreter_call" => BetaOutputItemDiscriminatorType.CodeInterpreterCall,
                "compaction" => BetaOutputItemDiscriminatorType.Compaction,
                "computer_call" => BetaOutputItemDiscriminatorType.ComputerCall,
                "custom_tool_call" => BetaOutputItemDiscriminatorType.CustomToolCall,
                "file_search_call" => BetaOutputItemDiscriminatorType.FileSearchCall,
                "function_call" => BetaOutputItemDiscriminatorType.FunctionCall,
                "image_generation_call" => BetaOutputItemDiscriminatorType.ImageGenerationCall,
                "local_shell_call" => BetaOutputItemDiscriminatorType.LocalShellCall,
                "local_shell_call_output" => BetaOutputItemDiscriminatorType.LocalShellCallOutput,
                "mcp_approval_request" => BetaOutputItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => BetaOutputItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => BetaOutputItemDiscriminatorType.McpCall,
                "mcp_list_tools" => BetaOutputItemDiscriminatorType.McpListTools,
                "message" => BetaOutputItemDiscriminatorType.Message,
                "multi_agent_call" => BetaOutputItemDiscriminatorType.MultiAgentCall,
                "multi_agent_call_output" => BetaOutputItemDiscriminatorType.MultiAgentCallOutput,
                "program" => BetaOutputItemDiscriminatorType.Program,
                "program_output" => BetaOutputItemDiscriminatorType.ProgramOutput,
                "reasoning" => BetaOutputItemDiscriminatorType.Reasoning,
                "shell_call" => BetaOutputItemDiscriminatorType.ShellCall,
                "shell_call_output" => BetaOutputItemDiscriminatorType.ShellCallOutput,
                "tool_search_call" => BetaOutputItemDiscriminatorType.ToolSearchCall,
                "tool_search_output" => BetaOutputItemDiscriminatorType.ToolSearchOutput,
                "web_search_call" => BetaOutputItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}