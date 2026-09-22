
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentTypeResource), TypeInfoPropertyName = "EnvironmentTypeResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentStatusResource), TypeInfoPropertyName = "EnvironmentStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginResourceInline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType), TypeInfoPropertyName = "HostedPluginResourceInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginResource), TypeInfoPropertyName = "HostedPluginResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType), TypeInfoPropertyName = "HostedPluginResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType), TypeInfoPropertyName = "HostedSkillResourceSkillReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillResourceInline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType), TypeInfoPropertyName = "HostedSkillResourceInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillResource), TypeInfoPropertyName = "HostedSkillResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType), TypeInfoPropertyName = "HostedSkillResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType), TypeInfoPropertyName = "HostedEnvironmentFileResourceFileIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType), TypeInfoPropertyName = "HostedEnvironmentFileResourceInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResource), TypeInfoPropertyName = "HostedEnvironmentFileResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType), TypeInfoPropertyName = "HostedEnvironmentFileResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PublicEnvironmentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject), TypeInfoPropertyName = "PublicEnvironmentResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorBodyResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListOrderParam), TypeInfoPropertyName = "ListOrderParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentFilePageObjectResource), TypeInfoPropertyName = "EnvironmentFilePageObjectResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentFileResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentFileResourceObject), TypeInfoPropertyName = "EnvironmentFileResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentFileListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentFileResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType), TypeInfoPropertyName = "HostedEnvironmentFileParamFileIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType), TypeInfoPropertyName = "HostedEnvironmentFileParamInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParam), TypeInfoPropertyName = "HostedEnvironmentFileParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType), TypeInfoPropertyName = "HostedEnvironmentFileParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SubagentObjectResource), TypeInfoPropertyName = "SubagentObjectResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputTextResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputTextResourceType), TypeInfoPropertyName = "OutputTextResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EncryptedContentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EncryptedContentResourceType), TypeInfoPropertyName = "EncryptedContentResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentContentResource), TypeInfoPropertyName = "AgentContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType), TypeInfoPropertyName = "AgentContentResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SubagentStatusResource), TypeInfoPropertyName = "SubagentStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SubagentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentContentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionMessageRoleResource), TypeInfoPropertyName = "SessionMessageRoleResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceInputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType), TypeInfoPropertyName = "MessageContentResourceInputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceInputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType), TypeInfoPropertyName = "MessageContentResourceInputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceOutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType), TypeInfoPropertyName = "MessageContentResourceOutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResource), TypeInfoPropertyName = "MessageContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType), TypeInfoPropertyName = "MessageContentResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputItemStatusResource), TypeInfoPropertyName = "OutputItemStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessagePhaseResource), TypeInfoPropertyName = "MessagePhaseResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageItemResourceType), TypeInfoPropertyName = "MessageItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MessageContentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SummaryTextResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SummaryTextResourceType), TypeInfoPropertyName = "SummaryTextResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemResourceType), TypeInfoPropertyName = "ReasoningItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallStatusResource), TypeInfoPropertyName = "FunctionCallStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType), TypeInfoPropertyName = "FunctionCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentResourceInputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType), TypeInfoPropertyName = "InputContentResourceInputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentResourceInputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType), TypeInfoPropertyName = "InputContentResourceInputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentResource), TypeInfoPropertyName = "InputContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType), TypeInfoPropertyName = "InputContentResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputResource), TypeInfoPropertyName = "FunctionCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType), TypeInfoPropertyName = "FunctionCallOutputItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentMessageItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType), TypeInfoPropertyName = "AgentMessageItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpCallItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpCallItemResourceType), TypeInfoPropertyName = "McpCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType), TypeInfoPropertyName = "WebSearchActionResourceSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType), TypeInfoPropertyName = "WebSearchActionResourceOpenPageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType), TypeInfoPropertyName = "WebSearchActionResourceFindInPageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceOther))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType), TypeInfoPropertyName = "WebSearchActionResourceOtherType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResource), TypeInfoPropertyName = "WebSearchActionResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType), TypeInfoPropertyName = "WebSearchActionResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchCallItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType), TypeInfoPropertyName = "WebSearchCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CommandExecutionItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType), TypeInfoPropertyName = "CommandExecutionItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType), TypeInfoPropertyName = "InterruptSubagentCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType), TypeInfoPropertyName = "CreateSubagentCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType), TypeInfoPropertyName = "SendSubagentInputCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType), TypeInfoPropertyName = "ResumeSubagentCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType), TypeInfoPropertyName = "WaitForSubagentsCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType), TypeInfoPropertyName = "CloseSubagentCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionTurnItemResource), TypeInfoPropertyName = "SessionTurnItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType), TypeInfoPropertyName = "SessionTurnItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionItemListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionItemListResourceObject), TypeInfoPropertyName = "SessionItemListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionTurnItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TurnObjectResource), TypeInfoPropertyName = "TurnObjectResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TurnStatusResource), TypeInfoPropertyName = "TurnStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionTurnErrorCodeResource), TypeInfoPropertyName = "SessionTurnErrorCodeResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionTurnErrorResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTokensDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputTokensDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TokenUsageResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TurnResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionTurnListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionTurnListResourceObject), TypeInfoPropertyName = "SessionTurnListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TurnResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortResource), TypeInfoPropertyName = "ReasoningEffortResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningSummaryResource), TypeInfoPropertyName = "ReasoningSummaryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatResourceText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatResourceTextType), TypeInfoPropertyName = "TextFormatResourceTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType), TypeInfoPropertyName = "TextFormatResourceJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatResource), TypeInfoPropertyName = "TextFormatResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType), TypeInfoPropertyName = "TextFormatResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VerbosityResource), TypeInfoPropertyName = "VerbosityResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ServiceTierResource), TypeInfoPropertyName = "ServiceTierResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType), TypeInfoPropertyName = "PersistedAgentToolResourceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType), TypeInfoPropertyName = "PersistedAgentToolResourceToolSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCalling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType), TypeInfoPropertyName = "PersistedAgentToolResourceProgrammaticToolCallingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType), TypeInfoPropertyName = "PersistedMcpTransportResourceHttpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType), TypeInfoPropertyName = "PersistedMcpTransportResourceStdioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportResource), TypeInfoPropertyName = "PersistedMcpTransportResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType), TypeInfoPropertyName = "PersistedMcpTransportResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpConnectionOriginResource), TypeInfoPropertyName = "McpConnectionOriginResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType), TypeInfoPropertyName = "PersistedAgentToolResourceMcpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchModeResource), TypeInfoPropertyName = "WebSearchModeResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource), TypeInfoPropertyName = "WebSearchContextSizeResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchLocationResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType), TypeInfoPropertyName = "PersistedAgentToolResourceWebSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResource), TypeInfoPropertyName = "PersistedAgentToolResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType), TypeInfoPropertyName = "PersistedAgentToolResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MultiAgentConfigResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentResourceObject), TypeInfoPropertyName = "AgentResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentListResourceObject), TypeInfoPropertyName = "AgentListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortParam), TypeInfoPropertyName = "ReasoningEffortParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningSummaryParam), TypeInfoPropertyName = "ReasoningSummaryParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatParamText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatParamTextType), TypeInfoPropertyName = "TextFormatParamTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType), TypeInfoPropertyName = "TextFormatParamJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatParam), TypeInfoPropertyName = "TextFormatParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType), TypeInfoPropertyName = "TextFormatParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VerbosityParam), TypeInfoPropertyName = "VerbosityParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ServiceTierParam), TypeInfoPropertyName = "ServiceTierParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType), TypeInfoPropertyName = "PersistedAgentToolConfigParamFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType), TypeInfoPropertyName = "PersistedAgentToolConfigParamToolSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCalling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType), TypeInfoPropertyName = "PersistedAgentToolConfigParamProgrammaticToolCallingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType), TypeInfoPropertyName = "PersistedMcpTransportConfigParamHttpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType), TypeInfoPropertyName = "PersistedMcpTransportConfigParamStdioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParam), TypeInfoPropertyName = "PersistedMcpTransportConfigParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType), TypeInfoPropertyName = "PersistedMcpTransportConfigParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpConnectionOriginParam), TypeInfoPropertyName = "McpConnectionOriginParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType), TypeInfoPropertyName = "PersistedAgentToolConfigParamMcpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchModeParam), TypeInfoPropertyName = "WebSearchModeParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam), TypeInfoPropertyName = "WebSearchContextSizeParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchLocationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType), TypeInfoPropertyName = "PersistedAgentToolConfigParamWebSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParam), TypeInfoPropertyName = "PersistedAgentToolConfigParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType), TypeInfoPropertyName = "PersistedAgentToolConfigParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MultiAgentConfigCurrentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAgentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateAgentParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedAgentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedAgentResourceObject), TypeInfoPropertyName = "DeletedAgentResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentPackagesResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkAccessResource), TypeInfoPropertyName = "NetworkAccessResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicyResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType), TypeInfoPropertyName = "HostedTemplateSkillResourceSkillReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType), TypeInfoPropertyName = "HostedTemplateSkillResourceInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateSkillResource), TypeInfoPropertyName = "HostedTemplateSkillResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType), TypeInfoPropertyName = "HostedTemplateSkillResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType), TypeInfoPropertyName = "HostedTemplateFileResourceFileIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType), TypeInfoPropertyName = "HostedTemplateFileResourceInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateFileResource), TypeInfoPropertyName = "HostedTemplateFileResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType), TypeInfoPropertyName = "HostedTemplateFileResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentTemplateResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject), TypeInfoPropertyName = "EnvironmentTemplateResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateSkillResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateFileResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject), TypeInfoPropertyName = "EnvironmentTemplateListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.EnvironmentTemplateResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentPackagesParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SetupCommandParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkAccessParam), TypeInfoPropertyName = "NetworkAccessParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicyParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType), TypeInfoPropertyName = "HostedSkillParamSkillReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type), TypeInfoPropertyName = "InlineCapabilitySourceParamBase64Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType), TypeInfoPropertyName = "InlineCapabilitySourceParamBase64MediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParam), TypeInfoPropertyName = "InlineCapabilitySourceParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType), TypeInfoPropertyName = "InlineCapabilitySourceParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillParamInline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType), TypeInfoPropertyName = "HostedSkillParamInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillParam), TypeInfoPropertyName = "HostedSkillParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType), TypeInfoPropertyName = "HostedSkillParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginParamInline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType), TypeInfoPropertyName = "HostedPluginParamInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginParam), TypeInfoPropertyName = "HostedPluginParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType), TypeInfoPropertyName = "HostedPluginParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateEnvironmentTemplateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SetupCommandParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateEnvironmentTemplateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedEnvironmentTemplateResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject), TypeInfoPropertyName = "DeletedEnvironmentTemplateResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionStatusResource), TypeInfoPropertyName = "SessionStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType), TypeInfoPropertyName = "SessionRequiredActionResourceFunctionCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType), TypeInfoPropertyName = "SessionRequiredActionResourceEnvironmentConnectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionRequiredActionResource), TypeInfoPropertyName = "SessionRequiredActionResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType), TypeInfoPropertyName = "SessionRequiredActionResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType), TypeInfoPropertyName = "AgentToolResourceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCalling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType), TypeInfoPropertyName = "AgentToolResourceProgrammaticToolCallingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportResourceHttp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType), TypeInfoPropertyName = "McpTransportResourceHttpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportResourceStdio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType), TypeInfoPropertyName = "McpTransportResourceStdioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportResource), TypeInfoPropertyName = "McpTransportResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType), TypeInfoPropertyName = "McpTransportResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceMcp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType), TypeInfoPropertyName = "AgentToolResourceMcpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType), TypeInfoPropertyName = "AgentToolResourceWebSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResource), TypeInfoPropertyName = "AgentToolResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType), TypeInfoPropertyName = "AgentToolResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionAgentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType), TypeInfoPropertyName = "EnvironmentResourceNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHosted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType), TypeInfoPropertyName = "EnvironmentResourceOpenaiHostedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHosted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType), TypeInfoPropertyName = "EnvironmentResourceSelfHostedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResource), TypeInfoPropertyName = "EnvironmentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType), TypeInfoPropertyName = "EnvironmentResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionResourceObject), TypeInfoPropertyName = "SessionResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionRequiredActionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionListResourceObject), TypeInfoPropertyName = "SessionListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType), TypeInfoPropertyName = "AgentToolConfigParamFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType), TypeInfoPropertyName = "AgentToolConfigParamToolSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCalling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType), TypeInfoPropertyName = "AgentToolConfigParamProgrammaticToolCallingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType), TypeInfoPropertyName = "McpTransportConfigParamHttpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType), TypeInfoPropertyName = "McpTransportConfigParamStdioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportConfigParam), TypeInfoPropertyName = "McpTransportConfigParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType), TypeInfoPropertyName = "McpTransportConfigParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType), TypeInfoPropertyName = "AgentToolConfigParamMcpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType), TypeInfoPropertyName = "AgentToolConfigParamWebSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParam), TypeInfoPropertyName = "AgentToolConfigParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType), TypeInfoPropertyName = "AgentToolConfigParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionAgentConfigParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AgentToolConfigParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType), TypeInfoPropertyName = "EnvironmentParamNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHosted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType), TypeInfoPropertyName = "EnvironmentParamOpenaiHostedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHosted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType), TypeInfoPropertyName = "EnvironmentParamSelfHostedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParam), TypeInfoPropertyName = "EnvironmentParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType), TypeInfoPropertyName = "EnvironmentParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentParamInputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentParamInputTextType), TypeInfoPropertyName = "InputContentParamInputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentParamInputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentParamInputImageType), TypeInfoPropertyName = "InputContentParamInputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentParam), TypeInfoPropertyName = "InputContentParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType), TypeInfoPropertyName = "InputContentParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageParamType), TypeInfoPropertyName = "InputMessageParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageParamRole), TypeInfoPropertyName = "InputMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContentParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSessionInputParam), TypeInfoPropertyName = "CreateSessionInputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateAgentSessionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionErrorResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventErrorType), TypeInfoPropertyName = "SessionEventErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEnvironmentStatusResource), TypeInfoPropertyName = "SessionEnvironmentStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEnvironmentErrorResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEnvironmentStateResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReadyType), TypeInfoPropertyName = "SessionEventAgentSessionEnvironmentReadyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType), TypeInfoPropertyName = "SessionEventAgentSessionEnvironmentResetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDeltaType), TypeInfoPropertyName = "SessionEventAgentOutputCommandExecutionOutputDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType), TypeInfoPropertyName = "SessionEventAgentSessionCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreatedType), TypeInfoPropertyName = "SessionEventAgentSessionTurnCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgressType), TypeInfoPropertyName = "SessionEventAgentSessionTurnInProgressType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompletedType), TypeInfoPropertyName = "SessionEventAgentSessionTurnCompletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType), TypeInfoPropertyName = "SessionEventAgentSessionTurnFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType), TypeInfoPropertyName = "SessionEventAgentSessionTurnCancelledType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType), TypeInfoPropertyName = "SessionEventAgentSessionTurnItemAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionIdle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionIdleType), TypeInfoPropertyName = "SessionEventAgentSessionIdleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType), TypeInfoPropertyName = "SessionEventAgentSessionInProgressType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType), TypeInfoPropertyName = "SessionEventAgentSessionRequiresActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionFailedType), TypeInfoPropertyName = "SessionEventAgentSessionFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType), TypeInfoPropertyName = "SessionEventAgentSessionEnvironmentPendingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnectedType), TypeInfoPropertyName = "SessionEventAgentSessionEnvironmentConnectedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnectedType), TypeInfoPropertyName = "SessionEventAgentSessionEnvironmentDisconnectedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailedType), TypeInfoPropertyName = "SessionEventAgentSessionEnvironmentFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType), TypeInfoPropertyName = "SessionEventAgentSessionSubagentCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType), TypeInfoPropertyName = "SessionEventAgentSessionSubagentActiveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType), TypeInfoPropertyName = "SessionEventAgentSessionSubagentClosedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantMessageItemResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceType), TypeInfoPropertyName = "AssistantMessageItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceRole), TypeInfoPropertyName = "AssistantMessageItemResourceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputTextResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentOutputItemResource), TypeInfoPropertyName = "AgentOutputItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType), TypeInfoPropertyName = "AgentOutputItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType), TypeInfoPropertyName = "SessionEventAgentSessionTurnItemDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAddedType), TypeInfoPropertyName = "SessionEventAgentSessionTurnContentPartAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType), TypeInfoPropertyName = "SessionEventAgentSessionTurnContentPartDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType), TypeInfoPropertyName = "SessionEventAgentSessionTurnOutputTextDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType), TypeInfoPropertyName = "SessionEventAgentSessionTurnOutputTextDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType), TypeInfoPropertyName = "SessionEventAgentSessionTurnReasoningSummaryPartAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType), TypeInfoPropertyName = "SessionEventAgentSessionTurnReasoningSummaryPartDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus), TypeInfoPropertyName = "SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType), TypeInfoPropertyName = "SessionEventAgentSessionTurnReasoningSummaryTextDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType), TypeInfoPropertyName = "SessionEventAgentSessionTurnReasoningSummaryTextDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEvent), TypeInfoPropertyName = "SessionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventDiscriminatorType), TypeInfoPropertyName = "SessionEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateSessionReasoningParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateSessionAgentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateAgentSessionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedSessionResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedSessionResourceObject), TypeInfoPropertyName = "DeletedSessionResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionArtifactResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionArtifactResourceObject), TypeInfoPropertyName = "SessionArtifactResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionArtifactListResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionArtifactListResourceObject), TypeInfoPropertyName = "SessionArtifactListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionArtifactResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedSessionArtifactResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject), TypeInfoPropertyName = "DeletedSessionArtifactResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType), TypeInfoPropertyName = "SessionInputParamAgentSessionInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType), TypeInfoPropertyName = "SessionInputParamAgentSessionInputCancelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputParam), TypeInfoPropertyName = "FunctionCallOutputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType), TypeInfoPropertyName = "SessionInputParamAgentSessionInputToolResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParam), TypeInfoPropertyName = "SessionInputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType), TypeInfoPropertyName = "SessionInputParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSessionEventsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionInputParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAgentSessionSubagentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAgentSessionSubagentsResponseObject), TypeInfoPropertyName = "ListAgentSessionSubagentsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SubagentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentTypeResource?), TypeInfoPropertyName = "NullableEnvironmentTypeResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentStatusResource?), TypeInfoPropertyName = "NullableEnvironmentStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType?), TypeInfoPropertyName = "NullableHostedPluginResourceInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginResource?), TypeInfoPropertyName = "NullableHostedPluginResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType?), TypeInfoPropertyName = "NullableHostedPluginResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType?), TypeInfoPropertyName = "NullableHostedSkillResourceSkillReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType?), TypeInfoPropertyName = "NullableHostedSkillResourceInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillResource?), TypeInfoPropertyName = "NullableHostedSkillResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType?), TypeInfoPropertyName = "NullableHostedSkillResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType?), TypeInfoPropertyName = "NullableHostedEnvironmentFileResourceFileIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType?), TypeInfoPropertyName = "NullableHostedEnvironmentFileResourceInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResource?), TypeInfoPropertyName = "NullableHostedEnvironmentFileResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType?), TypeInfoPropertyName = "NullableHostedEnvironmentFileResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject?), TypeInfoPropertyName = "NullablePublicEnvironmentResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListOrderParam?), TypeInfoPropertyName = "NullableListOrderParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentFilePageObjectResource?), TypeInfoPropertyName = "NullableEnvironmentFilePageObjectResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentFileResourceObject?), TypeInfoPropertyName = "NullableEnvironmentFileResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType?), TypeInfoPropertyName = "NullableHostedEnvironmentFileParamFileIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType?), TypeInfoPropertyName = "NullableHostedEnvironmentFileParamInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParam?), TypeInfoPropertyName = "NullableHostedEnvironmentFileParam2")]
    internal sealed partial class AgentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType?), TypeInfoPropertyName = "NullableHostedEnvironmentFileParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SubagentObjectResource?), TypeInfoPropertyName = "NullableSubagentObjectResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputTextResourceType?), TypeInfoPropertyName = "NullableOutputTextResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EncryptedContentResourceType?), TypeInfoPropertyName = "NullableEncryptedContentResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentContentResource?), TypeInfoPropertyName = "NullableAgentContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType?), TypeInfoPropertyName = "NullableAgentContentResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SubagentStatusResource?), TypeInfoPropertyName = "NullableSubagentStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionMessageRoleResource?), TypeInfoPropertyName = "NullableSessionMessageRoleResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType?), TypeInfoPropertyName = "NullableMessageContentResourceInputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType?), TypeInfoPropertyName = "NullableMessageContentResourceInputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType?), TypeInfoPropertyName = "NullableMessageContentResourceOutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResource?), TypeInfoPropertyName = "NullableMessageContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType?), TypeInfoPropertyName = "NullableMessageContentResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputItemStatusResource?), TypeInfoPropertyName = "NullableOutputItemStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessagePhaseResource?), TypeInfoPropertyName = "NullableMessagePhaseResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageItemResourceType?), TypeInfoPropertyName = "NullableMessageItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SummaryTextResourceType?), TypeInfoPropertyName = "NullableSummaryTextResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemResourceType?), TypeInfoPropertyName = "NullableReasoningItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallStatusResource?), TypeInfoPropertyName = "NullableFunctionCallStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType?), TypeInfoPropertyName = "NullableFunctionCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType?), TypeInfoPropertyName = "NullableInputContentResourceInputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType?), TypeInfoPropertyName = "NullableInputContentResourceInputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentResource?), TypeInfoPropertyName = "NullableInputContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType?), TypeInfoPropertyName = "NullableInputContentResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputResource?), TypeInfoPropertyName = "NullableFunctionCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType?), TypeInfoPropertyName = "NullableFunctionCallOutputItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType?), TypeInfoPropertyName = "NullableAgentMessageItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpCallItemResourceType?), TypeInfoPropertyName = "NullableMcpCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType?), TypeInfoPropertyName = "NullableWebSearchActionResourceSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType?), TypeInfoPropertyName = "NullableWebSearchActionResourceOpenPageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType?), TypeInfoPropertyName = "NullableWebSearchActionResourceFindInPageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType?), TypeInfoPropertyName = "NullableWebSearchActionResourceOtherType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResource?), TypeInfoPropertyName = "NullableWebSearchActionResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType?), TypeInfoPropertyName = "NullableWebSearchActionResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType?), TypeInfoPropertyName = "NullableWebSearchCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType?), TypeInfoPropertyName = "NullableCommandExecutionItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType?), TypeInfoPropertyName = "NullableInterruptSubagentCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType?), TypeInfoPropertyName = "NullableCreateSubagentCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType?), TypeInfoPropertyName = "NullableSendSubagentInputCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType?), TypeInfoPropertyName = "NullableResumeSubagentCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType?), TypeInfoPropertyName = "NullableWaitForSubagentsCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType?), TypeInfoPropertyName = "NullableCloseSubagentCallItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionTurnItemResource?), TypeInfoPropertyName = "NullableSessionTurnItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType?), TypeInfoPropertyName = "NullableSessionTurnItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionItemListResourceObject?), TypeInfoPropertyName = "NullableSessionItemListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TurnObjectResource?), TypeInfoPropertyName = "NullableTurnObjectResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TurnStatusResource?), TypeInfoPropertyName = "NullableTurnStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionTurnErrorCodeResource?), TypeInfoPropertyName = "NullableSessionTurnErrorCodeResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionTurnListResourceObject?), TypeInfoPropertyName = "NullableSessionTurnListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortResource?), TypeInfoPropertyName = "NullableReasoningEffortResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningSummaryResource?), TypeInfoPropertyName = "NullableReasoningSummaryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatResourceTextType?), TypeInfoPropertyName = "NullableTextFormatResourceTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType?), TypeInfoPropertyName = "NullableTextFormatResourceJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatResource?), TypeInfoPropertyName = "NullableTextFormatResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType?), TypeInfoPropertyName = "NullableTextFormatResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VerbosityResource?), TypeInfoPropertyName = "NullableVerbosityResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ServiceTierResource?), TypeInfoPropertyName = "NullableServiceTierResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType?), TypeInfoPropertyName = "NullablePersistedAgentToolResourceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType?), TypeInfoPropertyName = "NullablePersistedAgentToolResourceToolSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType?), TypeInfoPropertyName = "NullablePersistedAgentToolResourceProgrammaticToolCallingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType?), TypeInfoPropertyName = "NullablePersistedMcpTransportResourceHttpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType?), TypeInfoPropertyName = "NullablePersistedMcpTransportResourceStdioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportResource?), TypeInfoPropertyName = "NullablePersistedMcpTransportResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType?), TypeInfoPropertyName = "NullablePersistedMcpTransportResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpConnectionOriginResource?), TypeInfoPropertyName = "NullableMcpConnectionOriginResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType?), TypeInfoPropertyName = "NullablePersistedAgentToolResourceMcpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchModeResource?), TypeInfoPropertyName = "NullableWebSearchModeResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource?), TypeInfoPropertyName = "NullableWebSearchContextSizeResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType?), TypeInfoPropertyName = "NullablePersistedAgentToolResourceWebSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResource?), TypeInfoPropertyName = "NullablePersistedAgentToolResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType?), TypeInfoPropertyName = "NullablePersistedAgentToolResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentResourceObject?), TypeInfoPropertyName = "NullableAgentResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentListResourceObject?), TypeInfoPropertyName = "NullableAgentListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortParam?), TypeInfoPropertyName = "NullableReasoningEffortParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningSummaryParam?), TypeInfoPropertyName = "NullableReasoningSummaryParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatParamTextType?), TypeInfoPropertyName = "NullableTextFormatParamTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType?), TypeInfoPropertyName = "NullableTextFormatParamJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatParam?), TypeInfoPropertyName = "NullableTextFormatParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType?), TypeInfoPropertyName = "NullableTextFormatParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VerbosityParam?), TypeInfoPropertyName = "NullableVerbosityParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ServiceTierParam?), TypeInfoPropertyName = "NullableServiceTierParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType?), TypeInfoPropertyName = "NullablePersistedAgentToolConfigParamFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType?), TypeInfoPropertyName = "NullablePersistedAgentToolConfigParamToolSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType?), TypeInfoPropertyName = "NullablePersistedAgentToolConfigParamProgrammaticToolCallingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType?), TypeInfoPropertyName = "NullablePersistedMcpTransportConfigParamHttpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType?), TypeInfoPropertyName = "NullablePersistedMcpTransportConfigParamStdioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParam?), TypeInfoPropertyName = "NullablePersistedMcpTransportConfigParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType?), TypeInfoPropertyName = "NullablePersistedMcpTransportConfigParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpConnectionOriginParam?), TypeInfoPropertyName = "NullableMcpConnectionOriginParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType?), TypeInfoPropertyName = "NullablePersistedAgentToolConfigParamMcpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchModeParam?), TypeInfoPropertyName = "NullableWebSearchModeParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam?), TypeInfoPropertyName = "NullableWebSearchContextSizeParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType?), TypeInfoPropertyName = "NullablePersistedAgentToolConfigParamWebSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParam?), TypeInfoPropertyName = "NullablePersistedAgentToolConfigParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType?), TypeInfoPropertyName = "NullablePersistedAgentToolConfigParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedAgentResourceObject?), TypeInfoPropertyName = "NullableDeletedAgentResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkAccessResource?), TypeInfoPropertyName = "NullableNetworkAccessResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType?), TypeInfoPropertyName = "NullableHostedTemplateSkillResourceSkillReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType?), TypeInfoPropertyName = "NullableHostedTemplateSkillResourceInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateSkillResource?), TypeInfoPropertyName = "NullableHostedTemplateSkillResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType?), TypeInfoPropertyName = "NullableHostedTemplateSkillResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType?), TypeInfoPropertyName = "NullableHostedTemplateFileResourceFileIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType?), TypeInfoPropertyName = "NullableHostedTemplateFileResourceInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateFileResource?), TypeInfoPropertyName = "NullableHostedTemplateFileResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType?), TypeInfoPropertyName = "NullableHostedTemplateFileResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject?), TypeInfoPropertyName = "NullableEnvironmentTemplateResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject?), TypeInfoPropertyName = "NullableEnvironmentTemplateListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkAccessParam?), TypeInfoPropertyName = "NullableNetworkAccessParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType?), TypeInfoPropertyName = "NullableHostedSkillParamSkillReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type?), TypeInfoPropertyName = "NullableInlineCapabilitySourceParamBase64Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType?), TypeInfoPropertyName = "NullableInlineCapabilitySourceParamBase64MediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParam?), TypeInfoPropertyName = "NullableInlineCapabilitySourceParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType?), TypeInfoPropertyName = "NullableInlineCapabilitySourceParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType?), TypeInfoPropertyName = "NullableHostedSkillParamInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillParam?), TypeInfoPropertyName = "NullableHostedSkillParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType?), TypeInfoPropertyName = "NullableHostedSkillParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType?), TypeInfoPropertyName = "NullableHostedPluginParamInlineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginParam?), TypeInfoPropertyName = "NullableHostedPluginParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType?), TypeInfoPropertyName = "NullableHostedPluginParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject?), TypeInfoPropertyName = "NullableDeletedEnvironmentTemplateResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionStatusResource?), TypeInfoPropertyName = "NullableSessionStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType?), TypeInfoPropertyName = "NullableSessionRequiredActionResourceFunctionCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType?), TypeInfoPropertyName = "NullableSessionRequiredActionResourceEnvironmentConnectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionRequiredActionResource?), TypeInfoPropertyName = "NullableSessionRequiredActionResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType?), TypeInfoPropertyName = "NullableSessionRequiredActionResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType?), TypeInfoPropertyName = "NullableAgentToolResourceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType?), TypeInfoPropertyName = "NullableAgentToolResourceProgrammaticToolCallingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType?), TypeInfoPropertyName = "NullableMcpTransportResourceHttpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType?), TypeInfoPropertyName = "NullableMcpTransportResourceStdioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportResource?), TypeInfoPropertyName = "NullableMcpTransportResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType?), TypeInfoPropertyName = "NullableMcpTransportResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType?), TypeInfoPropertyName = "NullableAgentToolResourceMcpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType?), TypeInfoPropertyName = "NullableAgentToolResourceWebSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResource?), TypeInfoPropertyName = "NullableAgentToolResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType?), TypeInfoPropertyName = "NullableAgentToolResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType?), TypeInfoPropertyName = "NullableEnvironmentResourceNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType?), TypeInfoPropertyName = "NullableEnvironmentResourceOpenaiHostedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType?), TypeInfoPropertyName = "NullableEnvironmentResourceSelfHostedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResource?), TypeInfoPropertyName = "NullableEnvironmentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType?), TypeInfoPropertyName = "NullableEnvironmentResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionResourceObject?), TypeInfoPropertyName = "NullableSessionResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionListResourceObject?), TypeInfoPropertyName = "NullableSessionListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType?), TypeInfoPropertyName = "NullableAgentToolConfigParamFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType?), TypeInfoPropertyName = "NullableAgentToolConfigParamToolSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType?), TypeInfoPropertyName = "NullableAgentToolConfigParamProgrammaticToolCallingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType?), TypeInfoPropertyName = "NullableMcpTransportConfigParamHttpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType?), TypeInfoPropertyName = "NullableMcpTransportConfigParamStdioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportConfigParam?), TypeInfoPropertyName = "NullableMcpTransportConfigParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType?), TypeInfoPropertyName = "NullableMcpTransportConfigParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType?), TypeInfoPropertyName = "NullableAgentToolConfigParamMcpType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType?), TypeInfoPropertyName = "NullableAgentToolConfigParamWebSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParam?), TypeInfoPropertyName = "NullableAgentToolConfigParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType?), TypeInfoPropertyName = "NullableAgentToolConfigParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType?), TypeInfoPropertyName = "NullableEnvironmentParamNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType?), TypeInfoPropertyName = "NullableEnvironmentParamOpenaiHostedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType?), TypeInfoPropertyName = "NullableEnvironmentParamSelfHostedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParam?), TypeInfoPropertyName = "NullableEnvironmentParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType?), TypeInfoPropertyName = "NullableEnvironmentParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentParamInputTextType?), TypeInfoPropertyName = "NullableInputContentParamInputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentParamInputImageType?), TypeInfoPropertyName = "NullableInputContentParamInputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentParam?), TypeInfoPropertyName = "NullableInputContentParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType?), TypeInfoPropertyName = "NullableInputContentParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageParamType?), TypeInfoPropertyName = "NullableInputMessageParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageParamRole?), TypeInfoPropertyName = "NullableInputMessageParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateSessionInputParam?), TypeInfoPropertyName = "NullableCreateSessionInputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventErrorType?), TypeInfoPropertyName = "NullableSessionEventErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEnvironmentStatusResource?), TypeInfoPropertyName = "NullableSessionEnvironmentStatusResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReadyType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionEnvironmentReadyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionEnvironmentResetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDeltaType?), TypeInfoPropertyName = "NullableSessionEventAgentOutputCommandExecutionOutputDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreatedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgressType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnInProgressType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompletedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnCompletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnCancelledType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnItemAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionIdleType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionIdleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionInProgressType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionRequiresActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionFailedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionEnvironmentPendingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnectedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionEnvironmentConnectedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnectedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionEnvironmentDisconnectedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionEnvironmentFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionSubagentCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionSubagentActiveType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionSubagentClosedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceType?), TypeInfoPropertyName = "NullableAssistantMessageItemResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceRole?), TypeInfoPropertyName = "NullableAssistantMessageItemResourceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentOutputItemResource?), TypeInfoPropertyName = "NullableAgentOutputItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType?), TypeInfoPropertyName = "NullableAgentOutputItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnItemDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAddedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnContentPartAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnContentPartDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnOutputTextDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnOutputTextDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnReasoningSummaryPartAddedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnReasoningSummaryPartDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnReasoningSummaryPartDoneStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnReasoningSummaryTextDeltaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType?), TypeInfoPropertyName = "NullableSessionEventAgentSessionTurnReasoningSummaryTextDoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEvent?), TypeInfoPropertyName = "NullableSessionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionEventDiscriminatorType?), TypeInfoPropertyName = "NullableSessionEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedSessionResourceObject?), TypeInfoPropertyName = "NullableDeletedSessionResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionArtifactResourceObject?), TypeInfoPropertyName = "NullableSessionArtifactResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionArtifactListResourceObject?), TypeInfoPropertyName = "NullableSessionArtifactListResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject?), TypeInfoPropertyName = "NullableDeletedSessionArtifactResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType?), TypeInfoPropertyName = "NullableSessionInputParamAgentSessionInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType?), TypeInfoPropertyName = "NullableSessionInputParamAgentSessionInputCancelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputParam?), TypeInfoPropertyName = "NullableFunctionCallOutputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType?), TypeInfoPropertyName = "NullableSessionInputParamAgentSessionInputToolResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParam?), TypeInfoPropertyName = "NullableSessionInputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType?), TypeInfoPropertyName = "NullableSessionInputParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListAgentSessionSubagentsResponseObject?), TypeInfoPropertyName = "NullableListAgentSessionSubagentsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EnvironmentFileResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentContentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MessageContentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionTurnItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TurnResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.PersistedAgentToolConfigParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateSkillResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedTemplateFileResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.EnvironmentTemplateResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SetupCommandParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedSkillParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedPluginParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.HostedEnvironmentFileParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionRequiredActionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AgentToolConfigParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContentParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputTextResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionArtifactResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SessionInputParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SubagentResource>))]
    internal sealed partial class AgentsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AgentContentResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputContentResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SessionTurnItemResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.TextFormatParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputContentParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateSessionInputParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AgentOutputItemResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SessionEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SessionInputParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentStatusResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListOrderParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListOrderParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentFilePageObjectResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentFilePageObjectResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentFileResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentFileResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SubagentObjectResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SubagentObjectResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SubagentStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SubagentStatusResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionMessageRoleResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionMessageRoleResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemStatusResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionItemListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionItemListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TurnObjectResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TurnObjectResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TurnStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TurnStatusResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnErrorCodeResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnErrorCodeResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedAgentResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedAgentResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionStatusResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEnvironmentStatusResource)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEnvironmentStatusResource?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReadyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReadyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgressType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgressType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompletedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompletedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionIdleType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionIdleType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionFailedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionFailedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnectedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnectedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnectedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnectedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAddedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAddedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedSessionResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedSessionResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionArtifactResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionArtifactResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionArtifactListResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionArtifactListResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListAgentSessionSubagentsResponseObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListAgentSessionSubagentsResponseObject?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTypeResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTypeResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTypeResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentStatusResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceSkillReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceSkillReferenceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceSkillReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceFileIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileIdType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceFileIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PublicEnvironmentResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PublicEnvironmentResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PublicEnvironmentResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListOrderParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListOrderParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListOrderParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListOrderParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentFilePageObjectResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentFilePageObjectResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentFilePageObjectResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentFilePageObjectResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentFileResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentFileResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentFileResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentFileResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamFileIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileIdType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamFileIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedEnvironmentFileParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SubagentObjectResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SubagentObjectResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SubagentObjectResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SubagentObjectResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EncryptedContentResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EncryptedContentResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EncryptedContentResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentContentResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentContentResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentContentResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SubagentStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SubagentStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SubagentStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SubagentStatusResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionMessageRoleResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionMessageRoleResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionMessageRoleResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionMessageRoleResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceInputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceInputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceInputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceInputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceInputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceOutputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceOutputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceOutputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputItemStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputItemStatusResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhaseResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhaseResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhaseResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SummaryTextResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SummaryTextResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceInputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceInputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceInputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceInputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceInputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentMessageItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentMessageItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentMessageItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceOpenPageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOpenPageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceOpenPageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceFindInPageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceFindInPageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceFindInPageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceOtherTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceOtherType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceOtherTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CommandExecutionItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CommandExecutionItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CommandExecutionItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InterruptSubagentCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InterruptSubagentCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InterruptSubagentCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSubagentCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateSubagentCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateSubagentCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SendSubagentInputCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SendSubagentInputCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SendSubagentInputCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResumeSubagentCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResumeSubagentCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResumeSubagentCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WaitForSubagentsCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WaitForSubagentsCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WaitForSubagentsCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CloseSubagentCallItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CloseSubagentCallItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CloseSubagentCallItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionTurnItemResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnItemResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionTurnItemResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionItemListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionItemListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionItemListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionItemListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TurnObjectResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TurnObjectResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TurnObjectResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TurnObjectResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TurnStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TurnStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TurnStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TurnStatusResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnErrorCodeResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionTurnErrorCodeResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnErrorCodeResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionTurnErrorCodeResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionTurnListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionTurnListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionTurnListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceToolSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceToolSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceToolSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceProgrammaticToolCallingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceProgrammaticToolCallingType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceProgrammaticToolCallingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceHttpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceHttpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceHttpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceStdioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceStdioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceStdioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceMcpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceMcpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceMcpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchModeResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchModeResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceWebSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceWebSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceWebSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummaryParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextFormatParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextFormatParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamToolSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamToolSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamToolSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamProgrammaticToolCallingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamProgrammaticToolCallingType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamProgrammaticToolCallingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamHttpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamHttpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamStdioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamStdioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedMcpTransportConfigParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpConnectionOriginParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpConnectionOriginParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamMcpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamMcpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamMcpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchModeParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchModeParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchModeParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchContextSizeParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchContextSizeParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamWebSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamWebSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamWebSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersistedAgentToolConfigParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersistedAgentToolConfigParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedAgentResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedAgentResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedAgentResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedAgentResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceSkillReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceSkillReferenceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceSkillReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateSkillResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateSkillResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceFileIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileIdType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceFileIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedTemplateFileResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTemplateResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTemplateResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTemplateListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentTemplateListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentTemplateListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NetworkAccessParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NetworkAccessParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamSkillReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamSkillReferenceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamSkillReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64MediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamBase64MediaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamBase64MediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineCapabilitySourceParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineCapabilitySourceParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedSkillParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedSkillParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamInlineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamInlineType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamInlineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HostedPluginParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HostedPluginParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedEnvironmentTemplateResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedEnvironmentTemplateResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedEnvironmentTemplateResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionStatusResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceFunctionCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceFunctionCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceFunctionCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceEnvironmentConnectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceEnvironmentConnectionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceEnvironmentConnectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionRequiredActionResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionRequiredActionResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceProgrammaticToolCallingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceProgrammaticToolCallingType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceProgrammaticToolCallingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceHttpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceHttpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceHttpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceStdioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceStdioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceStdioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceMcpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceMcpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceMcpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceWebSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceWebSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceWebSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceNoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceNoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceNoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceOpenaiHostedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceOpenaiHostedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceOpenaiHostedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceSelfHostedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceSelfHostedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceSelfHostedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamToolSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamToolSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamToolSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamProgrammaticToolCallingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamProgrammaticToolCallingType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamProgrammaticToolCallingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamHttpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamHttpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamHttpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamStdioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamStdioType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamStdioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.McpTransportConfigParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.McpTransportConfigParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamMcpTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamMcpType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamMcpTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamWebSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamWebSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamWebSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentToolConfigParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentToolConfigParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamNoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamNoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamNoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamOpenaiHostedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamOpenaiHostedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamOpenaiHostedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamSelfHostedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamSelfHostedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamSelfHostedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EnvironmentParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EnvironmentParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamInputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamInputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEnvironmentStatusResource))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEnvironmentStatusResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEnvironmentStatusResource?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEnvironmentStatusResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReadyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentReadyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReadyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentReadyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentResetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentResetType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentResetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentOutputCommandExecutionOutputDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentOutputCommandExecutionOutputDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionCreatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionCreatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionCreatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnCreatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnCreatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgressType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnInProgressTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgressType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnInProgressTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompletedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnCompletedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompletedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnCompletedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnFailedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnFailedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnCancelledTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelledType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnCancelledTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnItemAddedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAddedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnItemAddedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionIdleType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionIdleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionIdleType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionIdleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionInProgressTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgressType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionInProgressTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionRequiresActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionRequiresActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionFailedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionFailedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionFailedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionFailedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentPendingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPendingType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentPendingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnectedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentConnectedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnectedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentConnectedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnectedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentDisconnectedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnectedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentDisconnectedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentFailedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionEnvironmentFailedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionSubagentCreatedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreatedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionSubagentCreatedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionSubagentActiveTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActiveType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionSubagentActiveTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionSubagentClosedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionSubagentClosedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemResourceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AssistantMessageItemResourceRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AssistantMessageItemResourceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentOutputItemResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AgentOutputItemResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AgentOutputItemResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnItemDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnItemDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAddedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnContentPartAddedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAddedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnContentPartAddedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnContentPartDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnContentPartDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnOutputTextDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnOutputTextDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnOutputTextDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnOutputTextDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryPartAddedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAddedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryPartAddedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryPartDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryPartDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryPartDoneStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryTextDeltaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDeltaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryTextDeltaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryTextDoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDoneType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnReasoningSummaryTextDoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedSessionResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedSessionResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedSessionResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedSessionResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionArtifactResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionArtifactResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionArtifactResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionArtifactResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionArtifactListResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionArtifactListResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionArtifactListResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionArtifactListResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedSessionArtifactResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedSessionArtifactResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedSessionArtifactResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputCancelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancelType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputCancelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputToolResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResultType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamAgentSessionInputToolResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SessionInputParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListAgentSessionSubagentsResponseObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListAgentSessionSubagentsResponseObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListAgentSessionSubagentsResponseObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListAgentSessionSubagentsResponseObjectNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new AgentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new AgentsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}