
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ItemResourceDiscriminatorType
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
    public static class ItemResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemResourceDiscriminatorType value)
        {
            return value switch
            {
                ItemResourceDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                ItemResourceDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                ItemResourceDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                ItemResourceDiscriminatorType.Compaction => "compaction",
                ItemResourceDiscriminatorType.ComputerCall => "computer_call",
                ItemResourceDiscriminatorType.FileSearchCall => "file_search_call",
                ItemResourceDiscriminatorType.ImageGenerationCall => "image_generation_call",
                ItemResourceDiscriminatorType.LocalShellCall => "local_shell_call",
                ItemResourceDiscriminatorType.LocalShellCallOutput => "local_shell_call_output",
                ItemResourceDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                ItemResourceDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                ItemResourceDiscriminatorType.McpCall => "mcp_call",
                ItemResourceDiscriminatorType.McpListTools => "mcp_list_tools",
                ItemResourceDiscriminatorType.Message => "message",
                ItemResourceDiscriminatorType.Reasoning => "reasoning",
                ItemResourceDiscriminatorType.ShellCall => "shell_call",
                ItemResourceDiscriminatorType.ShellCallOutput => "shell_call_output",
                ItemResourceDiscriminatorType.ToolSearchCall => "tool_search_call",
                ItemResourceDiscriminatorType.ToolSearchOutput => "tool_search_output",
                ItemResourceDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => ItemResourceDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => ItemResourceDiscriminatorType.ApplyPatchCallOutput,
                "code_interpreter_call" => ItemResourceDiscriminatorType.CodeInterpreterCall,
                "compaction" => ItemResourceDiscriminatorType.Compaction,
                "computer_call" => ItemResourceDiscriminatorType.ComputerCall,
                "file_search_call" => ItemResourceDiscriminatorType.FileSearchCall,
                "image_generation_call" => ItemResourceDiscriminatorType.ImageGenerationCall,
                "local_shell_call" => ItemResourceDiscriminatorType.LocalShellCall,
                "local_shell_call_output" => ItemResourceDiscriminatorType.LocalShellCallOutput,
                "mcp_approval_request" => ItemResourceDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => ItemResourceDiscriminatorType.McpApprovalResponse,
                "mcp_call" => ItemResourceDiscriminatorType.McpCall,
                "mcp_list_tools" => ItemResourceDiscriminatorType.McpListTools,
                "message" => ItemResourceDiscriminatorType.Message,
                "reasoning" => ItemResourceDiscriminatorType.Reasoning,
                "shell_call" => ItemResourceDiscriminatorType.ShellCall,
                "shell_call_output" => ItemResourceDiscriminatorType.ShellCallOutput,
                "tool_search_call" => ItemResourceDiscriminatorType.ToolSearchCall,
                "tool_search_output" => ItemResourceDiscriminatorType.ToolSearchOutput,
                "web_search_call" => ItemResourceDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}