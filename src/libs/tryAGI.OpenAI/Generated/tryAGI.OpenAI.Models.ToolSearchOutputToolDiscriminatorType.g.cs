
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolSearchOutputToolDiscriminatorType
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
        ProgrammaticToolCalling,
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
    public static class ToolSearchOutputToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchOutputToolDiscriminatorType value)
        {
            return value switch
            {
                ToolSearchOutputToolDiscriminatorType.ApplyPatch => "apply_patch",
                ToolSearchOutputToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                ToolSearchOutputToolDiscriminatorType.Computer => "computer",
                ToolSearchOutputToolDiscriminatorType.ComputerUsePreview => "computer_use_preview",
                ToolSearchOutputToolDiscriminatorType.Custom => "custom",
                ToolSearchOutputToolDiscriminatorType.FileSearch => "file_search",
                ToolSearchOutputToolDiscriminatorType.Function => "function",
                ToolSearchOutputToolDiscriminatorType.ImageGeneration => "image_generation",
                ToolSearchOutputToolDiscriminatorType.LocalShell => "local_shell",
                ToolSearchOutputToolDiscriminatorType.Mcp => "mcp",
                ToolSearchOutputToolDiscriminatorType.Namespace => "namespace",
                ToolSearchOutputToolDiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                ToolSearchOutputToolDiscriminatorType.Shell => "shell",
                ToolSearchOutputToolDiscriminatorType.ToolSearch => "tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchOutputToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => ToolSearchOutputToolDiscriminatorType.ApplyPatch,
                "code_interpreter" => ToolSearchOutputToolDiscriminatorType.CodeInterpreter,
                "computer" => ToolSearchOutputToolDiscriminatorType.Computer,
                "computer_use_preview" => ToolSearchOutputToolDiscriminatorType.ComputerUsePreview,
                "custom" => ToolSearchOutputToolDiscriminatorType.Custom,
                "file_search" => ToolSearchOutputToolDiscriminatorType.FileSearch,
                "function" => ToolSearchOutputToolDiscriminatorType.Function,
                "image_generation" => ToolSearchOutputToolDiscriminatorType.ImageGeneration,
                "local_shell" => ToolSearchOutputToolDiscriminatorType.LocalShell,
                "mcp" => ToolSearchOutputToolDiscriminatorType.Mcp,
                "namespace" => ToolSearchOutputToolDiscriminatorType.Namespace,
                "programmatic_tool_calling" => ToolSearchOutputToolDiscriminatorType.ProgrammaticToolCalling,
                "shell" => ToolSearchOutputToolDiscriminatorType.Shell,
                "tool_search" => ToolSearchOutputToolDiscriminatorType.ToolSearch,
                _ => null,
            };
        }
    }
}