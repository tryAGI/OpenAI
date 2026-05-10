
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationItemDiscriminatorType
    {
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
    public static class ConversationItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemDiscriminatorType value)
        {
            return value switch
            {
                ConversationItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                ConversationItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                ConversationItemDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                ConversationItemDiscriminatorType.Compaction => "compaction",
                ConversationItemDiscriminatorType.ComputerCall => "computer_call",
                ConversationItemDiscriminatorType.CustomToolCall => "custom_tool_call",
                ConversationItemDiscriminatorType.CustomToolCallOutput => "custom_tool_call_output",
                ConversationItemDiscriminatorType.FileSearchCall => "file_search_call",
                ConversationItemDiscriminatorType.ImageGenerationCall => "image_generation_call",
                ConversationItemDiscriminatorType.LocalShellCall => "local_shell_call",
                ConversationItemDiscriminatorType.LocalShellCallOutput => "local_shell_call_output",
                ConversationItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                ConversationItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                ConversationItemDiscriminatorType.McpCall => "mcp_call",
                ConversationItemDiscriminatorType.McpListTools => "mcp_list_tools",
                ConversationItemDiscriminatorType.Message => "message",
                ConversationItemDiscriminatorType.Reasoning => "reasoning",
                ConversationItemDiscriminatorType.ShellCall => "shell_call",
                ConversationItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                ConversationItemDiscriminatorType.ToolSearchCall => "tool_search_call",
                ConversationItemDiscriminatorType.ToolSearchOutput => "tool_search_output",
                ConversationItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => ConversationItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => ConversationItemDiscriminatorType.ApplyPatchCallOutput,
                "code_interpreter_call" => ConversationItemDiscriminatorType.CodeInterpreterCall,
                "compaction" => ConversationItemDiscriminatorType.Compaction,
                "computer_call" => ConversationItemDiscriminatorType.ComputerCall,
                "custom_tool_call" => ConversationItemDiscriminatorType.CustomToolCall,
                "custom_tool_call_output" => ConversationItemDiscriminatorType.CustomToolCallOutput,
                "file_search_call" => ConversationItemDiscriminatorType.FileSearchCall,
                "image_generation_call" => ConversationItemDiscriminatorType.ImageGenerationCall,
                "local_shell_call" => ConversationItemDiscriminatorType.LocalShellCall,
                "local_shell_call_output" => ConversationItemDiscriminatorType.LocalShellCallOutput,
                "mcp_approval_request" => ConversationItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => ConversationItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => ConversationItemDiscriminatorType.McpCall,
                "mcp_list_tools" => ConversationItemDiscriminatorType.McpListTools,
                "message" => ConversationItemDiscriminatorType.Message,
                "reasoning" => ConversationItemDiscriminatorType.Reasoning,
                "shell_call" => ConversationItemDiscriminatorType.ShellCall,
                "shell_call_output" => ConversationItemDiscriminatorType.ShellCallOutput,
                "tool_search_call" => ConversationItemDiscriminatorType.ToolSearchCall,
                "tool_search_output" => ConversationItemDiscriminatorType.ToolSearchOutput,
                "web_search_call" => ConversationItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}