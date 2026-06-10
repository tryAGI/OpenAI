
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ItemFieldDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AdditionalTools,
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
    public static class ItemFieldDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemFieldDiscriminatorType value)
        {
            return value switch
            {
                ItemFieldDiscriminatorType.AdditionalTools => "additional_tools",
                ItemFieldDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                ItemFieldDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                ItemFieldDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                ItemFieldDiscriminatorType.Compaction => "compaction",
                ItemFieldDiscriminatorType.ComputerCall => "computer_call",
                ItemFieldDiscriminatorType.CustomToolCall => "custom_tool_call",
                ItemFieldDiscriminatorType.CustomToolCallOutput => "custom_tool_call_output",
                ItemFieldDiscriminatorType.FileSearchCall => "file_search_call",
                ItemFieldDiscriminatorType.FunctionCall => "function_call",
                ItemFieldDiscriminatorType.FunctionCallOutput => "function_call_output",
                ItemFieldDiscriminatorType.ImageGenerationCall => "image_generation_call",
                ItemFieldDiscriminatorType.LocalShellCall => "local_shell_call",
                ItemFieldDiscriminatorType.LocalShellCallOutput => "local_shell_call_output",
                ItemFieldDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                ItemFieldDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                ItemFieldDiscriminatorType.McpCall => "mcp_call",
                ItemFieldDiscriminatorType.McpListTools => "mcp_list_tools",
                ItemFieldDiscriminatorType.Message => "message",
                ItemFieldDiscriminatorType.Reasoning => "reasoning",
                ItemFieldDiscriminatorType.ShellCall => "shell_call",
                ItemFieldDiscriminatorType.ShellCallOutput => "shell_call_output",
                ItemFieldDiscriminatorType.ToolSearchCall => "tool_search_call",
                ItemFieldDiscriminatorType.ToolSearchOutput => "tool_search_output",
                ItemFieldDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemFieldDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => ItemFieldDiscriminatorType.AdditionalTools,
                "apply_patch_call" => ItemFieldDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => ItemFieldDiscriminatorType.ApplyPatchCallOutput,
                "code_interpreter_call" => ItemFieldDiscriminatorType.CodeInterpreterCall,
                "compaction" => ItemFieldDiscriminatorType.Compaction,
                "computer_call" => ItemFieldDiscriminatorType.ComputerCall,
                "custom_tool_call" => ItemFieldDiscriminatorType.CustomToolCall,
                "custom_tool_call_output" => ItemFieldDiscriminatorType.CustomToolCallOutput,
                "file_search_call" => ItemFieldDiscriminatorType.FileSearchCall,
                "function_call" => ItemFieldDiscriminatorType.FunctionCall,
                "function_call_output" => ItemFieldDiscriminatorType.FunctionCallOutput,
                "image_generation_call" => ItemFieldDiscriminatorType.ImageGenerationCall,
                "local_shell_call" => ItemFieldDiscriminatorType.LocalShellCall,
                "local_shell_call_output" => ItemFieldDiscriminatorType.LocalShellCallOutput,
                "mcp_approval_request" => ItemFieldDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => ItemFieldDiscriminatorType.McpApprovalResponse,
                "mcp_call" => ItemFieldDiscriminatorType.McpCall,
                "mcp_list_tools" => ItemFieldDiscriminatorType.McpListTools,
                "message" => ItemFieldDiscriminatorType.Message,
                "reasoning" => ItemFieldDiscriminatorType.Reasoning,
                "shell_call" => ItemFieldDiscriminatorType.ShellCall,
                "shell_call_output" => ItemFieldDiscriminatorType.ShellCallOutput,
                "tool_search_call" => ItemFieldDiscriminatorType.ToolSearchCall,
                "tool_search_output" => ItemFieldDiscriminatorType.ToolSearchOutput,
                "web_search_call" => ItemFieldDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}