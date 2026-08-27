
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaItemResourceDiscriminatorType
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
        FileSearchCall,
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
    public static class BetaItemResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaItemResourceDiscriminatorType value)
        {
            return value switch
            {
                BetaItemResourceDiscriminatorType.AdditionalTools => "additional_tools",
                BetaItemResourceDiscriminatorType.AgentMessage => "agent_message",
                BetaItemResourceDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                BetaItemResourceDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                BetaItemResourceDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                BetaItemResourceDiscriminatorType.Compaction => "compaction",
                BetaItemResourceDiscriminatorType.ComputerCall => "computer_call",
                BetaItemResourceDiscriminatorType.FileSearchCall => "file_search_call",
                BetaItemResourceDiscriminatorType.ImageGenerationCall => "image_generation_call",
                BetaItemResourceDiscriminatorType.LocalShellCall => "local_shell_call",
                BetaItemResourceDiscriminatorType.LocalShellCallOutput => "local_shell_call_output",
                BetaItemResourceDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                BetaItemResourceDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                BetaItemResourceDiscriminatorType.McpCall => "mcp_call",
                BetaItemResourceDiscriminatorType.McpListTools => "mcp_list_tools",
                BetaItemResourceDiscriminatorType.Message => "message",
                BetaItemResourceDiscriminatorType.MultiAgentCall => "multi_agent_call",
                BetaItemResourceDiscriminatorType.MultiAgentCallOutput => "multi_agent_call_output",
                BetaItemResourceDiscriminatorType.Program => "program",
                BetaItemResourceDiscriminatorType.ProgramOutput => "program_output",
                BetaItemResourceDiscriminatorType.Reasoning => "reasoning",
                BetaItemResourceDiscriminatorType.ShellCall => "shell_call",
                BetaItemResourceDiscriminatorType.ShellCallOutput => "shell_call_output",
                BetaItemResourceDiscriminatorType.ToolSearchCall => "tool_search_call",
                BetaItemResourceDiscriminatorType.ToolSearchOutput => "tool_search_output",
                BetaItemResourceDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaItemResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => BetaItemResourceDiscriminatorType.AdditionalTools,
                "agent_message" => BetaItemResourceDiscriminatorType.AgentMessage,
                "apply_patch_call" => BetaItemResourceDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => BetaItemResourceDiscriminatorType.ApplyPatchCallOutput,
                "code_interpreter_call" => BetaItemResourceDiscriminatorType.CodeInterpreterCall,
                "compaction" => BetaItemResourceDiscriminatorType.Compaction,
                "computer_call" => BetaItemResourceDiscriminatorType.ComputerCall,
                "file_search_call" => BetaItemResourceDiscriminatorType.FileSearchCall,
                "image_generation_call" => BetaItemResourceDiscriminatorType.ImageGenerationCall,
                "local_shell_call" => BetaItemResourceDiscriminatorType.LocalShellCall,
                "local_shell_call_output" => BetaItemResourceDiscriminatorType.LocalShellCallOutput,
                "mcp_approval_request" => BetaItemResourceDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => BetaItemResourceDiscriminatorType.McpApprovalResponse,
                "mcp_call" => BetaItemResourceDiscriminatorType.McpCall,
                "mcp_list_tools" => BetaItemResourceDiscriminatorType.McpListTools,
                "message" => BetaItemResourceDiscriminatorType.Message,
                "multi_agent_call" => BetaItemResourceDiscriminatorType.MultiAgentCall,
                "multi_agent_call_output" => BetaItemResourceDiscriminatorType.MultiAgentCallOutput,
                "program" => BetaItemResourceDiscriminatorType.Program,
                "program_output" => BetaItemResourceDiscriminatorType.ProgramOutput,
                "reasoning" => BetaItemResourceDiscriminatorType.Reasoning,
                "shell_call" => BetaItemResourceDiscriminatorType.ShellCall,
                "shell_call_output" => BetaItemResourceDiscriminatorType.ShellCallOutput,
                "tool_search_call" => BetaItemResourceDiscriminatorType.ToolSearchCall,
                "tool_search_output" => BetaItemResourceDiscriminatorType.ToolSearchOutput,
                "web_search_call" => BetaItemResourceDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}