
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaToolDiscriminatorType
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
    public static class BetaToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolDiscriminatorType value)
        {
            return value switch
            {
                BetaToolDiscriminatorType.ApplyPatch => "apply_patch",
                BetaToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                BetaToolDiscriminatorType.Computer => "computer",
                BetaToolDiscriminatorType.ComputerUsePreview => "computer_use_preview",
                BetaToolDiscriminatorType.Custom => "custom",
                BetaToolDiscriminatorType.FileSearch => "file_search",
                BetaToolDiscriminatorType.Function => "function",
                BetaToolDiscriminatorType.ImageGeneration => "image_generation",
                BetaToolDiscriminatorType.LocalShell => "local_shell",
                BetaToolDiscriminatorType.Mcp => "mcp",
                BetaToolDiscriminatorType.Namespace => "namespace",
                BetaToolDiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                BetaToolDiscriminatorType.Shell => "shell",
                BetaToolDiscriminatorType.ToolSearch => "tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => BetaToolDiscriminatorType.ApplyPatch,
                "code_interpreter" => BetaToolDiscriminatorType.CodeInterpreter,
                "computer" => BetaToolDiscriminatorType.Computer,
                "computer_use_preview" => BetaToolDiscriminatorType.ComputerUsePreview,
                "custom" => BetaToolDiscriminatorType.Custom,
                "file_search" => BetaToolDiscriminatorType.FileSearch,
                "function" => BetaToolDiscriminatorType.Function,
                "image_generation" => BetaToolDiscriminatorType.ImageGeneration,
                "local_shell" => BetaToolDiscriminatorType.LocalShell,
                "mcp" => BetaToolDiscriminatorType.Mcp,
                "namespace" => BetaToolDiscriminatorType.Namespace,
                "programmatic_tool_calling" => BetaToolDiscriminatorType.ProgrammaticToolCalling,
                "shell" => BetaToolDiscriminatorType.Shell,
                "tool_search" => BetaToolDiscriminatorType.ToolSearch,
                _ => null,
            };
        }
    }
}