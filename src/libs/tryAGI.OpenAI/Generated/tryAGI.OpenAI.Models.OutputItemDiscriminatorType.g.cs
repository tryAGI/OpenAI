
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemDiscriminatorType
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
    public static class OutputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemDiscriminatorType value)
        {
            return value switch
            {
                OutputItemDiscriminatorType.AdditionalTools => "additional_tools",
                OutputItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                OutputItemDiscriminatorType.ApplyPatchCallOutput => "apply_patch_call_output",
                OutputItemDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                OutputItemDiscriminatorType.Compaction => "compaction",
                OutputItemDiscriminatorType.ComputerCall => "computer_call",
                OutputItemDiscriminatorType.CustomToolCall => "custom_tool_call",
                OutputItemDiscriminatorType.FileSearchCall => "file_search_call",
                OutputItemDiscriminatorType.FunctionCall => "function_call",
                OutputItemDiscriminatorType.ImageGenerationCall => "image_generation_call",
                OutputItemDiscriminatorType.LocalShellCall => "local_shell_call",
                OutputItemDiscriminatorType.LocalShellCallOutput => "local_shell_call_output",
                OutputItemDiscriminatorType.McpApprovalRequest => "mcp_approval_request",
                OutputItemDiscriminatorType.McpApprovalResponse => "mcp_approval_response",
                OutputItemDiscriminatorType.McpCall => "mcp_call",
                OutputItemDiscriminatorType.McpListTools => "mcp_list_tools",
                OutputItemDiscriminatorType.Message => "message",
                OutputItemDiscriminatorType.Reasoning => "reasoning",
                OutputItemDiscriminatorType.ShellCall => "shell_call",
                OutputItemDiscriminatorType.ShellCallOutput => "shell_call_output",
                OutputItemDiscriminatorType.ToolSearchCall => "tool_search_call",
                OutputItemDiscriminatorType.ToolSearchOutput => "tool_search_output",
                OutputItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "additional_tools" => OutputItemDiscriminatorType.AdditionalTools,
                "apply_patch_call" => OutputItemDiscriminatorType.ApplyPatchCall,
                "apply_patch_call_output" => OutputItemDiscriminatorType.ApplyPatchCallOutput,
                "code_interpreter_call" => OutputItemDiscriminatorType.CodeInterpreterCall,
                "compaction" => OutputItemDiscriminatorType.Compaction,
                "computer_call" => OutputItemDiscriminatorType.ComputerCall,
                "custom_tool_call" => OutputItemDiscriminatorType.CustomToolCall,
                "file_search_call" => OutputItemDiscriminatorType.FileSearchCall,
                "function_call" => OutputItemDiscriminatorType.FunctionCall,
                "image_generation_call" => OutputItemDiscriminatorType.ImageGenerationCall,
                "local_shell_call" => OutputItemDiscriminatorType.LocalShellCall,
                "local_shell_call_output" => OutputItemDiscriminatorType.LocalShellCallOutput,
                "mcp_approval_request" => OutputItemDiscriminatorType.McpApprovalRequest,
                "mcp_approval_response" => OutputItemDiscriminatorType.McpApprovalResponse,
                "mcp_call" => OutputItemDiscriminatorType.McpCall,
                "mcp_list_tools" => OutputItemDiscriminatorType.McpListTools,
                "message" => OutputItemDiscriminatorType.Message,
                "reasoning" => OutputItemDiscriminatorType.Reasoning,
                "shell_call" => OutputItemDiscriminatorType.ShellCall,
                "shell_call_output" => OutputItemDiscriminatorType.ShellCallOutput,
                "tool_search_call" => OutputItemDiscriminatorType.ToolSearchCall,
                "tool_search_output" => OutputItemDiscriminatorType.ToolSearchOutput,
                "web_search_call" => OutputItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}