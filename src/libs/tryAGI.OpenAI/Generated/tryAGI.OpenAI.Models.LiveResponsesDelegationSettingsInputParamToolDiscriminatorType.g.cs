
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveResponsesDelegationSettingsInputParamToolDiscriminatorType
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
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveResponsesDelegationSettingsInputParamToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponsesDelegationSettingsInputParamToolDiscriminatorType value)
        {
            return value switch
            {
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.ApplyPatch => "apply_patch",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Computer => "computer",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Custom => "custom",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.FileSearch => "file_search",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Function => "function",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.ImageGeneration => "image_generation",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Mcp => "mcp",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Namespace => "namespace",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Shell => "shell",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.ToolSearch => "tool_search",
                LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.ApplyPatch,
                "code_interpreter" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.CodeInterpreter,
                "computer" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Computer,
                "custom" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Custom,
                "file_search" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.FileSearch,
                "function" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Function,
                "image_generation" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.ImageGeneration,
                "mcp" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Mcp,
                "namespace" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Namespace,
                "programmatic_tool_calling" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.ProgrammaticToolCalling,
                "shell" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.Shell,
                "tool_search" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.ToolSearch,
                "web_search" => LiveResponsesDelegationSettingsInputParamToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}