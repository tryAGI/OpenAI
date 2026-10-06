
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaToolSearchOutputToolDiscriminatorType
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
    public static class BetaToolSearchOutputToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchOutputToolDiscriminatorType value)
        {
            return value switch
            {
                BetaToolSearchOutputToolDiscriminatorType.ApplyPatch => "apply_patch",
                BetaToolSearchOutputToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                BetaToolSearchOutputToolDiscriminatorType.Computer => "computer",
                BetaToolSearchOutputToolDiscriminatorType.ComputerUsePreview => "computer_use_preview",
                BetaToolSearchOutputToolDiscriminatorType.Custom => "custom",
                BetaToolSearchOutputToolDiscriminatorType.FileSearch => "file_search",
                BetaToolSearchOutputToolDiscriminatorType.Function => "function",
                BetaToolSearchOutputToolDiscriminatorType.ImageGeneration => "image_generation",
                BetaToolSearchOutputToolDiscriminatorType.LocalShell => "local_shell",
                BetaToolSearchOutputToolDiscriminatorType.Mcp => "mcp",
                BetaToolSearchOutputToolDiscriminatorType.Namespace => "namespace",
                BetaToolSearchOutputToolDiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                BetaToolSearchOutputToolDiscriminatorType.Shell => "shell",
                BetaToolSearchOutputToolDiscriminatorType.ToolSearch => "tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchOutputToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => BetaToolSearchOutputToolDiscriminatorType.ApplyPatch,
                "code_interpreter" => BetaToolSearchOutputToolDiscriminatorType.CodeInterpreter,
                "computer" => BetaToolSearchOutputToolDiscriminatorType.Computer,
                "computer_use_preview" => BetaToolSearchOutputToolDiscriminatorType.ComputerUsePreview,
                "custom" => BetaToolSearchOutputToolDiscriminatorType.Custom,
                "file_search" => BetaToolSearchOutputToolDiscriminatorType.FileSearch,
                "function" => BetaToolSearchOutputToolDiscriminatorType.Function,
                "image_generation" => BetaToolSearchOutputToolDiscriminatorType.ImageGeneration,
                "local_shell" => BetaToolSearchOutputToolDiscriminatorType.LocalShell,
                "mcp" => BetaToolSearchOutputToolDiscriminatorType.Mcp,
                "namespace" => BetaToolSearchOutputToolDiscriminatorType.Namespace,
                "programmatic_tool_calling" => BetaToolSearchOutputToolDiscriminatorType.ProgrammaticToolCalling,
                "shell" => BetaToolSearchOutputToolDiscriminatorType.Shell,
                "tool_search" => BetaToolSearchOutputToolDiscriminatorType.ToolSearch,
                _ => null,
            };
        }
    }
}