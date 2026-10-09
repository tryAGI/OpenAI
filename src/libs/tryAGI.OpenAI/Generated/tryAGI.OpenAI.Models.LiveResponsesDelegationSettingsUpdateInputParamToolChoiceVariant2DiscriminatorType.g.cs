
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType
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
    public static class LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType value)
        {
            return value switch
            {
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.ApplyPatch => "apply_patch",
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.CodeInterpreter => "code_interpreter",
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.Computer => "computer",
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.Custom => "custom",
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.FileSearch => "file_search",
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.Function => "function",
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.ImageGeneration => "image_generation",
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.Mcp => "mcp",
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.Shell => "shell",
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.WebSearch => "web_search",
                LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.WebSearchPreview => "web_search_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.ApplyPatch,
                "code_interpreter" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.CodeInterpreter,
                "computer" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.Computer,
                "custom" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.Custom,
                "file_search" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.FileSearch,
                "function" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.Function,
                "image_generation" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.ImageGeneration,
                "mcp" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.Mcp,
                "programmatic_tool_calling" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.ProgrammaticToolCalling,
                "shell" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.Shell,
                "web_search" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.WebSearch,
                "web_search_preview" => LiveResponsesDelegationSettingsUpdateInputParamToolChoiceVariant2DiscriminatorType.WebSearchPreview,
                _ => null,
            };
        }
    }
}