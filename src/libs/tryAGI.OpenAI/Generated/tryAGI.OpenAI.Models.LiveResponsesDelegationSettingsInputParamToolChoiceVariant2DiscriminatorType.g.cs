
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType
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
        ProgrammaticToolCalling,
        /// <summary>
        ///
        /// </summary>
        Shell,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
        /// <summary>
        ///
        /// </summary>
        WebSearchPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType value)
        {
            return value switch
            {
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.ApplyPatch => "apply_patch",
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.CodeInterpreter => "code_interpreter",
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.Computer => "computer",
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.Custom => "custom",
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.FileSearch => "file_search",
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.Function => "function",
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.ImageGeneration => "image_generation",
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.Mcp => "mcp",
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.Shell => "shell",
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.WebSearch => "web_search",
                LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.WebSearchPreview => "web_search_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.ApplyPatch,
                "code_interpreter" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.CodeInterpreter,
                "computer" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.Computer,
                "custom" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.Custom,
                "file_search" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.FileSearch,
                "function" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.Function,
                "image_generation" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.ImageGeneration,
                "mcp" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.Mcp,
                "programmatic_tool_calling" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.ProgrammaticToolCalling,
                "shell" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.Shell,
                "web_search" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.WebSearch,
                "web_search_preview" => LiveResponsesDelegationSettingsInputParamToolChoiceVariant2DiscriminatorType.WebSearchPreview,
                _ => null,
            };
        }
    }
}