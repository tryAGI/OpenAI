
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyPatch,
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        Computer,
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        FileSearch,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        LocalShell,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        Namespace,
        /// <summary>
        /// 
        /// </summary>
        Shell,
        /// <summary>
        /// 
        /// </summary>
        ToolSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolDiscriminatorType value)
        {
            return value switch
            {
                ToolDiscriminatorType.ApplyPatch => "apply_patch",
                ToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                ToolDiscriminatorType.Computer => "computer",
                ToolDiscriminatorType.ComputerUsePreview => "computer_use_preview",
                ToolDiscriminatorType.Custom => "custom",
                ToolDiscriminatorType.FileSearch => "file_search",
                ToolDiscriminatorType.Function => "function",
                ToolDiscriminatorType.ImageGeneration => "image_generation",
                ToolDiscriminatorType.LocalShell => "local_shell",
                ToolDiscriminatorType.Mcp => "mcp",
                ToolDiscriminatorType.Namespace => "namespace",
                ToolDiscriminatorType.Shell => "shell",
                ToolDiscriminatorType.ToolSearch => "tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => ToolDiscriminatorType.ApplyPatch,
                "code_interpreter" => ToolDiscriminatorType.CodeInterpreter,
                "computer" => ToolDiscriminatorType.Computer,
                "computer_use_preview" => ToolDiscriminatorType.ComputerUsePreview,
                "custom" => ToolDiscriminatorType.Custom,
                "file_search" => ToolDiscriminatorType.FileSearch,
                "function" => ToolDiscriminatorType.Function,
                "image_generation" => ToolDiscriminatorType.ImageGeneration,
                "local_shell" => ToolDiscriminatorType.LocalShell,
                "mcp" => ToolDiscriminatorType.Mcp,
                "namespace" => ToolDiscriminatorType.Namespace,
                "shell" => ToolDiscriminatorType.Shell,
                "tool_search" => ToolDiscriminatorType.ToolSearch,
                _ => null,
            };
        }
    }
}