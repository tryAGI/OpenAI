
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType
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
    public static class LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType value)
        {
            return value switch
            {
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.ApplyPatch => "apply_patch",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Computer => "computer",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Custom => "custom",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.FileSearch => "file_search",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Function => "function",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.ImageGeneration => "image_generation",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Mcp => "mcp",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Namespace => "namespace",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Shell => "shell",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.ToolSearch => "tool_search",
                LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.ApplyPatch,
                "code_interpreter" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.CodeInterpreter,
                "computer" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Computer,
                "custom" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Custom,
                "file_search" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.FileSearch,
                "function" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Function,
                "image_generation" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.ImageGeneration,
                "mcp" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Mcp,
                "namespace" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Namespace,
                "programmatic_tool_calling" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.ProgrammaticToolCalling,
                "shell" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.Shell,
                "tool_search" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.ToolSearch,
                "web_search" => LiveResponsesDelegationSettingsUpdateInputParamToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}