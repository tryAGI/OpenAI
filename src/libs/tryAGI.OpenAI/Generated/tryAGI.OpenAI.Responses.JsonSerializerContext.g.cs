
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationResultBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolType), TypeInfoPropertyName = "CodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>), TypeInfoPropertyName = "OneOfStringAutoCodeInterpreterToolParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CallableToolAllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller), TypeInfoPropertyName = "CallableToolAllowedCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType), TypeInfoPropertyName = "CodeInterpreterToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus), TypeInfoPropertyName = "CodeInterpreterToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputsVariant1Item), TypeInfoPropertyName = "OutputsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComparisonFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComparisonFilterType), TypeInfoPropertyName = "ComparisonFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>), TypeInfoPropertyName = "OneOfStringDoubleBooleanIListOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilterType), TypeInfoPropertyName = "CompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FiltersItem), TypeInfoPropertyName = "FiltersItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilterFilterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerAction), TypeInfoPropertyName = "ComputerAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClickParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DoubleClickAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DragParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.KeyPressAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MoveParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ScreenshotParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ScrollParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TypeParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WaitParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType), TypeInfoPropertyName = "ComputerActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerScreenshotImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType), TypeInfoPropertyName = "ComputerScreenshotImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallType), TypeInfoPropertyName = "ComputerToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerCallSafetyCheckParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallStatus), TypeInfoPropertyName = "ComputerToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType), TypeInfoPropertyName = "ComputerToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus), TypeInfoPropertyName = "ComputerToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResource), TypeInfoPropertyName = "ComputerToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus), TypeInfoPropertyName = "ComputerCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContent), TypeInfoPropertyName = "InputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputContent), TypeInfoPropertyName = "OutputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallResource), TypeInfoPropertyName = "FunctionToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResource), TypeInfoPropertyName = "FunctionToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdditionalTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Program))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPListTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalResponseResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationParam), TypeInfoPropertyName = "ConversationParam2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationParam2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortEnum), TypeInfoPropertyName = "ReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModelResponseProperties), TypeInfoPropertyName = "CreateModelResponseProperties2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsShared), TypeInfoPropertyName = "ModelIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VerbosityEnum), TypeInfoPropertyName = "VerbosityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillReferenceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EasyInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Tool), TypeInfoPropertyName = "Tool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextResponseFormatConfiguration), TypeInfoPropertyName = "TextResponseFormatConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFidelity), TypeInfoPropertyName = "InputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModelResponsePropertiesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheOptionsParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateResponse), TypeInfoPropertyName = "CreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AccessProgramsParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponsePromptCacheOptionsParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum), TypeInfoPropertyName = "ServiceTierResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation), TypeInfoPropertyName = "CreateResponseVariant3Truncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Reasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputParam), TypeInfoPropertyName = "InputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.IncludeEnum), TypeInfoPropertyName = "IncludeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseStreamOptionsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContextManagementParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContextManagementParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallType), TypeInfoPropertyName = "CustomToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolCallCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallOutputType), TypeInfoPropertyName = "CustomToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolCallCallerParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>), TypeInfoPropertyName = "OneOfStringIListFunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput), TypeInfoPropertyName = "FunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallOutputResource), TypeInfoPropertyName = "CustomToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum), TypeInfoPropertyName = "FunctionCallOutputStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallResource), TypeInfoPropertyName = "CustomToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallStatus), TypeInfoPropertyName = "FunctionCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EasyInputMessageRole), TypeInfoPropertyName = "EasyInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>), TypeInfoPropertyName = "OneOfStringIListInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessagePhase), TypeInfoPropertyName = "MessagePhase2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EasyInputMessageType), TypeInfoPropertyName = "EasyInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FilePathType), TypeInfoPropertyName = "FilePathType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolCallType), TypeInfoPropertyName = "FileSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus), TypeInfoPropertyName = "FileSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType), TypeInfoPropertyName = "FunctionAndCustomToolCallOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallType), TypeInfoPropertyName = "FunctionToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallStatus), TypeInfoPropertyName = "FunctionToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType), TypeInfoPropertyName = "FunctionToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus), TypeInfoPropertyName = "FunctionToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolType), TypeInfoPropertyName = "ImageGenToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>), TypeInfoPropertyName = "AnyOfStringImageGenToolModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolModel), TypeInfoPropertyName = "ImageGenToolModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolQuality), TypeInfoPropertyName = "ImageGenToolQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>), TypeInfoPropertyName = "AnyOfStringImageGenToolSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolSize), TypeInfoPropertyName = "ImageGenToolSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat), TypeInfoPropertyName = "ImageGenToolOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolModeration), TypeInfoPropertyName = "ImageGenToolModeration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolBackground), TypeInfoPropertyName = "ImageGenToolBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolInputImageMask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenActionEnum), TypeInfoPropertyName = "ImageGenActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType), TypeInfoPropertyName = "InputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputItem), TypeInfoPropertyName = "InputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Item), TypeInfoPropertyName = "Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionTriggerItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemReferenceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType), TypeInfoPropertyName = "InputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageType), TypeInfoPropertyName = "InputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageRole), TypeInfoPropertyName = "InputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageStatus), TypeInfoPropertyName = "InputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageResource), TypeInfoPropertyName = "InputMessageResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchCallItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdditionalToolsItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionSummaryItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemDiscriminatorType), TypeInfoPropertyName = "ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemResource), TypeInfoPropertyName = "ItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemResourceDiscriminatorType), TypeInfoPropertyName = "ItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallType), TypeInfoPropertyName = "LocalShellToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellExecAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus), TypeInfoPropertyName = "LocalShellToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType), TypeInfoPropertyName = "LocalShellToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus), TypeInfoPropertyName = "LocalShellToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalRequestType), TypeInfoPropertyName = "MCPApprovalRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalResponseType), TypeInfoPropertyName = "MCPApprovalResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType), TypeInfoPropertyName = "MCPApprovalResponseResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPListToolsType), TypeInfoPropertyName = "MCPListToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.MCPListToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPListToolsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolType), TypeInfoPropertyName = "MCPToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolConnectorId), TypeInfoPropertyName = "MCPToolConnectorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2), TypeInfoPropertyName = "MCPToolRequireApprovalVariant1Enum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCallType), TypeInfoPropertyName = "MCPToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCallError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCallStatus), TypeInfoPropertyName = "MCPToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPProtocolError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolExecutionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HTTPError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType), TypeInfoPropertyName = "MCPToolCallErrorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsResponses), TypeInfoPropertyName = "ModelIdsResponses2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsCompaction), TypeInfoPropertyName = "ModelIdsCompaction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum), TypeInfoPropertyName = "ModelIdsResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum), TypeInfoPropertyName = "ModelIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention), TypeInfoPropertyName = "ModelResponsePropertiesPromptCacheRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RefusalContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType), TypeInfoPropertyName = "OutputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputItem), TypeInfoPropertyName = "OutputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType), TypeInfoPropertyName = "OutputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageType), TypeInfoPropertyName = "OutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageRole), TypeInfoPropertyName = "OutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputMessageContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContent), TypeInfoPropertyName = "OutputMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageStatus), TypeInfoPropertyName = "OutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType), TypeInfoPropertyName = "OutputMessageContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceOptions), TypeInfoPropertyName = "ToolChoiceOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceMCP))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningModeEnum), TypeInfoPropertyName = "ReasoningModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningSummary), TypeInfoPropertyName = "ReasoningSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningContext), TypeInfoPropertyName = "ReasoningContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary), TypeInfoPropertyName = "ReasoningGenerateSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemType), TypeInfoPropertyName = "ReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SummaryTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemStatus), TypeInfoPropertyName = "ReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Response), TypeInfoPropertyName = "Response2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation), TypeInfoPropertyName = "ResponseVariant3Truncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3Object), TypeInfoPropertyName = "ResponseVariant3Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3Status), TypeInfoPropertyName = "ResponseVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AccessProgramsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason), TypeInfoPropertyName = "ResponseVariant3IncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheDiagnostics), TypeInfoPropertyName = "PromptCacheDiagnostics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Moderation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType), TypeInfoPropertyName = "ResponseAudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType), TypeInfoPropertyName = "ResponseAudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType), TypeInfoPropertyName = "ResponseAudioTranscriptDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType), TypeInfoPropertyName = "ResponseAudioTranscriptDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallCodeDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallCodeDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType), TypeInfoPropertyName = "ResponseCodeInterpreterCallInterpretingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCompletedEventType), TypeInfoPropertyName = "ResponseCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType), TypeInfoPropertyName = "ResponseConfigurationUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType), TypeInfoPropertyName = "ResponseConfigurationUpdateItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType), TypeInfoPropertyName = "ResponseContentPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType), TypeInfoPropertyName = "ResponseContentPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCreatedEventType), TypeInfoPropertyName = "ResponseCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType), TypeInfoPropertyName = "ResponseCustomToolCallInputDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType), TypeInfoPropertyName = "ResponseCustomToolCallInputDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseErrorCode), TypeInfoPropertyName = "ResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseErrorEventType), TypeInfoPropertyName = "ResponseErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFailedEventType), TypeInfoPropertyName = "ResponseFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType), TypeInfoPropertyName = "ResponseFileSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType), TypeInfoPropertyName = "ResponseFileSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType), TypeInfoPropertyName = "ResponseFileSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType), TypeInfoPropertyName = "ResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonSchemaSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatTextType), TypeInfoPropertyName = "ResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType), TypeInfoPropertyName = "ResponseFunctionCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType), TypeInfoPropertyName = "ResponseFunctionCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType), TypeInfoPropertyName = "ResponseImageGenCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType), TypeInfoPropertyName = "ResponseImageGenCallGeneratingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType), TypeInfoPropertyName = "ResponseImageGenCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType), TypeInfoPropertyName = "ResponseImageGenCallPartialImageEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseInProgressEventType), TypeInfoPropertyName = "ResponseInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType), TypeInfoPropertyName = "ResponseIncompleteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseItemList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseItemListObject), TypeInfoPropertyName = "ResponseItemListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseLogProb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseLogProbTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType), TypeInfoPropertyName = "ResponseMCPCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType), TypeInfoPropertyName = "ResponseMCPCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType), TypeInfoPropertyName = "ResponseMCPCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType), TypeInfoPropertyName = "ResponseMCPCallFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType), TypeInfoPropertyName = "ResponseMCPCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType), TypeInfoPropertyName = "ResponseMCPListToolsCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType), TypeInfoPropertyName = "ResponseMCPListToolsFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType), TypeInfoPropertyName = "ResponseMCPListToolsInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType), TypeInfoPropertyName = "ResponseOutputItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType), TypeInfoPropertyName = "ResponseOutputItemDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType), TypeInfoPropertyName = "ResponseOutputTextAnnotationAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Annotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>), TypeInfoPropertyName = "OneOfStringInputTextContentInputImageContentInputFileContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceParam), TypeInfoPropertyName = "ToolChoiceParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseQueuedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseQueuedEventType), TypeInfoPropertyName = "ResponseQueuedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType), TypeInfoPropertyName = "ResponseReasoningSummaryPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType), TypeInfoPropertyName = "ResponseReasoningSummaryPartAddedEventPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType), TypeInfoPropertyName = "ResponseReasoningSummaryPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus), TypeInfoPropertyName = "ResponseReasoningSummaryPartDoneEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType), TypeInfoPropertyName = "ResponseReasoningSummaryPartDoneEventPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType), TypeInfoPropertyName = "ResponseReasoningSummaryTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType), TypeInfoPropertyName = "ResponseReasoningSummaryTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType), TypeInfoPropertyName = "ResponseReasoningTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType), TypeInfoPropertyName = "ResponseReasoningTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType), TypeInfoPropertyName = "ResponseRefusalDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType), TypeInfoPropertyName = "ResponseRefusalDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseStreamEvent), TypeInfoPropertyName = "ResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType), TypeInfoPropertyName = "ResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType), TypeInfoPropertyName = "ResponseTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType), TypeInfoPropertyName = "ResponseTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseUsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseUsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType), TypeInfoPropertyName = "ResponseWebSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType), TypeInfoPropertyName = "ResponseWebSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType), TypeInfoPropertyName = "ResponseWebSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType), TypeInfoPropertyName = "TextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerUsePreviewTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NamespaceToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchPreviewTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolDiscriminatorType), TypeInfoPropertyName = "ToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceAllowed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType), TypeInfoPropertyName = "ToolChoiceAllowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode), TypeInfoPropertyName = "ToolChoiceAllowedMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceCustomType), TypeInfoPropertyName = "ToolChoiceCustomType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType), TypeInfoPropertyName = "ToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceMCPType), TypeInfoPropertyName = "ToolChoiceMCPType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificApplyPatchParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificFunctionShellParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceTypesType), TypeInfoPropertyName = "ToolChoiceTypesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?>), TypeInfoPropertyName = "OneOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionFind))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionFindType), TypeInfoPropertyName = "WebSearchActionFindType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionOpenPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType), TypeInfoPropertyName = "WebSearchActionOpenPageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionSearchType), TypeInfoPropertyName = "WebSearchActionSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.WebSearchActionSearchSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionSearchSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType), TypeInfoPropertyName = "WebSearchActionSearchSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type), TypeInfoPropertyName = "WebSearchApproximateLocationWebSearchApproximateLocation1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolType), TypeInfoPropertyName = "WebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize), TypeInfoPropertyName = "WebSearchToolSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCallType), TypeInfoPropertyName = "WebSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchCallStatus), TypeInfoPropertyName = "WebSearchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCallAction), TypeInfoPropertyName = "WebSearchToolCallAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType), TypeInfoPropertyName = "WebSearchToolCallActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType), TypeInfoPropertyName = "MisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum), TypeInfoPropertyName = "MisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationInputType), TypeInfoPropertyName = "ModerationInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationResultBodyType), TypeInfoPropertyName = "ModerationResultBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ModerationInputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum), TypeInfoPropertyName = "PromptCacheTTLEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheModeEnum), TypeInfoPropertyName = "PromptCacheModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode), TypeInfoPropertyName = "PromptCacheBreakpointParamMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationMode), TypeInfoPropertyName = "ModerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationConfigParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationPolicyParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillReferenceParamType), TypeInfoPropertyName = "SkillReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillSourceParam))]
    internal sealed partial class ResponsesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType), TypeInfoPropertyName = "InlineSkillSourceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType), TypeInfoPropertyName = "InlineSkillSourceParamMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillParamType), TypeInfoPropertyName = "InlineSkillParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType), TypeInfoPropertyName = "ContainerNetworkPolicyDisabledParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType), TypeInfoPropertyName = "ContainerNetworkPolicyAllowlistParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStatus), TypeInfoPropertyName = "MessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageRole), TypeInfoPropertyName = "MessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode), TypeInfoPropertyName = "PromptCacheBreakpointConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentType), TypeInfoPropertyName = "InputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileCitationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileCitationBodyType), TypeInfoPropertyName = "FileCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UrlCitationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UrlCitationBodyType), TypeInfoPropertyName = "UrlCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerFileCitationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType), TypeInfoPropertyName = "ContainerFileCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnnotationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType), TypeInfoPropertyName = "AnnotationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TopLogProb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LogProb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TopLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputTextContentType), TypeInfoPropertyName = "OutputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextContentType), TypeInfoPropertyName = "TextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SummaryTextContentType), TypeInfoPropertyName = "SummaryTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningTextContentType), TypeInfoPropertyName = "ReasoningTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RefusalContentType), TypeInfoPropertyName = "RefusalContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageDetail), TypeInfoPropertyName = "ImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContentType), TypeInfoPropertyName = "InputImageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerScreenshotContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType), TypeInfoPropertyName = "ComputerScreenshotContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileInputDetail), TypeInfoPropertyName = "FileInputDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContentType), TypeInfoPropertyName = "InputFileContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessagePhase2), TypeInfoPropertyName = "MessagePhase22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageType), TypeInfoPropertyName = "MessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem3), TypeInfoPropertyName = "ContentItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType), TypeInfoPropertyName = "MessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DirectToolCallCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DirectToolCallCallerType), TypeInfoPropertyName = "DirectToolCallCallerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramToolCallCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType), TypeInfoPropertyName = "ProgramToolCallCallerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType), TypeInfoPropertyName = "ToolCallCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DirectToolCallCallerParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType), TypeInfoPropertyName = "DirectToolCallCallerParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType), TypeInfoPropertyName = "ProgramToolCallCallerParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType), TypeInfoPropertyName = "ToolCallCallerParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageBackground), TypeInfoPropertyName = "ImageBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageOutputFormat), TypeInfoPropertyName = "ImageOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCallType), TypeInfoPropertyName = "ImageGenToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus), TypeInfoPropertyName = "ImageGenToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1), TypeInfoPropertyName = "ImageGenToolCallSizeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality), TypeInfoPropertyName = "ImageGenToolCallQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClickButtonType), TypeInfoPropertyName = "ClickButtonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClickParamType), TypeInfoPropertyName = "ClickParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DoubleClickActionType), TypeInfoPropertyName = "DoubleClickActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CoordParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DragParamType), TypeInfoPropertyName = "DragParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CoordParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.KeyPressActionType), TypeInfoPropertyName = "KeyPressActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MoveParamType), TypeInfoPropertyName = "MoveParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ScreenshotParamType), TypeInfoPropertyName = "ScreenshotParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ScrollParamType), TypeInfoPropertyName = "ScrollParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TypeParamType), TypeInfoPropertyName = "TypeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WaitParamType), TypeInfoPropertyName = "WaitParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchExecutionType), TypeInfoPropertyName = "ToolSearchExecutionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchCallType), TypeInfoPropertyName = "ToolSearchCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolType), TypeInfoPropertyName = "FunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RankerVersionType), TypeInfoPropertyName = "RankerVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HybridSearchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Filters2), TypeInfoPropertyName = "Filters22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolType), TypeInfoPropertyName = "FileSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolType), TypeInfoPropertyName = "ComputerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerEnvironment), TypeInfoPropertyName = "ComputerEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType), TypeInfoPropertyName = "ComputerUsePreviewToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerMemoryLimit), TypeInfoPropertyName = "ContainerMemoryLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType), TypeInfoPropertyName = "AutoCodeInterpreterToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicy2), TypeInfoPropertyName = "NetworkPolicy22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType), TypeInfoPropertyName = "AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType), TypeInfoPropertyName = "ProgrammaticToolCallingParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolParamType), TypeInfoPropertyName = "LocalShellToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParamType), TypeInfoPropertyName = "ContainerAutoParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicy3), TypeInfoPropertyName = "NetworkPolicy32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType), TypeInfoPropertyName = "ContainerAutoParamNetworkPolicyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillsItem2), TypeInfoPropertyName = "SkillsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType), TypeInfoPropertyName = "ContainerAutoParamSkillDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalSkillParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalEnvironmentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType), TypeInfoPropertyName = "LocalEnvironmentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.LocalSkillParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerReferenceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerReferenceParamType), TypeInfoPropertyName = "ContainerReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellToolParamType), TypeInfoPropertyName = "FunctionShellToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType), TypeInfoPropertyName = "FunctionShellToolParamEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomTextFormatParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomTextFormatParamType), TypeInfoPropertyName = "CustomTextFormatParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GrammarSyntax1), TypeInfoPropertyName = "GrammarSyntax12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomGrammarFormatParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType), TypeInfoPropertyName = "CustomGrammarFormatParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolParamType), TypeInfoPropertyName = "CustomToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Format2), TypeInfoPropertyName = "Format22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType), TypeInfoPropertyName = "CustomToolParamFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EmptyModelParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolParamType), TypeInfoPropertyName = "FunctionToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NamespaceToolParamType), TypeInfoPropertyName = "NamespaceToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem13>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolsItem13), TypeInfoPropertyName = "ToolsItem132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType), TypeInfoPropertyName = "NamespaceToolParamToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchToolParamType), TypeInfoPropertyName = "ToolSearchToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApproximateLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApproximateLocationType), TypeInfoPropertyName = "ApproximateLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SearchContextSize), TypeInfoPropertyName = "SearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SearchContentType), TypeInfoPropertyName = "SearchContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType), TypeInfoPropertyName = "WebSearchPreviewToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SearchContentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType), TypeInfoPropertyName = "ApplyPatchToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchOutputType), TypeInfoPropertyName = "ToolSearchOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdditionalToolsType), TypeInfoPropertyName = "AdditionalToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramType), TypeInfoPropertyName = "ProgramType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramOutputStatus), TypeInfoPropertyName = "ProgramOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramOutputType), TypeInfoPropertyName = "ProgramOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionBodyType), TypeInfoPropertyName = "CompactionBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType), TypeInfoPropertyName = "CodeInterpreterOutputLogsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType), TypeInfoPropertyName = "CodeInterpreterOutputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellExecActionType), TypeInfoPropertyName = "LocalShellExecActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallStatus), TypeInfoPropertyName = "FunctionShellCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalEnvironmentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType), TypeInfoPropertyName = "LocalEnvironmentResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerReferenceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType), TypeInfoPropertyName = "ContainerReferenceResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallType), TypeInfoPropertyName = "FunctionShellCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType), TypeInfoPropertyName = "FunctionShellCallEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum), TypeInfoPropertyName = "FunctionShellCallOutputStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcome))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType), TypeInfoPropertyName = "FunctionShellCallOutputTimeoutOutcomeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcome))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType), TypeInfoPropertyName = "FunctionShellCallOutputExitOutcomeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Outcome), TypeInfoPropertyName = "Outcome2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType), TypeInfoPropertyName = "FunctionShellCallOutputContentOutcomeDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType), TypeInfoPropertyName = "FunctionShellCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus), TypeInfoPropertyName = "ApplyPatchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType), TypeInfoPropertyName = "ApplyPatchCreateFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType), TypeInfoPropertyName = "ApplyPatchDeleteFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType), TypeInfoPropertyName = "ApplyPatchUpdateFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType), TypeInfoPropertyName = "ApplyPatchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Operation), TypeInfoPropertyName = "Operation2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType), TypeInfoPropertyName = "ApplyPatchToolCallOperationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus), TypeInfoPropertyName = "ApplyPatchCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType), TypeInfoPropertyName = "ApplyPatchToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPProtocolErrorType), TypeInfoPropertyName = "MCPProtocolErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType), TypeInfoPropertyName = "MCPToolExecutionErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HTTPErrorType), TypeInfoPropertyName = "HTTPErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DetailEnum), TypeInfoPropertyName = "DetailEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallItemStatus), TypeInfoPropertyName = "FunctionCallItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType), TypeInfoPropertyName = "ComputerCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentParamType), TypeInfoPropertyName = "InputTextContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType), TypeInfoPropertyName = "InputImageContentParamAutoParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileDetailEnum), TypeInfoPropertyName = "FileDetailEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContentParamType), TypeInfoPropertyName = "InputFileContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType), TypeInfoPropertyName = "FunctionCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>), TypeInfoPropertyName = "OneOfStringIListOutputVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputVariant2Item), TypeInfoPropertyName = "OutputVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType), TypeInfoPropertyName = "FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType), TypeInfoPropertyName = "ToolSearchCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType), TypeInfoPropertyName = "ToolSearchOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType), TypeInfoPropertyName = "AdditionalToolsItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole), TypeInfoPropertyName = "AdditionalToolsItemParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType), TypeInfoPropertyName = "CompactionSummaryItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellActionParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus), TypeInfoPropertyName = "FunctionShellCallItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType), TypeInfoPropertyName = "FunctionShellCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType), TypeInfoPropertyName = "FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType), TypeInfoPropertyName = "FunctionShellCallOutputTimeoutOutcomeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType), TypeInfoPropertyName = "FunctionShellCallOutputExitOutcomeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam), TypeInfoPropertyName = "FunctionShellCallOutputOutcomeParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType), TypeInfoPropertyName = "FunctionShellCallOutputOutcomeParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType), TypeInfoPropertyName = "FunctionShellCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam), TypeInfoPropertyName = "ApplyPatchCallStatusParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType), TypeInfoPropertyName = "ApplyPatchCreateFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType), TypeInfoPropertyName = "ApplyPatchDeleteFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType), TypeInfoPropertyName = "ApplyPatchUpdateFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchOperationParam), TypeInfoPropertyName = "ApplyPatchOperationParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType), TypeInfoPropertyName = "ApplyPatchOperationParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType), TypeInfoPropertyName = "ApplyPatchToolCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam), TypeInfoPropertyName = "ApplyPatchCallOutputStatusParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType), TypeInfoPropertyName = "ApplyPatchToolCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType), TypeInfoPropertyName = "CompactionTriggerItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemReferenceParamType), TypeInfoPropertyName = "ItemReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramItemParamType), TypeInfoPropertyName = "ProgramItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus), TypeInfoPropertyName = "ProgramOutputItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType), TypeInfoPropertyName = "ProgramOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType), TypeInfoPropertyName = "SpecificProgrammaticToolCallingParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType), TypeInfoPropertyName = "SpecificApplyPatchParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType), TypeInfoPropertyName = "SpecificFunctionShellParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum), TypeInfoPropertyName = "CyberAccessProgramEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum), TypeInfoPropertyName = "ReasoningModeEnumEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum), TypeInfoPropertyName = "CacheMissReasonTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType), TypeInfoPropertyName = "PromptCacheMissDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType), TypeInfoPropertyName = "PromptCacheHitDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType), TypeInfoPropertyName = "PromptCacheComparisonResponseNotFoundDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType), TypeInfoPropertyName = "PromptCacheUnavailableDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType), TypeInfoPropertyName = "PromptCacheDiagnosticsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationErrorBodyType), TypeInfoPropertyName = "ModerationErrorBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Input4), TypeInfoPropertyName = "Input42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationInputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType), TypeInfoPropertyName = "ModerationInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Output5), TypeInfoPropertyName = "Output52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType), TypeInfoPropertyName = "ModerationOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType), TypeInfoPropertyName = "ResponseCompactionCompactingStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType), TypeInfoPropertyName = "ResponseShellCallCommandAddedStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType), TypeInfoPropertyName = "ResponseShellCallCommandDeltaStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType), TypeInfoPropertyName = "ResponseShellCallCommandDoneStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ShellCallOutputDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType), TypeInfoPropertyName = "ResponseShellCallOutputContentDeltaStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType), TypeInfoPropertyName = "ResponseShellCallOutputContentDoneStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TruncationEnum), TypeInfoPropertyName = "TruncationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersonalityEnum), TypeInfoPropertyName = "PersonalityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersonalityEnumEnum), TypeInfoPropertyName = "PersonalityEnumEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TokenCountsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TokenCountsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TokenCountsResourceObject), TypeInfoPropertyName = "TokenCountsResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheRetentionEnum), TypeInfoPropertyName = "PromptCacheRetentionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ServiceTierEnum2), TypeInfoPropertyName = "ServiceTierEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactResponseMethodPublicBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemField), TypeInfoPropertyName = "ItemField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemFieldDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemFieldDiscriminatorType), TypeInfoPropertyName = "ItemFieldDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactResourceObject), TypeInfoPropertyName = "CompactResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ItemField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTokenCountsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTokenCountsResourceObject), TypeInfoPropertyName = "BetaTokenCountsResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTokenCountsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputItem), TypeInfoPropertyName = "BetaInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTool), TypeInfoPropertyName = "BetaTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseTextParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTruncationEnum), TypeInfoPropertyName = "BetaTruncationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPersonalityEnum), TypeInfoPropertyName = "BetaPersonalityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaConversationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions), TypeInfoPropertyName = "BetaToolChoiceOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceMCP))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType), TypeInfoPropertyName = "BetaSpecificFunctionShellParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType), TypeInfoPropertyName = "BetaSpecificApplyPatchParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType), TypeInfoPropertyName = "BetaSpecificProgrammaticToolCallingParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType), TypeInfoPropertyName = "BetaToolChoiceCustomType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType), TypeInfoPropertyName = "BetaToolChoiceMCPType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType), TypeInfoPropertyName = "BetaToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType), TypeInfoPropertyName = "BetaToolChoiceTypesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType), TypeInfoPropertyName = "BetaToolChoiceAllowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode), TypeInfoPropertyName = "BetaToolChoiceAllowedMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaConversationParam2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPersonalityEnumEnum), TypeInfoPropertyName = "BetaPersonalityEnumEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningModeEnum), TypeInfoPropertyName = "BetaReasoningModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum), TypeInfoPropertyName = "BetaReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningSummary), TypeInfoPropertyName = "BetaReasoningSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningContext), TypeInfoPropertyName = "BetaReasoningContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary), TypeInfoPropertyName = "BetaReasoningGenerateSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum), TypeInfoPropertyName = "BetaReasoningModeEnumEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration), TypeInfoPropertyName = "BetaTextResponseFormatConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaVerbosityEnum), TypeInfoPropertyName = "BetaVerbosityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType), TypeInfoPropertyName = "BetaResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType), TypeInfoPropertyName = "BetaTextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonSchemaSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType), TypeInfoPropertyName = "BetaResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaNamespaceToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType), TypeInfoPropertyName = "BetaToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType), TypeInfoPropertyName = "BetaApplyPatchToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller), TypeInfoPropertyName = "BetaCallableToolAllowedCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType), TypeInfoPropertyName = "BetaWebSearchPreviewToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApproximateLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSearchContextSize), TypeInfoPropertyName = "BetaSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSearchContentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSearchContentType), TypeInfoPropertyName = "BetaSearchContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApproximateLocationType), TypeInfoPropertyName = "BetaApproximateLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType), TypeInfoPropertyName = "BetaToolSearchToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType), TypeInfoPropertyName = "BetaToolSearchExecutionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEmptyModelParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType), TypeInfoPropertyName = "BetaNamespaceToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem16>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolsItem16), TypeInfoPropertyName = "ToolsItem162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType), TypeInfoPropertyName = "BetaNamespaceToolParamToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolParamType), TypeInfoPropertyName = "BetaCustomToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Format3), TypeInfoPropertyName = "Format32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType), TypeInfoPropertyName = "BetaCustomToolParamFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType), TypeInfoPropertyName = "BetaCustomGrammarFormatParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1), TypeInfoPropertyName = "BetaGrammarSyntax12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType), TypeInfoPropertyName = "BetaCustomTextFormatParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType), TypeInfoPropertyName = "BetaFunctionToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType), TypeInfoPropertyName = "BetaFunctionShellToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerAutoParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerReferenceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType), TypeInfoPropertyName = "BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType), TypeInfoPropertyName = "BetaContainerReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType), TypeInfoPropertyName = "BetaLocalEnvironmentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLocalSkillParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalSkillParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType), TypeInfoPropertyName = "BetaContainerAutoParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit), TypeInfoPropertyName = "BetaContainerMemoryLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicy4), TypeInfoPropertyName = "NetworkPolicy42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType), TypeInfoPropertyName = "BetaContainerAutoParamNetworkPolicyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillsItem3), TypeInfoPropertyName = "SkillsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSkillReferenceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInlineSkillParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType), TypeInfoPropertyName = "BetaContainerAutoParamSkillDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType), TypeInfoPropertyName = "BetaInlineSkillParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType), TypeInfoPropertyName = "BetaInlineSkillSourceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType), TypeInfoPropertyName = "BetaInlineSkillSourceParamMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType), TypeInfoPropertyName = "BetaSkillReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType), TypeInfoPropertyName = "BetaContainerNetworkPolicyAllowlistParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType), TypeInfoPropertyName = "BetaContainerNetworkPolicyDisabledParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType), TypeInfoPropertyName = "BetaLocalShellToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolType), TypeInfoPropertyName = "BetaImageGenToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>), TypeInfoPropertyName = "AnyOfStringBetaImageGenToolModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolModel), TypeInfoPropertyName = "BetaImageGenToolModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality), TypeInfoPropertyName = "BetaImageGenToolQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>), TypeInfoPropertyName = "AnyOfStringBetaImageGenToolSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolSize), TypeInfoPropertyName = "BetaImageGenToolSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat), TypeInfoPropertyName = "BetaImageGenToolOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration), TypeInfoPropertyName = "BetaImageGenToolModeration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground), TypeInfoPropertyName = "BetaImageGenToolBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputFidelity), TypeInfoPropertyName = "BetaInputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolInputImageMask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum), TypeInfoPropertyName = "BetaImageGenActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType), TypeInfoPropertyName = "BetaProgrammaticToolCallingParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType), TypeInfoPropertyName = "BetaCodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>), TypeInfoPropertyName = "OneOfStringBetaAutoCodeInterpreterToolParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType), TypeInfoPropertyName = "BetaAutoCodeInterpreterToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicy5), TypeInfoPropertyName = "NetworkPolicy52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType), TypeInfoPropertyName = "BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolType), TypeInfoPropertyName = "BetaMCPToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId), TypeInfoPropertyName = "BetaMCPToolConnectorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2), TypeInfoPropertyName = "BetaMCPToolRequireApprovalVariant1Enum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolType), TypeInfoPropertyName = "BetaWebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize), TypeInfoPropertyName = "BetaWebSearchToolSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType), TypeInfoPropertyName = "BetaWebSearchApproximateLocationWebSearchApproximateLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType), TypeInfoPropertyName = "BetaComputerUsePreviewToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerEnvironment), TypeInfoPropertyName = "BetaComputerEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolType), TypeInfoPropertyName = "BetaComputerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileSearchToolType), TypeInfoPropertyName = "BetaFileSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaRankingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComparisonFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompoundFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompoundFilterType), TypeInfoPropertyName = "BetaCompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FiltersItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FiltersItem2), TypeInfoPropertyName = "FiltersItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompoundFilterFilterDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComparisonFilterType), TypeInfoPropertyName = "BetaComparisonFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaRankerVersionType), TypeInfoPropertyName = "BetaRankerVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaHybridSearchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolType), TypeInfoPropertyName = "BetaFunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEasyInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItem), TypeInfoPropertyName = "BetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemReferenceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType), TypeInfoPropertyName = "BetaInputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentTagParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType), TypeInfoPropertyName = "BetaProgramOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus), TypeInfoPropertyName = "BetaProgramOutputItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramItemParamType), TypeInfoPropertyName = "BetaProgramItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType), TypeInfoPropertyName = "BetaItemReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType), TypeInfoPropertyName = "BetaCompactionTriggerItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileSearchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPListTools))]
    internal sealed partial class ResponsesSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType), TypeInfoPropertyName = "BetaItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCallType), TypeInfoPropertyName = "BetaCustomToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolCallCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDirectToolCallCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramToolCallCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType), TypeInfoPropertyName = "BetaToolCallCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType), TypeInfoPropertyName = "BetaProgramToolCallCallerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType), TypeInfoPropertyName = "BetaDirectToolCallCallerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType), TypeInfoPropertyName = "BetaCustomToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolCallCallerParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>), TypeInfoPropertyName = "OneOfStringIListBetaFunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput), TypeInfoPropertyName = "BetaFunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputFileContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType), TypeInfoPropertyName = "BetaFunctionAndCustomToolCallOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputFileContentType), TypeInfoPropertyName = "BetaInputFileContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileInputDetail), TypeInfoPropertyName = "BetaFileInputDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode), TypeInfoPropertyName = "BetaPromptCacheBreakpointConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputImageContentType), TypeInfoPropertyName = "BetaInputImageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageDetail), TypeInfoPropertyName = "BetaImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputTextContentType), TypeInfoPropertyName = "BetaInputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType), TypeInfoPropertyName = "BetaToolCallCallerParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType), TypeInfoPropertyName = "BetaProgramToolCallCallerParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType), TypeInfoPropertyName = "BetaDirectToolCallCallerParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolCallType), TypeInfoPropertyName = "BetaMCPToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolCallError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus), TypeInfoPropertyName = "BetaMCPToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPProtocolError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaHTTPError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType), TypeInfoPropertyName = "BetaMCPToolCallErrorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaHTTPErrorType), TypeInfoPropertyName = "BetaHTTPErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType), TypeInfoPropertyName = "BetaMCPToolExecutionErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType), TypeInfoPropertyName = "BetaMCPProtocolErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType), TypeInfoPropertyName = "BetaMCPApprovalResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType), TypeInfoPropertyName = "BetaMCPApprovalRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPListToolsType), TypeInfoPropertyName = "BetaMCPListToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaMCPListToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPListToolsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType), TypeInfoPropertyName = "BetaApplyPatchToolCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam), TypeInfoPropertyName = "BetaApplyPatchCallOutputStatusParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType), TypeInfoPropertyName = "BetaApplyPatchToolCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam), TypeInfoPropertyName = "BetaApplyPatchCallStatusParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParam), TypeInfoPropertyName = "BetaApplyPatchOperationParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType), TypeInfoPropertyName = "BetaApplyPatchOperationParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType), TypeInfoPropertyName = "BetaApplyPatchUpdateFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType), TypeInfoPropertyName = "BetaApplyPatchDeleteFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType), TypeInfoPropertyName = "BetaApplyPatchCreateFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType), TypeInfoPropertyName = "BetaFunctionShellCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus), TypeInfoPropertyName = "BetaFunctionShellCallItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParam), TypeInfoPropertyName = "BetaFunctionShellCallOutputOutcomeParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType), TypeInfoPropertyName = "BetaFunctionShellCallOutputOutcomeParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType), TypeInfoPropertyName = "BetaFunctionShellCallOutputExitOutcomeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType), TypeInfoPropertyName = "BetaFunctionShellCallOutputTimeoutOutcomeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType), TypeInfoPropertyName = "BetaFunctionShellCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellActionParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType), TypeInfoPropertyName = "BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType), TypeInfoPropertyName = "BetaLocalShellToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus), TypeInfoPropertyName = "BetaLocalShellToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType), TypeInfoPropertyName = "BetaLocalShellToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellExecAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus), TypeInfoPropertyName = "BetaLocalShellToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType), TypeInfoPropertyName = "BetaLocalShellExecActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType), TypeInfoPropertyName = "BetaCodeInterpreterToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus), TypeInfoPropertyName = "BetaCodeInterpreterToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputsVariant1Item2), TypeInfoPropertyName = "OutputsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType), TypeInfoPropertyName = "BetaCodeInterpreterOutputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType), TypeInfoPropertyName = "BetaCodeInterpreterOutputLogsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType), TypeInfoPropertyName = "BetaImageGenToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus), TypeInfoPropertyName = "BetaImageGenToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1), TypeInfoPropertyName = "BetaImageGenToolCallSizeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality), TypeInfoPropertyName = "BetaImageGenToolCallQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageBackground), TypeInfoPropertyName = "BetaImageBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageOutputFormat), TypeInfoPropertyName = "BetaImageOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType), TypeInfoPropertyName = "BetaCompactionSummaryItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningItemType), TypeInfoPropertyName = "BetaReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSummaryTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSummaryTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaReasoningTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus), TypeInfoPropertyName = "BetaReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType), TypeInfoPropertyName = "BetaReasoningTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType), TypeInfoPropertyName = "BetaSummaryTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType), TypeInfoPropertyName = "BetaResponseConfigurationUpdateItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType), TypeInfoPropertyName = "BetaAdditionalToolsItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole), TypeInfoPropertyName = "BetaAdditionalToolsItemParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType), TypeInfoPropertyName = "BetaToolSearchOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus), TypeInfoPropertyName = "BetaFunctionCallItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType), TypeInfoPropertyName = "BetaToolSearchCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType), TypeInfoPropertyName = "BetaMultiAgentCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1), TypeInfoPropertyName = "BetaMultiAgentAction12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContentParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputTextContentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType), TypeInfoPropertyName = "BetaOutputTextContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.AnnotationsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnnotationsItem4), TypeInfoPropertyName = "AnnotationsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileCitationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaUrlCitationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType), TypeInfoPropertyName = "BetaOutputTextContentParamAnnotationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType), TypeInfoPropertyName = "BetaContainerFileCitationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType), TypeInfoPropertyName = "BetaUrlCitationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileCitationParamType), TypeInfoPropertyName = "BetaFileCitationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType), TypeInfoPropertyName = "BetaMultiAgentCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType), TypeInfoPropertyName = "BetaAgentMessageItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem6), TypeInfoPropertyName = "ContentItem62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputTextContentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEncryptedContentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType), TypeInfoPropertyName = "BetaAgentMessageItemParamContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType), TypeInfoPropertyName = "BetaEncryptedContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType), TypeInfoPropertyName = "BetaInputImageContentParamAutoParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDetailEnum), TypeInfoPropertyName = "BetaDetailEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode), TypeInfoPropertyName = "BetaPromptCacheBreakpointParamMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType), TypeInfoPropertyName = "BetaInputTextContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType), TypeInfoPropertyName = "BetaFunctionCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>>), TypeInfoPropertyName = "OneOfStringIListOutputVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputVariant2Item2), TypeInfoPropertyName = "OutputVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputFileContentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType), TypeInfoPropertyName = "BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType), TypeInfoPropertyName = "BetaInputFileContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileDetailEnum), TypeInfoPropertyName = "BetaFileDetailEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType), TypeInfoPropertyName = "BetaFunctionToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus), TypeInfoPropertyName = "BetaFunctionToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType), TypeInfoPropertyName = "BetaWebSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus), TypeInfoPropertyName = "BetaWebSearchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallAction), TypeInfoPropertyName = "BetaWebSearchToolCallAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionFind))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType), TypeInfoPropertyName = "BetaWebSearchToolCallActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType), TypeInfoPropertyName = "BetaWebSearchActionFindType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType), TypeInfoPropertyName = "BetaWebSearchActionOpenPageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType), TypeInfoPropertyName = "BetaWebSearchActionSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType), TypeInfoPropertyName = "BetaWebSearchActionSearchSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType), TypeInfoPropertyName = "BetaComputerCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType), TypeInfoPropertyName = "BetaComputerScreenshotImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallType), TypeInfoPropertyName = "BetaComputerToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerAction), TypeInfoPropertyName = "BetaComputerAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaComputerAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus), TypeInfoPropertyName = "BetaComputerToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaClickParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDoubleClickAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDragParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaKeyPressAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMoveParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaScreenshotParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaScrollParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTypeParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWaitParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType), TypeInfoPropertyName = "BetaComputerActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWaitParamType), TypeInfoPropertyName = "BetaWaitParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTypeParamType), TypeInfoPropertyName = "BetaTypeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaScrollParamType), TypeInfoPropertyName = "BetaScrollParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaScreenshotParamType), TypeInfoPropertyName = "BetaScreenshotParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMoveParamType), TypeInfoPropertyName = "BetaMoveParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaKeyPressActionType), TypeInfoPropertyName = "BetaKeyPressActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDragParamType), TypeInfoPropertyName = "BetaDragParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCoordParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCoordParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType), TypeInfoPropertyName = "BetaDoubleClickActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaClickParamType), TypeInfoPropertyName = "BetaClickParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaClickButtonType), TypeInfoPropertyName = "BetaClickButtonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType), TypeInfoPropertyName = "BetaFileSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus), TypeInfoPropertyName = "BetaFileSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessageType), TypeInfoPropertyName = "BetaOutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessageRole), TypeInfoPropertyName = "BetaOutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputMessageContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessageContent), TypeInfoPropertyName = "BetaOutputMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessagePhase), TypeInfoPropertyName = "BetaMessagePhase2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus), TypeInfoPropertyName = "BetaOutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaRefusalContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType), TypeInfoPropertyName = "BetaOutputMessageContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaRefusalContentType), TypeInfoPropertyName = "BetaRefusalContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputTextContentType), TypeInfoPropertyName = "BetaOutputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAnnotation), TypeInfoPropertyName = "BetaAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLogProb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTopLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTopLogProb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileCitationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaUrlCitationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFilePath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType), TypeInfoPropertyName = "BetaAnnotationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFilePathType), TypeInfoPropertyName = "BetaFilePathType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType), TypeInfoPropertyName = "BetaContainerFileCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType), TypeInfoPropertyName = "BetaUrlCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType), TypeInfoPropertyName = "BetaFileCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputMessageType), TypeInfoPropertyName = "BetaInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputMessageRole), TypeInfoPropertyName = "BetaInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputMessageStatus), TypeInfoPropertyName = "BetaInputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputContent), TypeInfoPropertyName = "BetaInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType), TypeInfoPropertyName = "BetaInputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole), TypeInfoPropertyName = "BetaEasyInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>>), TypeInfoPropertyName = "OneOfStringIListBetaInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType), TypeInfoPropertyName = "BetaEasyInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactResponseMethodPublicBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelIdsCompaction), TypeInfoPropertyName = "BetaModelIdsCompaction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheRetentionEnum), TypeInfoPropertyName = "BetaPromptCacheRetentionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheOptionsParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaServiceTierEnum), TypeInfoPropertyName = "BetaServiceTierEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum), TypeInfoPropertyName = "BetaPromptCacheTTLEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum), TypeInfoPropertyName = "BetaPromptCacheModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelIdsResponses), TypeInfoPropertyName = "BetaModelIdsResponses2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelIdsShared), TypeInfoPropertyName = "BetaModelIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum), TypeInfoPropertyName = "BetaModelIdsResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum), TypeInfoPropertyName = "BetaModelIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorDetailsResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorType), TypeInfoPropertyName = "BetaMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMisalignmentSteer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum), TypeInfoPropertyName = "BetaMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseItemList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseItemListObject), TypeInfoPropertyName = "BetaResponseItemListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemResource), TypeInfoPropertyName = "BetaItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputMessageResource), TypeInfoPropertyName = "BetaInputMessageResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputResource), TypeInfoPropertyName = "BetaComputerToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallResource), TypeInfoPropertyName = "BetaFunctionToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputResource), TypeInfoPropertyName = "BetaFunctionToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAdditionalTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgram))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCallResource), TypeInfoPropertyName = "BetaCustomToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputResource), TypeInfoPropertyName = "BetaCustomToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemResourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemResourceDiscriminatorType), TypeInfoPropertyName = "BetaItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum), TypeInfoPropertyName = "BetaFunctionCallOutputStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCallResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus), TypeInfoPropertyName = "BetaFunctionCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType), TypeInfoPropertyName = "BetaMCPApprovalResponseResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType), TypeInfoPropertyName = "BetaApplyPatchToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus), TypeInfoPropertyName = "BetaApplyPatchCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType), TypeInfoPropertyName = "BetaApplyPatchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus), TypeInfoPropertyName = "BetaApplyPatchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Operation2), TypeInfoPropertyName = "Operation22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType), TypeInfoPropertyName = "BetaApplyPatchToolCallOperationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType), TypeInfoPropertyName = "BetaApplyPatchUpdateFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType), TypeInfoPropertyName = "BetaApplyPatchDeleteFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType), TypeInfoPropertyName = "BetaApplyPatchCreateFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType), TypeInfoPropertyName = "BetaFunctionShellCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum), TypeInfoPropertyName = "BetaFunctionShellCallOutputStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Outcome2), TypeInfoPropertyName = "Outcome22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcome))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcome))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType), TypeInfoPropertyName = "BetaFunctionShellCallOutputContentOutcomeDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType), TypeInfoPropertyName = "BetaFunctionShellCallOutputExitOutcomeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType), TypeInfoPropertyName = "BetaFunctionShellCallOutputTimeoutOutcomeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType), TypeInfoPropertyName = "BetaFunctionShellCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus), TypeInfoPropertyName = "BetaFunctionShellCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EnvironmentVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerReferenceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType), TypeInfoPropertyName = "BetaFunctionShellCallEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType), TypeInfoPropertyName = "BetaContainerReferenceResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType), TypeInfoPropertyName = "BetaLocalEnvironmentResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactionBodyType), TypeInfoPropertyName = "BetaCompactionBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramOutputType), TypeInfoPropertyName = "BetaProgramOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus), TypeInfoPropertyName = "BetaProgramOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramType), TypeInfoPropertyName = "BetaProgramType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType), TypeInfoPropertyName = "BetaResponseConfigurationUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType), TypeInfoPropertyName = "BetaAdditionalToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessageRole), TypeInfoPropertyName = "BetaMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType), TypeInfoPropertyName = "BetaToolSearchOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchCallType), TypeInfoPropertyName = "BetaToolSearchCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType), TypeInfoPropertyName = "BetaMultiAgentCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentAction), TypeInfoPropertyName = "BetaMultiAgentAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType), TypeInfoPropertyName = "BetaMultiAgentCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessageType), TypeInfoPropertyName = "BetaAgentMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem7>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem7), TypeInfoPropertyName = "ContentItem72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEncryptedContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType), TypeInfoPropertyName = "BetaAgentMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEncryptedContentType), TypeInfoPropertyName = "BetaEncryptedContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType), TypeInfoPropertyName = "BetaComputerScreenshotContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTextContentType), TypeInfoPropertyName = "BetaTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType), TypeInfoPropertyName = "BetaFunctionToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus), TypeInfoPropertyName = "BetaFunctionToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus), TypeInfoPropertyName = "BetaComputerCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType), TypeInfoPropertyName = "BetaComputerToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus), TypeInfoPropertyName = "BetaComputerToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputMessageResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactResourceObject), TypeInfoPropertyName = "BetaCompactResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaItemField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemField), TypeInfoPropertyName = "BetaItemField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseUsageInputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseUsageOutputTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemFieldDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemFieldDiscriminatorType), TypeInfoPropertyName = "BetaItemFieldDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessageType), TypeInfoPropertyName = "BetaMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessageStatus), TypeInfoPropertyName = "BetaMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ContentItem8>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem8), TypeInfoPropertyName = "ContentItem82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessageContentItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessageContentItemDiscriminatorType), TypeInfoPropertyName = "BetaMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessagePhase2), TypeInfoPropertyName = "BetaMessagePhase22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType), TypeInfoPropertyName = "BetaResponseCustomToolCallInputDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType), TypeInfoPropertyName = "BetaResponseCustomToolCallInputDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseQueuedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType), TypeInfoPropertyName = "BetaResponseQueuedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponse), TypeInfoPropertyName = "BetaResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum), TypeInfoPropertyName = "BetaServiceTierResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation), TypeInfoPropertyName = "BetaResponseVariant3Truncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object), TypeInfoPropertyName = "BetaResponseVariant3Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status), TypeInfoPropertyName = "BetaResponseVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAccessProgramsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseErrorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason), TypeInfoPropertyName = "BetaResponseVariant3IncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputItem), TypeInfoPropertyName = "BetaOutputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnostics), TypeInfoPropertyName = "BetaPromptCacheDiagnostics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModeration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Input5), TypeInfoPropertyName = "Input52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationResultBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationErrorBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType), TypeInfoPropertyName = "BetaModerationInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Output9), TypeInfoPropertyName = "Output92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType), TypeInfoPropertyName = "BetaModerationOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType), TypeInfoPropertyName = "BetaModerationErrorBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType), TypeInfoPropertyName = "BetaModerationResultBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaModerationInputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationInputType), TypeInfoPropertyName = "BetaModerationInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType), TypeInfoPropertyName = "BetaPromptCacheDiagnosticsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType), TypeInfoPropertyName = "BetaPromptCacheUnavailableDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType), TypeInfoPropertyName = "BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType), TypeInfoPropertyName = "BetaPromptCacheHitDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType), TypeInfoPropertyName = "BetaPromptCacheMissDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum), TypeInfoPropertyName = "BetaCacheMissReasonTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType), TypeInfoPropertyName = "BetaOutputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseErrorCode), TypeInfoPropertyName = "BetaResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum), TypeInfoPropertyName = "BetaCyberAccessProgramEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaInputTextContent, global::tryAGI.OpenAI.BetaInputImageContent, global::tryAGI.OpenAI.BetaInputFileContent>), TypeInfoPropertyName = "OneOfStringBetaInputTextContentBetaInputImageContentBetaInputFileContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention), TypeInfoPropertyName = "BetaModelResponsePropertiesPromptCacheRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType), TypeInfoPropertyName = "BetaResponseOutputTextAnnotationAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType), TypeInfoPropertyName = "BetaResponseMCPListToolsInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType), TypeInfoPropertyName = "BetaResponseMCPListToolsFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType), TypeInfoPropertyName = "BetaResponseMCPListToolsCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType), TypeInfoPropertyName = "BetaResponseMCPCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType), TypeInfoPropertyName = "BetaResponseMCPCallFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType), TypeInfoPropertyName = "BetaResponseMCPCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType), TypeInfoPropertyName = "BetaResponseMCPCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType), TypeInfoPropertyName = "BetaResponseMCPCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType), TypeInfoPropertyName = "BetaResponseImageGenCallPartialImageEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType), TypeInfoPropertyName = "BetaResponseImageGenCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType), TypeInfoPropertyName = "BetaResponseImageGenCallGeneratingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType), TypeInfoPropertyName = "BetaResponseImageGenCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType), TypeInfoPropertyName = "BetaResponseReasoningTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType), TypeInfoPropertyName = "BetaResponseReasoningTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType), TypeInfoPropertyName = "BetaResponseReasoningSummaryTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType), TypeInfoPropertyName = "BetaResponseReasoningSummaryTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType), TypeInfoPropertyName = "BetaResponseReasoningSummaryPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus), TypeInfoPropertyName = "BetaResponseReasoningSummaryPartDoneEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType), TypeInfoPropertyName = "BetaResponseReasoningSummaryPartDoneEventPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType), TypeInfoPropertyName = "BetaResponseReasoningSummaryPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType), TypeInfoPropertyName = "BetaResponseReasoningSummaryPartAddedEventPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType), TypeInfoPropertyName = "BetaResponseTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseLogProb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType), TypeInfoPropertyName = "BetaResponseTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType), TypeInfoPropertyName = "BetaResponseRefusalDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType), TypeInfoPropertyName = "BetaResponseRefusalDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType), TypeInfoPropertyName = "BetaResponseOutputItemDoneEventType2")]
    internal sealed partial class ResponsesSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType), TypeInfoPropertyName = "BetaResponseOutputItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType), TypeInfoPropertyName = "BetaResponseInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType), TypeInfoPropertyName = "BetaResponseShellCallOutputContentDoneStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType), TypeInfoPropertyName = "BetaResponseShellCallOutputContentDeltaStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaShellCallOutputDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType), TypeInfoPropertyName = "BetaResponseShellCallCommandDoneStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType), TypeInfoPropertyName = "BetaResponseShellCallCommandDeltaStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType), TypeInfoPropertyName = "BetaResponseShellCallCommandAddedStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType), TypeInfoPropertyName = "BetaResponseFunctionCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType), TypeInfoPropertyName = "BetaResponseFunctionCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType), TypeInfoPropertyName = "BetaResponseFileSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType), TypeInfoPropertyName = "BetaResponseFileSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType), TypeInfoPropertyName = "BetaResponseFileSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseErrorEventType), TypeInfoPropertyName = "BetaResponseErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType), TypeInfoPropertyName = "BetaResponseCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType), TypeInfoPropertyName = "BetaResponseContentPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputContent), TypeInfoPropertyName = "BetaOutputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType), TypeInfoPropertyName = "BetaOutputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType), TypeInfoPropertyName = "BetaResponseContentPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType), TypeInfoPropertyName = "BetaResponseCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType), TypeInfoPropertyName = "BetaResponseCompactionCompactingStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType), TypeInfoPropertyName = "BetaResponseCodeInterpreterCallInterpretingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType), TypeInfoPropertyName = "BetaResponseCodeInterpreterCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType), TypeInfoPropertyName = "BetaResponseCodeInterpreterCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType), TypeInfoPropertyName = "BetaResponseCodeInterpreterCallCodeDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType), TypeInfoPropertyName = "BetaResponseCodeInterpreterCallCodeDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType), TypeInfoPropertyName = "BetaResponseAudioTranscriptDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType), TypeInfoPropertyName = "BetaResponseAudioTranscriptDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType), TypeInfoPropertyName = "BetaResponseAudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType), TypeInfoPropertyName = "BetaResponseAudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType), TypeInfoPropertyName = "BetaResponseIncompleteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFailedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType), TypeInfoPropertyName = "BetaResponseFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType), TypeInfoPropertyName = "BetaResponseWebSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType), TypeInfoPropertyName = "BetaResponseWebSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType), TypeInfoPropertyName = "BetaResponseWebSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputParam), TypeInfoPropertyName = "BetaInputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaIncludeEnum), TypeInfoPropertyName = "BetaIncludeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCreateResponse), TypeInfoPropertyName = "BetaCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCreateModelResponseProperties), TypeInfoPropertyName = "BetaCreateModelResponseProperties2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAccessProgramsParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponsePromptCacheOptionsParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation), TypeInfoPropertyName = "BetaCreateResponseVariant3Truncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaIncludeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseStreamOptionsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaContextManagementParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContextManagementParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationPolicyParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationConfigParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationMode), TypeInfoPropertyName = "BetaModerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCreateModelResponsePropertiesVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseStreamEvent), TypeInfoPropertyName = "BetaResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType), TypeInfoPropertyName = "BetaResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListInputItemsOrder), TypeInfoPropertyName = "ListInputItemsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem), TypeInfoPropertyName = "BetaCreateResponseOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem), TypeInfoPropertyName = "BetaGetResponseOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem), TypeInfoPropertyName = "BetaDeleteResponseOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem), TypeInfoPropertyName = "BetaCancelResponseOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem), TypeInfoPropertyName = "BetaCompactconversationOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaListInputItemsOrder), TypeInfoPropertyName = "BetaListInputItemsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem), TypeInfoPropertyName = "BetaListInputItemsOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem), TypeInfoPropertyName = "BetaGetinputtokencountsOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolType?), TypeInfoPropertyName = "NullableCodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>?), TypeInfoPropertyName = "NullableOneOfStringAutoCodeInterpreterToolParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?), TypeInfoPropertyName = "NullableCallableToolAllowedCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType?), TypeInfoPropertyName = "NullableCodeInterpreterToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus?), TypeInfoPropertyName = "NullableCodeInterpreterToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputsVariant1Item?), TypeInfoPropertyName = "NullableOutputsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComparisonFilterType?), TypeInfoPropertyName = "NullableComparisonFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanIListOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?>?), TypeInfoPropertyName = "NullableOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilterType?), TypeInfoPropertyName = "NullableCompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FiltersItem?), TypeInfoPropertyName = "NullableFiltersItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerAction?), TypeInfoPropertyName = "NullableComputerAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType?), TypeInfoPropertyName = "NullableComputerActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType?), TypeInfoPropertyName = "NullableComputerScreenshotImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallType?), TypeInfoPropertyName = "NullableComputerToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallStatus?), TypeInfoPropertyName = "NullableComputerToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType?), TypeInfoPropertyName = "NullableComputerToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus?), TypeInfoPropertyName = "NullableComputerToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolCallOutputResource?), TypeInfoPropertyName = "NullableComputerToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus?), TypeInfoPropertyName = "NullableComputerCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContent?), TypeInfoPropertyName = "NullableInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputContent?), TypeInfoPropertyName = "NullableOutputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallResource?), TypeInfoPropertyName = "NullableFunctionToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResource?), TypeInfoPropertyName = "NullableFunctionToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationParam?), TypeInfoPropertyName = "NullableConversationParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?), TypeInfoPropertyName = "NullableReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateModelResponseProperties?), TypeInfoPropertyName = "NullableCreateModelResponseProperties2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsShared?), TypeInfoPropertyName = "NullableModelIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.VerbosityEnum?), TypeInfoPropertyName = "NullableVerbosityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Tool?), TypeInfoPropertyName = "NullableTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextResponseFormatConfiguration?), TypeInfoPropertyName = "NullableTextResponseFormatConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFidelity?), TypeInfoPropertyName = "NullableInputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateResponse?), TypeInfoPropertyName = "NullableCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum?), TypeInfoPropertyName = "NullableServiceTierResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation?), TypeInfoPropertyName = "NullableCreateResponseVariant3Truncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputParam?), TypeInfoPropertyName = "NullableInputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.IncludeEnum?), TypeInfoPropertyName = "NullableIncludeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallType?), TypeInfoPropertyName = "NullableCustomToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallOutputType?), TypeInfoPropertyName = "NullableCustomToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>?), TypeInfoPropertyName = "NullableOneOfStringIListFunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput?), TypeInfoPropertyName = "NullableFunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallOutputResource?), TypeInfoPropertyName = "NullableCustomToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum?), TypeInfoPropertyName = "NullableFunctionCallOutputStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallResource?), TypeInfoPropertyName = "NullableCustomToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallStatus?), TypeInfoPropertyName = "NullableFunctionCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EasyInputMessageRole?), TypeInfoPropertyName = "NullableEasyInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>?), TypeInfoPropertyName = "NullableOneOfStringIListInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessagePhase?), TypeInfoPropertyName = "NullableMessagePhase2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EasyInputMessageType?), TypeInfoPropertyName = "NullableEasyInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FilePathType?), TypeInfoPropertyName = "NullableFilePathType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolCallType?), TypeInfoPropertyName = "NullableFileSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus?), TypeInfoPropertyName = "NullableFileSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType?), TypeInfoPropertyName = "NullableFunctionAndCustomToolCallOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallType?), TypeInfoPropertyName = "NullableFunctionToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallStatus?), TypeInfoPropertyName = "NullableFunctionToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType?), TypeInfoPropertyName = "NullableFunctionToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus?), TypeInfoPropertyName = "NullableFunctionToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolType?), TypeInfoPropertyName = "NullableImageGenToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolModel?>?), TypeInfoPropertyName = "NullableAnyOfStringImageGenToolModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolModel?), TypeInfoPropertyName = "NullableImageGenToolModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolQuality?), TypeInfoPropertyName = "NullableImageGenToolQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.ImageGenToolSize?>?), TypeInfoPropertyName = "NullableAnyOfStringImageGenToolSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolSize?), TypeInfoPropertyName = "NullableImageGenToolSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat?), TypeInfoPropertyName = "NullableImageGenToolOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolModeration?), TypeInfoPropertyName = "NullableImageGenToolModeration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolBackground?), TypeInfoPropertyName = "NullableImageGenToolBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenActionEnum?), TypeInfoPropertyName = "NullableImageGenActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType?), TypeInfoPropertyName = "NullableInputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputItem?), TypeInfoPropertyName = "NullableInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Item?), TypeInfoPropertyName = "NullableItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType?), TypeInfoPropertyName = "NullableInputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageType?), TypeInfoPropertyName = "NullableInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageRole?), TypeInfoPropertyName = "NullableInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageStatus?), TypeInfoPropertyName = "NullableInputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputMessageResource?), TypeInfoPropertyName = "NullableInputMessageResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemDiscriminatorType?), TypeInfoPropertyName = "NullableItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemResource?), TypeInfoPropertyName = "NullableItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemResourceDiscriminatorType?), TypeInfoPropertyName = "NullableItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallType?), TypeInfoPropertyName = "NullableLocalShellToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus?), TypeInfoPropertyName = "NullableLocalShellToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType?), TypeInfoPropertyName = "NullableLocalShellToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus?), TypeInfoPropertyName = "NullableLocalShellToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalRequestType?), TypeInfoPropertyName = "NullableMCPApprovalRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalResponseType?), TypeInfoPropertyName = "NullableMCPApprovalResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType?), TypeInfoPropertyName = "NullableMCPApprovalResponseResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPListToolsType?), TypeInfoPropertyName = "NullableMCPListToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolType?), TypeInfoPropertyName = "NullableMCPToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolConnectorId?), TypeInfoPropertyName = "NullableMCPToolConnectorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?), TypeInfoPropertyName = "NullableMCPToolRequireApprovalVariant1Enum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCallType?), TypeInfoPropertyName = "NullableMCPToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCallStatus?), TypeInfoPropertyName = "NullableMCPToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType?), TypeInfoPropertyName = "NullableMCPToolCallErrorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsResponses?), TypeInfoPropertyName = "NullableModelIdsResponses2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsCompaction?), TypeInfoPropertyName = "NullableModelIdsCompaction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum?), TypeInfoPropertyName = "NullableModelIdsResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?), TypeInfoPropertyName = "NullableModelIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?), TypeInfoPropertyName = "NullableModelResponsePropertiesPromptCacheRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType?), TypeInfoPropertyName = "NullableOutputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputItem?), TypeInfoPropertyName = "NullableOutputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType?), TypeInfoPropertyName = "NullableOutputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageType?), TypeInfoPropertyName = "NullableOutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageRole?), TypeInfoPropertyName = "NullableOutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContent?), TypeInfoPropertyName = "NullableOutputMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageStatus?), TypeInfoPropertyName = "NullableOutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType?), TypeInfoPropertyName = "NullableOutputMessageContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceOptions?), TypeInfoPropertyName = "NullableToolChoiceOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningModeEnum?), TypeInfoPropertyName = "NullableReasoningModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningSummary?), TypeInfoPropertyName = "NullableReasoningSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningContext?), TypeInfoPropertyName = "NullableReasoningContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary?), TypeInfoPropertyName = "NullableReasoningGenerateSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemType?), TypeInfoPropertyName = "NullableReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemStatus?), TypeInfoPropertyName = "NullableReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Response?), TypeInfoPropertyName = "NullableResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation?), TypeInfoPropertyName = "NullableResponseVariant3Truncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3Object?), TypeInfoPropertyName = "NullableResponseVariant3Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3Status?), TypeInfoPropertyName = "NullableResponseVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason?), TypeInfoPropertyName = "NullableResponseVariant3IncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheDiagnostics?), TypeInfoPropertyName = "NullablePromptCacheDiagnostics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType?), TypeInfoPropertyName = "NullableResponseAudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType?), TypeInfoPropertyName = "NullableResponseAudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType?), TypeInfoPropertyName = "NullableResponseAudioTranscriptDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType?), TypeInfoPropertyName = "NullableResponseAudioTranscriptDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallCodeDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallCodeDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType?), TypeInfoPropertyName = "NullableResponseCodeInterpreterCallInterpretingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCompletedEventType?), TypeInfoPropertyName = "NullableResponseCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType?), TypeInfoPropertyName = "NullableResponseConfigurationUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType?), TypeInfoPropertyName = "NullableResponseConfigurationUpdateItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType?), TypeInfoPropertyName = "NullableResponseContentPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType?), TypeInfoPropertyName = "NullableResponseContentPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCreatedEventType?), TypeInfoPropertyName = "NullableResponseCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType?), TypeInfoPropertyName = "NullableResponseCustomToolCallInputDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType?), TypeInfoPropertyName = "NullableResponseCustomToolCallInputDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseErrorCode?), TypeInfoPropertyName = "NullableResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseErrorEventType?), TypeInfoPropertyName = "NullableResponseErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFailedEventType?), TypeInfoPropertyName = "NullableResponseFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType?), TypeInfoPropertyName = "NullableResponseFileSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType?), TypeInfoPropertyName = "NullableResponseFileSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType?), TypeInfoPropertyName = "NullableResponseFileSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?), TypeInfoPropertyName = "NullableResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFormatTextType?), TypeInfoPropertyName = "NullableResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType?), TypeInfoPropertyName = "NullableResponseFunctionCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType?), TypeInfoPropertyName = "NullableResponseFunctionCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType?), TypeInfoPropertyName = "NullableResponseImageGenCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType?), TypeInfoPropertyName = "NullableResponseImageGenCallGeneratingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType?), TypeInfoPropertyName = "NullableResponseImageGenCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType?), TypeInfoPropertyName = "NullableResponseImageGenCallPartialImageEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseInProgressEventType?), TypeInfoPropertyName = "NullableResponseInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType?), TypeInfoPropertyName = "NullableResponseIncompleteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseItemListObject?), TypeInfoPropertyName = "NullableResponseItemListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType?), TypeInfoPropertyName = "NullableResponseMCPCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType?), TypeInfoPropertyName = "NullableResponseMCPCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType?), TypeInfoPropertyName = "NullableResponseMCPCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType?), TypeInfoPropertyName = "NullableResponseMCPCallFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType?), TypeInfoPropertyName = "NullableResponseMCPCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType?), TypeInfoPropertyName = "NullableResponseMCPListToolsCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType?), TypeInfoPropertyName = "NullableResponseMCPListToolsFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType?), TypeInfoPropertyName = "NullableResponseMCPListToolsInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType?), TypeInfoPropertyName = "NullableResponseOutputItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType?), TypeInfoPropertyName = "NullableResponseOutputItemDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType?), TypeInfoPropertyName = "NullableResponseOutputTextAnnotationAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>?), TypeInfoPropertyName = "NullableOneOfStringInputTextContentInputImageContentInputFileContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceParam?), TypeInfoPropertyName = "NullableToolChoiceParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseQueuedEventType?), TypeInfoPropertyName = "NullableResponseQueuedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType?), TypeInfoPropertyName = "NullableResponseReasoningSummaryPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType?), TypeInfoPropertyName = "NullableResponseReasoningSummaryPartAddedEventPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType?), TypeInfoPropertyName = "NullableResponseReasoningSummaryPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus?), TypeInfoPropertyName = "NullableResponseReasoningSummaryPartDoneEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType?), TypeInfoPropertyName = "NullableResponseReasoningSummaryPartDoneEventPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType?), TypeInfoPropertyName = "NullableResponseReasoningSummaryTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType?), TypeInfoPropertyName = "NullableResponseReasoningSummaryTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType?), TypeInfoPropertyName = "NullableResponseReasoningTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType?), TypeInfoPropertyName = "NullableResponseReasoningTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType?), TypeInfoPropertyName = "NullableResponseRefusalDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType?), TypeInfoPropertyName = "NullableResponseRefusalDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseStreamEvent?), TypeInfoPropertyName = "NullableResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType?), TypeInfoPropertyName = "NullableResponseTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType?), TypeInfoPropertyName = "NullableResponseTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType?), TypeInfoPropertyName = "NullableResponseWebSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType?), TypeInfoPropertyName = "NullableResponseWebSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType?), TypeInfoPropertyName = "NullableResponseWebSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableTextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?), TypeInfoPropertyName = "NullableToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType?), TypeInfoPropertyName = "NullableToolChoiceAllowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode?), TypeInfoPropertyName = "NullableToolChoiceAllowedMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceCustomType?), TypeInfoPropertyName = "NullableToolChoiceCustomType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?), TypeInfoPropertyName = "NullableToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?), TypeInfoPropertyName = "NullableToolChoiceMCPType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolChoiceTypesType?), TypeInfoPropertyName = "NullableToolChoiceTypesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionFindType?), TypeInfoPropertyName = "NullableWebSearchActionFindType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType?), TypeInfoPropertyName = "NullableWebSearchActionOpenPageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionSearchType?), TypeInfoPropertyName = "NullableWebSearchActionSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType?), TypeInfoPropertyName = "NullableWebSearchActionSearchSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type?), TypeInfoPropertyName = "NullableWebSearchApproximateLocationWebSearchApproximateLocation1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolType?), TypeInfoPropertyName = "NullableWebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize?), TypeInfoPropertyName = "NullableWebSearchToolSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCallType?), TypeInfoPropertyName = "NullableWebSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchCallStatus?), TypeInfoPropertyName = "NullableWebSearchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCallAction?), TypeInfoPropertyName = "NullableWebSearchToolCallAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType?), TypeInfoPropertyName = "NullableWebSearchToolCallActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorType?), TypeInfoPropertyName = "NullableMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationInputType?), TypeInfoPropertyName = "NullableModerationInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationResultBodyType?), TypeInfoPropertyName = "NullableModerationResultBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?), TypeInfoPropertyName = "NullablePromptCacheTTLEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?), TypeInfoPropertyName = "NullablePromptCacheModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?), TypeInfoPropertyName = "NullablePromptCacheBreakpointParamMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationMode?), TypeInfoPropertyName = "NullableModerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillReferenceParamType?), TypeInfoPropertyName = "NullableSkillReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType?), TypeInfoPropertyName = "NullableInlineSkillSourceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType?), TypeInfoPropertyName = "NullableInlineSkillSourceParamMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillParamType?), TypeInfoPropertyName = "NullableInlineSkillParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType?), TypeInfoPropertyName = "NullableContainerNetworkPolicyDisabledParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType?), TypeInfoPropertyName = "NullableContainerNetworkPolicyAllowlistParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageStatus?), TypeInfoPropertyName = "NullableMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageRole?), TypeInfoPropertyName = "NullableMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?), TypeInfoPropertyName = "NullablePromptCacheBreakpointConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentType?), TypeInfoPropertyName = "NullableInputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileCitationBodyType?), TypeInfoPropertyName = "NullableFileCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UrlCitationBodyType?), TypeInfoPropertyName = "NullableUrlCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType?), TypeInfoPropertyName = "NullableContainerFileCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType?), TypeInfoPropertyName = "NullableAnnotationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputTextContentType?), TypeInfoPropertyName = "NullableOutputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TextContentType?), TypeInfoPropertyName = "NullableTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SummaryTextContentType?), TypeInfoPropertyName = "NullableSummaryTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningTextContentType?), TypeInfoPropertyName = "NullableReasoningTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RefusalContentType?), TypeInfoPropertyName = "NullableRefusalContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageDetail?), TypeInfoPropertyName = "NullableImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContentType?), TypeInfoPropertyName = "NullableInputImageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType?), TypeInfoPropertyName = "NullableComputerScreenshotContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileInputDetail?), TypeInfoPropertyName = "NullableFileInputDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContentType?), TypeInfoPropertyName = "NullableInputFileContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessagePhase2?), TypeInfoPropertyName = "NullableMessagePhase22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageType?), TypeInfoPropertyName = "NullableMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem3?), TypeInfoPropertyName = "NullableContentItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType?), TypeInfoPropertyName = "NullableMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DirectToolCallCallerType?), TypeInfoPropertyName = "NullableDirectToolCallCallerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType?), TypeInfoPropertyName = "NullableProgramToolCallCallerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType?), TypeInfoPropertyName = "NullableToolCallCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType?), TypeInfoPropertyName = "NullableDirectToolCallCallerParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType?), TypeInfoPropertyName = "NullableProgramToolCallCallerParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType?), TypeInfoPropertyName = "NullableToolCallCallerParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageBackground?), TypeInfoPropertyName = "NullableImageBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageOutputFormat?), TypeInfoPropertyName = "NullableImageOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCallType?), TypeInfoPropertyName = "NullableImageGenToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus?), TypeInfoPropertyName = "NullableImageGenToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?), TypeInfoPropertyName = "NullableImageGenToolCallSizeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality?), TypeInfoPropertyName = "NullableImageGenToolCallQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClickButtonType?), TypeInfoPropertyName = "NullableClickButtonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ClickParamType?), TypeInfoPropertyName = "NullableClickParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DoubleClickActionType?), TypeInfoPropertyName = "NullableDoubleClickActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DragParamType?), TypeInfoPropertyName = "NullableDragParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.KeyPressActionType?), TypeInfoPropertyName = "NullableKeyPressActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MoveParamType?), TypeInfoPropertyName = "NullableMoveParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ScreenshotParamType?), TypeInfoPropertyName = "NullableScreenshotParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ScrollParamType?), TypeInfoPropertyName = "NullableScrollParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TypeParamType?), TypeInfoPropertyName = "NullableTypeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WaitParamType?), TypeInfoPropertyName = "NullableWaitParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchExecutionType?), TypeInfoPropertyName = "NullableToolSearchExecutionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchCallType?), TypeInfoPropertyName = "NullableToolSearchCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolType?), TypeInfoPropertyName = "NullableFunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RankerVersionType?), TypeInfoPropertyName = "NullableRankerVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Filters2?), TypeInfoPropertyName = "NullableFilters22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileSearchToolType?), TypeInfoPropertyName = "NullableFileSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerToolType?), TypeInfoPropertyName = "NullableComputerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerEnvironment?), TypeInfoPropertyName = "NullableComputerEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType?), TypeInfoPropertyName = "NullableComputerUsePreviewToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerMemoryLimit?), TypeInfoPropertyName = "NullableContainerMemoryLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType?), TypeInfoPropertyName = "NullableAutoCodeInterpreterToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicy2?), TypeInfoPropertyName = "NullableNetworkPolicy22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?), TypeInfoPropertyName = "NullableAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType?), TypeInfoPropertyName = "NullableProgrammaticToolCallingParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellToolParamType?), TypeInfoPropertyName = "NullableLocalShellToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParamType?), TypeInfoPropertyName = "NullableContainerAutoParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicy3?), TypeInfoPropertyName = "NullableNetworkPolicy32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType?), TypeInfoPropertyName = "NullableContainerAutoParamNetworkPolicyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillsItem2?), TypeInfoPropertyName = "NullableSkillsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType?), TypeInfoPropertyName = "NullableContainerAutoParamSkillDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType?), TypeInfoPropertyName = "NullableLocalEnvironmentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerReferenceParamType?), TypeInfoPropertyName = "NullableContainerReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellToolParamType?), TypeInfoPropertyName = "NullableFunctionShellToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableFunctionShellToolParamEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomTextFormatParamType?), TypeInfoPropertyName = "NullableCustomTextFormatParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.GrammarSyntax1?), TypeInfoPropertyName = "NullableGrammarSyntax12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType?), TypeInfoPropertyName = "NullableCustomGrammarFormatParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolParamType?), TypeInfoPropertyName = "NullableCustomToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Format2?), TypeInfoPropertyName = "NullableFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType?), TypeInfoPropertyName = "NullableCustomToolParamFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolParamType?), TypeInfoPropertyName = "NullableFunctionToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NamespaceToolParamType?), TypeInfoPropertyName = "NullableNamespaceToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolsItem13?), TypeInfoPropertyName = "NullableToolsItem132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType?), TypeInfoPropertyName = "NullableNamespaceToolParamToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchToolParamType?), TypeInfoPropertyName = "NullableToolSearchToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApproximateLocationType?), TypeInfoPropertyName = "NullableApproximateLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SearchContextSize?), TypeInfoPropertyName = "NullableSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SearchContentType?), TypeInfoPropertyName = "NullableSearchContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType?), TypeInfoPropertyName = "NullableWebSearchPreviewToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType?), TypeInfoPropertyName = "NullableApplyPatchToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchOutputType?), TypeInfoPropertyName = "NullableToolSearchOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdditionalToolsType?), TypeInfoPropertyName = "NullableAdditionalToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramType?), TypeInfoPropertyName = "NullableProgramType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramOutputStatus?), TypeInfoPropertyName = "NullableProgramOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramOutputType?), TypeInfoPropertyName = "NullableProgramOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionBodyType?), TypeInfoPropertyName = "NullableCompactionBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType?), TypeInfoPropertyName = "NullableCodeInterpreterOutputLogsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType?), TypeInfoPropertyName = "NullableCodeInterpreterOutputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalShellExecActionType?), TypeInfoPropertyName = "NullableLocalShellExecActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallStatus?), TypeInfoPropertyName = "NullableFunctionShellCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType?), TypeInfoPropertyName = "NullableLocalEnvironmentResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType?), TypeInfoPropertyName = "NullableContainerReferenceResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallType?), TypeInfoPropertyName = "NullableFunctionShellCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableFunctionShellCallEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum?), TypeInfoPropertyName = "NullableFunctionShellCallOutputStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType?), TypeInfoPropertyName = "NullableFunctionShellCallOutputTimeoutOutcomeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType?), TypeInfoPropertyName = "NullableFunctionShellCallOutputExitOutcomeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Outcome?), TypeInfoPropertyName = "NullableOutcome2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType?), TypeInfoPropertyName = "NullableFunctionShellCallOutputContentOutcomeDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType?), TypeInfoPropertyName = "NullableFunctionShellCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus?), TypeInfoPropertyName = "NullableApplyPatchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType?), TypeInfoPropertyName = "NullableApplyPatchCreateFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType?), TypeInfoPropertyName = "NullableApplyPatchDeleteFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType?), TypeInfoPropertyName = "NullableApplyPatchUpdateFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType?), TypeInfoPropertyName = "NullableApplyPatchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Operation?), TypeInfoPropertyName = "NullableOperation2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType?), TypeInfoPropertyName = "NullableApplyPatchToolCallOperationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus?), TypeInfoPropertyName = "NullableApplyPatchCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType?), TypeInfoPropertyName = "NullableApplyPatchToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPProtocolErrorType?), TypeInfoPropertyName = "NullableMCPProtocolErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType?), TypeInfoPropertyName = "NullableMCPToolExecutionErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.HTTPErrorType?), TypeInfoPropertyName = "NullableHTTPErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DetailEnum?), TypeInfoPropertyName = "NullableDetailEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallItemStatus?), TypeInfoPropertyName = "NullableFunctionCallItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType?), TypeInfoPropertyName = "NullableComputerCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputTextContentParamType?), TypeInfoPropertyName = "NullableInputTextContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType?), TypeInfoPropertyName = "NullableInputImageContentParamAutoParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FileDetailEnum?), TypeInfoPropertyName = "NullableFileDetailEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFileContentParamType?), TypeInfoPropertyName = "NullableInputFileContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType?), TypeInfoPropertyName = "NullableFunctionCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>?), TypeInfoPropertyName = "NullableOneOfStringIListOutputVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputVariant2Item?), TypeInfoPropertyName = "NullableOutputVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?), TypeInfoPropertyName = "NullableFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType?), TypeInfoPropertyName = "NullableToolSearchCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType?), TypeInfoPropertyName = "NullableToolSearchOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType?), TypeInfoPropertyName = "NullableAdditionalToolsItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole?), TypeInfoPropertyName = "NullableAdditionalToolsItemParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType?), TypeInfoPropertyName = "NullableCompactionSummaryItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus?), TypeInfoPropertyName = "NullableFunctionShellCallItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType?), TypeInfoPropertyName = "NullableFunctionShellCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType?), TypeInfoPropertyName = "NullableFunctionShellCallOutputTimeoutOutcomeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType?), TypeInfoPropertyName = "NullableFunctionShellCallOutputExitOutcomeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParam?), TypeInfoPropertyName = "NullableFunctionShellCallOutputOutcomeParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType?), TypeInfoPropertyName = "NullableFunctionShellCallOutputOutcomeParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType?), TypeInfoPropertyName = "NullableFunctionShellCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam?), TypeInfoPropertyName = "NullableApplyPatchCallStatusParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType?), TypeInfoPropertyName = "NullableApplyPatchCreateFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType?), TypeInfoPropertyName = "NullableApplyPatchDeleteFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType?), TypeInfoPropertyName = "NullableApplyPatchUpdateFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchOperationParam?), TypeInfoPropertyName = "NullableApplyPatchOperationParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType?), TypeInfoPropertyName = "NullableApplyPatchOperationParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType?), TypeInfoPropertyName = "NullableApplyPatchToolCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam?), TypeInfoPropertyName = "NullableApplyPatchCallOutputStatusParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType?), TypeInfoPropertyName = "NullableApplyPatchToolCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType?), TypeInfoPropertyName = "NullableCompactionTriggerItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemReferenceParamType?), TypeInfoPropertyName = "NullableItemReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramItemParamType?), TypeInfoPropertyName = "NullableProgramItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus?), TypeInfoPropertyName = "NullableProgramOutputItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType?), TypeInfoPropertyName = "NullableProgramOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType?), TypeInfoPropertyName = "NullableSpecificProgrammaticToolCallingParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType?), TypeInfoPropertyName = "NullableSpecificApplyPatchParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType?), TypeInfoPropertyName = "NullableSpecificFunctionShellParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum?), TypeInfoPropertyName = "NullableCyberAccessProgramEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum?), TypeInfoPropertyName = "NullableReasoningModeEnumEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum?), TypeInfoPropertyName = "NullableCacheMissReasonTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType?), TypeInfoPropertyName = "NullablePromptCacheMissDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType?), TypeInfoPropertyName = "NullablePromptCacheHitDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType?), TypeInfoPropertyName = "NullablePromptCacheComparisonResponseNotFoundDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType?), TypeInfoPropertyName = "NullablePromptCacheUnavailableDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType?), TypeInfoPropertyName = "NullablePromptCacheDiagnosticsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationErrorBodyType?), TypeInfoPropertyName = "NullableModerationErrorBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Input4?), TypeInfoPropertyName = "NullableInput42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType?), TypeInfoPropertyName = "NullableModerationInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Output5?), TypeInfoPropertyName = "NullableOutput52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType?), TypeInfoPropertyName = "NullableModerationOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType?), TypeInfoPropertyName = "NullableResponseCompactionCompactingStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType?), TypeInfoPropertyName = "NullableResponseShellCallCommandAddedStreamingEventType2")]
    internal sealed partial class ResponsesSourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType?), TypeInfoPropertyName = "NullableResponseShellCallCommandDeltaStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType?), TypeInfoPropertyName = "NullableResponseShellCallCommandDoneStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType?), TypeInfoPropertyName = "NullableResponseShellCallOutputContentDeltaStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType?), TypeInfoPropertyName = "NullableResponseShellCallOutputContentDoneStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TruncationEnum?), TypeInfoPropertyName = "NullableTruncationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersonalityEnum?), TypeInfoPropertyName = "NullablePersonalityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PersonalityEnumEnum?), TypeInfoPropertyName = "NullablePersonalityEnumEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.TokenCountsResourceObject?), TypeInfoPropertyName = "NullableTokenCountsResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheRetentionEnum?), TypeInfoPropertyName = "NullablePromptCacheRetentionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ServiceTierEnum2?), TypeInfoPropertyName = "NullableServiceTierEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemField?), TypeInfoPropertyName = "NullableItemField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemFieldDiscriminatorType?), TypeInfoPropertyName = "NullableItemFieldDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompactResourceObject?), TypeInfoPropertyName = "NullableCompactResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTokenCountsResourceObject?), TypeInfoPropertyName = "NullableBetaTokenCountsResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputItem?), TypeInfoPropertyName = "NullableBetaInputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTool?), TypeInfoPropertyName = "NullableBetaTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTruncationEnum?), TypeInfoPropertyName = "NullableBetaTruncationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPersonalityEnum?), TypeInfoPropertyName = "NullableBetaPersonalityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions?), TypeInfoPropertyName = "NullableBetaToolChoiceOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType?), TypeInfoPropertyName = "NullableBetaSpecificFunctionShellParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType?), TypeInfoPropertyName = "NullableBetaSpecificApplyPatchParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType?), TypeInfoPropertyName = "NullableBetaSpecificProgrammaticToolCallingParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType?), TypeInfoPropertyName = "NullableBetaToolChoiceCustomType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType?), TypeInfoPropertyName = "NullableBetaToolChoiceMCPType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType?), TypeInfoPropertyName = "NullableBetaToolChoiceFunctionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType?), TypeInfoPropertyName = "NullableBetaToolChoiceTypesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType?), TypeInfoPropertyName = "NullableBetaToolChoiceAllowedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode?), TypeInfoPropertyName = "NullableBetaToolChoiceAllowedMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPersonalityEnumEnum?), TypeInfoPropertyName = "NullableBetaPersonalityEnumEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningModeEnum?), TypeInfoPropertyName = "NullableBetaReasoningModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum?), TypeInfoPropertyName = "NullableBetaReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningSummary?), TypeInfoPropertyName = "NullableBetaReasoningSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningContext?), TypeInfoPropertyName = "NullableBetaReasoningContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary?), TypeInfoPropertyName = "NullableBetaReasoningGenerateSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?), TypeInfoPropertyName = "NullableBetaReasoningModeEnumEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration?), TypeInfoPropertyName = "NullableBetaTextResponseFormatConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaVerbosityEnum?), TypeInfoPropertyName = "NullableBetaVerbosityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType?), TypeInfoPropertyName = "NullableBetaResponseFormatJsonObjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType?), TypeInfoPropertyName = "NullableBetaTextResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType?), TypeInfoPropertyName = "NullableBetaResponseFormatTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType?), TypeInfoPropertyName = "NullableBetaToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType?), TypeInfoPropertyName = "NullableBetaApplyPatchToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller?), TypeInfoPropertyName = "NullableBetaCallableToolAllowedCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType?), TypeInfoPropertyName = "NullableBetaWebSearchPreviewToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSearchContextSize?), TypeInfoPropertyName = "NullableBetaSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSearchContentType?), TypeInfoPropertyName = "NullableBetaSearchContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApproximateLocationType?), TypeInfoPropertyName = "NullableBetaApproximateLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType?), TypeInfoPropertyName = "NullableBetaToolSearchToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType?), TypeInfoPropertyName = "NullableBetaToolSearchExecutionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType?), TypeInfoPropertyName = "NullableBetaNamespaceToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolsItem16?), TypeInfoPropertyName = "NullableToolsItem162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType?), TypeInfoPropertyName = "NullableBetaNamespaceToolParamToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolParamType?), TypeInfoPropertyName = "NullableBetaCustomToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Format3?), TypeInfoPropertyName = "NullableFormat32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType?), TypeInfoPropertyName = "NullableBetaCustomToolParamFormatDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType?), TypeInfoPropertyName = "NullableBetaCustomGrammarFormatParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1?), TypeInfoPropertyName = "NullableBetaGrammarSyntax12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType?), TypeInfoPropertyName = "NullableBetaCustomTextFormatParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType?), TypeInfoPropertyName = "NullableBetaFunctionToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType?), TypeInfoPropertyName = "NullableBetaFunctionShellToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableBetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType?), TypeInfoPropertyName = "NullableBetaContainerReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType?), TypeInfoPropertyName = "NullableBetaLocalEnvironmentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType?), TypeInfoPropertyName = "NullableBetaContainerAutoParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit?), TypeInfoPropertyName = "NullableBetaContainerMemoryLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicy4?), TypeInfoPropertyName = "NullableNetworkPolicy42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType?), TypeInfoPropertyName = "NullableBetaContainerAutoParamNetworkPolicyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillsItem3?), TypeInfoPropertyName = "NullableSkillsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType?), TypeInfoPropertyName = "NullableBetaContainerAutoParamSkillDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType?), TypeInfoPropertyName = "NullableBetaInlineSkillParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType?), TypeInfoPropertyName = "NullableBetaInlineSkillSourceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType?), TypeInfoPropertyName = "NullableBetaInlineSkillSourceParamMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType?), TypeInfoPropertyName = "NullableBetaSkillReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType?), TypeInfoPropertyName = "NullableBetaContainerNetworkPolicyAllowlistParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType?), TypeInfoPropertyName = "NullableBetaContainerNetworkPolicyDisabledParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType?), TypeInfoPropertyName = "NullableBetaLocalShellToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolType?), TypeInfoPropertyName = "NullableBetaImageGenToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>?), TypeInfoPropertyName = "NullableAnyOfStringBetaImageGenToolModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolModel?), TypeInfoPropertyName = "NullableBetaImageGenToolModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality?), TypeInfoPropertyName = "NullableBetaImageGenToolQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>?), TypeInfoPropertyName = "NullableAnyOfStringBetaImageGenToolSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolSize?), TypeInfoPropertyName = "NullableBetaImageGenToolSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat?), TypeInfoPropertyName = "NullableBetaImageGenToolOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration?), TypeInfoPropertyName = "NullableBetaImageGenToolModeration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground?), TypeInfoPropertyName = "NullableBetaImageGenToolBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputFidelity?), TypeInfoPropertyName = "NullableBetaInputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum?), TypeInfoPropertyName = "NullableBetaImageGenActionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType?), TypeInfoPropertyName = "NullableBetaProgrammaticToolCallingParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType?), TypeInfoPropertyName = "NullableBetaCodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>?), TypeInfoPropertyName = "NullableOneOfStringBetaAutoCodeInterpreterToolParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType?), TypeInfoPropertyName = "NullableBetaAutoCodeInterpreterToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.NetworkPolicy5?), TypeInfoPropertyName = "NullableNetworkPolicy52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?), TypeInfoPropertyName = "NullableBetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolType?), TypeInfoPropertyName = "NullableBetaMCPToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId?), TypeInfoPropertyName = "NullableBetaMCPToolConnectorId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?), TypeInfoPropertyName = "NullableBetaMCPToolRequireApprovalVariant1Enum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolType?), TypeInfoPropertyName = "NullableBetaWebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize?), TypeInfoPropertyName = "NullableBetaWebSearchToolSearchContextSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType?), TypeInfoPropertyName = "NullableBetaWebSearchApproximateLocationWebSearchApproximateLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType?), TypeInfoPropertyName = "NullableBetaComputerUsePreviewToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerEnvironment?), TypeInfoPropertyName = "NullableBetaComputerEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolType?), TypeInfoPropertyName = "NullableBetaComputerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileSearchToolType?), TypeInfoPropertyName = "NullableBetaFileSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompoundFilterType?), TypeInfoPropertyName = "NullableBetaCompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FiltersItem2?), TypeInfoPropertyName = "NullableFiltersItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComparisonFilterType?), TypeInfoPropertyName = "NullableBetaComparisonFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaRankerVersionType?), TypeInfoPropertyName = "NullableBetaRankerVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolType?), TypeInfoPropertyName = "NullableBetaFunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItem?), TypeInfoPropertyName = "NullableBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType?), TypeInfoPropertyName = "NullableBetaInputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType?), TypeInfoPropertyName = "NullableBetaProgramOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus?), TypeInfoPropertyName = "NullableBetaProgramOutputItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramItemParamType?), TypeInfoPropertyName = "NullableBetaProgramItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType?), TypeInfoPropertyName = "NullableBetaItemReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType?), TypeInfoPropertyName = "NullableBetaCompactionTriggerItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType?), TypeInfoPropertyName = "NullableBetaItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCallType?), TypeInfoPropertyName = "NullableBetaCustomToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType?), TypeInfoPropertyName = "NullableBetaToolCallCallerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType?), TypeInfoPropertyName = "NullableBetaProgramToolCallCallerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType?), TypeInfoPropertyName = "NullableBetaDirectToolCallCallerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType?), TypeInfoPropertyName = "NullableBetaCustomToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>?), TypeInfoPropertyName = "NullableOneOfStringIListBetaFunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput?), TypeInfoPropertyName = "NullableBetaFunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType?), TypeInfoPropertyName = "NullableBetaFunctionAndCustomToolCallOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputFileContentType?), TypeInfoPropertyName = "NullableBetaInputFileContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileInputDetail?), TypeInfoPropertyName = "NullableBetaFileInputDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode?), TypeInfoPropertyName = "NullableBetaPromptCacheBreakpointConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputImageContentType?), TypeInfoPropertyName = "NullableBetaInputImageContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageDetail?), TypeInfoPropertyName = "NullableBetaImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputTextContentType?), TypeInfoPropertyName = "NullableBetaInputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType?), TypeInfoPropertyName = "NullableBetaToolCallCallerParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType?), TypeInfoPropertyName = "NullableBetaProgramToolCallCallerParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType?), TypeInfoPropertyName = "NullableBetaDirectToolCallCallerParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolCallType?), TypeInfoPropertyName = "NullableBetaMCPToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus?), TypeInfoPropertyName = "NullableBetaMCPToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType?), TypeInfoPropertyName = "NullableBetaMCPToolCallErrorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaHTTPErrorType?), TypeInfoPropertyName = "NullableBetaHTTPErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType?), TypeInfoPropertyName = "NullableBetaMCPToolExecutionErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType?), TypeInfoPropertyName = "NullableBetaMCPProtocolErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType?), TypeInfoPropertyName = "NullableBetaMCPApprovalResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType?), TypeInfoPropertyName = "NullableBetaMCPApprovalRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPListToolsType?), TypeInfoPropertyName = "NullableBetaMCPListToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType?), TypeInfoPropertyName = "NullableBetaApplyPatchToolCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam?), TypeInfoPropertyName = "NullableBetaApplyPatchCallOutputStatusParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType?), TypeInfoPropertyName = "NullableBetaApplyPatchToolCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam?), TypeInfoPropertyName = "NullableBetaApplyPatchCallStatusParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParam?), TypeInfoPropertyName = "NullableBetaApplyPatchOperationParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType?), TypeInfoPropertyName = "NullableBetaApplyPatchOperationParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType?), TypeInfoPropertyName = "NullableBetaApplyPatchUpdateFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType?), TypeInfoPropertyName = "NullableBetaApplyPatchDeleteFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType?), TypeInfoPropertyName = "NullableBetaApplyPatchCreateFileOperationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus?), TypeInfoPropertyName = "NullableBetaFunctionShellCallItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParam?), TypeInfoPropertyName = "NullableBetaFunctionShellCallOutputOutcomeParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallOutputOutcomeParamDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallOutputExitOutcomeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallOutputTimeoutOutcomeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType?), TypeInfoPropertyName = "NullableBetaLocalShellToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus?), TypeInfoPropertyName = "NullableBetaLocalShellToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType?), TypeInfoPropertyName = "NullableBetaLocalShellToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus?), TypeInfoPropertyName = "NullableBetaLocalShellToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType?), TypeInfoPropertyName = "NullableBetaLocalShellExecActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType?), TypeInfoPropertyName = "NullableBetaCodeInterpreterToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus?), TypeInfoPropertyName = "NullableBetaCodeInterpreterToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputsVariant1Item2?), TypeInfoPropertyName = "NullableOutputsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableBetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType?), TypeInfoPropertyName = "NullableBetaCodeInterpreterOutputImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType?), TypeInfoPropertyName = "NullableBetaCodeInterpreterOutputLogsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType?), TypeInfoPropertyName = "NullableBetaImageGenToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus?), TypeInfoPropertyName = "NullableBetaImageGenToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?), TypeInfoPropertyName = "NullableBetaImageGenToolCallSizeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality?), TypeInfoPropertyName = "NullableBetaImageGenToolCallQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageBackground?), TypeInfoPropertyName = "NullableBetaImageBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaImageOutputFormat?), TypeInfoPropertyName = "NullableBetaImageOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType?), TypeInfoPropertyName = "NullableBetaCompactionSummaryItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningItemType?), TypeInfoPropertyName = "NullableBetaReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus?), TypeInfoPropertyName = "NullableBetaReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType?), TypeInfoPropertyName = "NullableBetaReasoningTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType?), TypeInfoPropertyName = "NullableBetaSummaryTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType?), TypeInfoPropertyName = "NullableBetaResponseConfigurationUpdateItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType?), TypeInfoPropertyName = "NullableBetaAdditionalToolsItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole?), TypeInfoPropertyName = "NullableBetaAdditionalToolsItemParamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType?), TypeInfoPropertyName = "NullableBetaToolSearchOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus?), TypeInfoPropertyName = "NullableBetaFunctionCallItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType?), TypeInfoPropertyName = "NullableBetaToolSearchCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType?), TypeInfoPropertyName = "NullableBetaMultiAgentCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1?), TypeInfoPropertyName = "NullableBetaMultiAgentAction12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType?), TypeInfoPropertyName = "NullableBetaOutputTextContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.AnnotationsItem4?), TypeInfoPropertyName = "NullableAnnotationsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType?), TypeInfoPropertyName = "NullableBetaOutputTextContentParamAnnotationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType?), TypeInfoPropertyName = "NullableBetaContainerFileCitationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType?), TypeInfoPropertyName = "NullableBetaUrlCitationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileCitationParamType?), TypeInfoPropertyName = "NullableBetaFileCitationParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType?), TypeInfoPropertyName = "NullableBetaMultiAgentCallItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType?), TypeInfoPropertyName = "NullableBetaAgentMessageItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem6?), TypeInfoPropertyName = "NullableContentItem62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType?), TypeInfoPropertyName = "NullableBetaAgentMessageItemParamContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType?), TypeInfoPropertyName = "NullableBetaEncryptedContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType?), TypeInfoPropertyName = "NullableBetaInputImageContentParamAutoParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDetailEnum?), TypeInfoPropertyName = "NullableBetaDetailEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode?), TypeInfoPropertyName = "NullableBetaPromptCacheBreakpointParamMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType?), TypeInfoPropertyName = "NullableBetaInputTextContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType?), TypeInfoPropertyName = "NullableBetaFunctionCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>>?), TypeInfoPropertyName = "NullableOneOfStringIListOutputVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputVariant2Item2?), TypeInfoPropertyName = "NullableOutputVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?), TypeInfoPropertyName = "NullableBetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType?), TypeInfoPropertyName = "NullableBetaInputFileContentParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileDetailEnum?), TypeInfoPropertyName = "NullableBetaFileDetailEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType?), TypeInfoPropertyName = "NullableBetaFunctionToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus?), TypeInfoPropertyName = "NullableBetaFunctionToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType?), TypeInfoPropertyName = "NullableBetaWebSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus?), TypeInfoPropertyName = "NullableBetaWebSearchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallAction?), TypeInfoPropertyName = "NullableBetaWebSearchToolCallAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType?), TypeInfoPropertyName = "NullableBetaWebSearchToolCallActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType?), TypeInfoPropertyName = "NullableBetaWebSearchActionFindType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType?), TypeInfoPropertyName = "NullableBetaWebSearchActionOpenPageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType?), TypeInfoPropertyName = "NullableBetaWebSearchActionSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType?), TypeInfoPropertyName = "NullableBetaWebSearchActionSearchSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType?), TypeInfoPropertyName = "NullableBetaComputerCallOutputItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType?), TypeInfoPropertyName = "NullableBetaComputerScreenshotImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallType?), TypeInfoPropertyName = "NullableBetaComputerToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerAction?), TypeInfoPropertyName = "NullableBetaComputerAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus?), TypeInfoPropertyName = "NullableBetaComputerToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType?), TypeInfoPropertyName = "NullableBetaComputerActionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaWaitParamType?), TypeInfoPropertyName = "NullableBetaWaitParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTypeParamType?), TypeInfoPropertyName = "NullableBetaTypeParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaScrollParamType?), TypeInfoPropertyName = "NullableBetaScrollParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaScreenshotParamType?), TypeInfoPropertyName = "NullableBetaScreenshotParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMoveParamType?), TypeInfoPropertyName = "NullableBetaMoveParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaKeyPressActionType?), TypeInfoPropertyName = "NullableBetaKeyPressActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDragParamType?), TypeInfoPropertyName = "NullableBetaDragParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType?), TypeInfoPropertyName = "NullableBetaDoubleClickActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaClickParamType?), TypeInfoPropertyName = "NullableBetaClickParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaClickButtonType?), TypeInfoPropertyName = "NullableBetaClickButtonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType?), TypeInfoPropertyName = "NullableBetaFileSearchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus?), TypeInfoPropertyName = "NullableBetaFileSearchToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessageType?), TypeInfoPropertyName = "NullableBetaOutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessageRole?), TypeInfoPropertyName = "NullableBetaOutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessageContent?), TypeInfoPropertyName = "NullableBetaOutputMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessagePhase?), TypeInfoPropertyName = "NullableBetaMessagePhase2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus?), TypeInfoPropertyName = "NullableBetaOutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType?), TypeInfoPropertyName = "NullableBetaOutputMessageContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaRefusalContentType?), TypeInfoPropertyName = "NullableBetaRefusalContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputTextContentType?), TypeInfoPropertyName = "NullableBetaOutputTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAnnotation?), TypeInfoPropertyName = "NullableBetaAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType?), TypeInfoPropertyName = "NullableBetaAnnotationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFilePathType?), TypeInfoPropertyName = "NullableBetaFilePathType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType?), TypeInfoPropertyName = "NullableBetaContainerFileCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType?), TypeInfoPropertyName = "NullableBetaUrlCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType?), TypeInfoPropertyName = "NullableBetaFileCitationBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputMessageType?), TypeInfoPropertyName = "NullableBetaInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputMessageRole?), TypeInfoPropertyName = "NullableBetaInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputMessageStatus?), TypeInfoPropertyName = "NullableBetaInputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputContent?), TypeInfoPropertyName = "NullableBetaInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType?), TypeInfoPropertyName = "NullableBetaInputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole?), TypeInfoPropertyName = "NullableBetaEasyInputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>>?), TypeInfoPropertyName = "NullableOneOfStringIListBetaInputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType?), TypeInfoPropertyName = "NullableBetaEasyInputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelIdsCompaction?), TypeInfoPropertyName = "NullableBetaModelIdsCompaction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheRetentionEnum?), TypeInfoPropertyName = "NullableBetaPromptCacheRetentionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaServiceTierEnum?), TypeInfoPropertyName = "NullableBetaServiceTierEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum?), TypeInfoPropertyName = "NullableBetaPromptCacheTTLEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum?), TypeInfoPropertyName = "NullableBetaPromptCacheModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelIdsResponses?), TypeInfoPropertyName = "NullableBetaModelIdsResponses2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelIdsShared?), TypeInfoPropertyName = "NullableBetaModelIdsShared2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?), TypeInfoPropertyName = "NullableBetaModelIdsResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum?), TypeInfoPropertyName = "NullableBetaModelIdsSharedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorType?), TypeInfoPropertyName = "NullableBetaMisalignmentErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?), TypeInfoPropertyName = "NullableBetaMisalignmentErrorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseItemListObject?), TypeInfoPropertyName = "NullableBetaResponseItemListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemResource?), TypeInfoPropertyName = "NullableBetaItemResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputMessageResource?), TypeInfoPropertyName = "NullableBetaInputMessageResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputResource?), TypeInfoPropertyName = "NullableBetaComputerToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallResource?), TypeInfoPropertyName = "NullableBetaFunctionToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputResource?), TypeInfoPropertyName = "NullableBetaFunctionToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCallResource?), TypeInfoPropertyName = "NullableBetaCustomToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputResource?), TypeInfoPropertyName = "NullableBetaCustomToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemResourceDiscriminatorType?), TypeInfoPropertyName = "NullableBetaItemResourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum?), TypeInfoPropertyName = "NullableBetaFunctionCallOutputStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus?), TypeInfoPropertyName = "NullableBetaFunctionCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType?), TypeInfoPropertyName = "NullableBetaMCPApprovalResponseResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType?), TypeInfoPropertyName = "NullableBetaApplyPatchToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus?), TypeInfoPropertyName = "NullableBetaApplyPatchCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType?), TypeInfoPropertyName = "NullableBetaApplyPatchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus?), TypeInfoPropertyName = "NullableBetaApplyPatchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Operation2?), TypeInfoPropertyName = "NullableOperation22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType?), TypeInfoPropertyName = "NullableBetaApplyPatchToolCallOperationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType?), TypeInfoPropertyName = "NullableBetaApplyPatchUpdateFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType?), TypeInfoPropertyName = "NullableBetaApplyPatchDeleteFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType?), TypeInfoPropertyName = "NullableBetaApplyPatchCreateFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum?), TypeInfoPropertyName = "NullableBetaFunctionShellCallOutputStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Outcome2?), TypeInfoPropertyName = "NullableOutcome22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallOutputContentOutcomeDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallOutputExitOutcomeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallOutputTimeoutOutcomeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus?), TypeInfoPropertyName = "NullableBetaFunctionShellCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableBetaFunctionShellCallEnvironmentVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType?), TypeInfoPropertyName = "NullableBetaContainerReferenceResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType?), TypeInfoPropertyName = "NullableBetaLocalEnvironmentResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactionBodyType?), TypeInfoPropertyName = "NullableBetaCompactionBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramOutputType?), TypeInfoPropertyName = "NullableBetaProgramOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus?), TypeInfoPropertyName = "NullableBetaProgramOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaProgramType?), TypeInfoPropertyName = "NullableBetaProgramType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType?), TypeInfoPropertyName = "NullableBetaResponseConfigurationUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType?), TypeInfoPropertyName = "NullableBetaAdditionalToolsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessageRole?), TypeInfoPropertyName = "NullableBetaMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType?), TypeInfoPropertyName = "NullableBetaToolSearchOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaToolSearchCallType?), TypeInfoPropertyName = "NullableBetaToolSearchCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType?), TypeInfoPropertyName = "NullableBetaMultiAgentCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentAction?), TypeInfoPropertyName = "NullableBetaMultiAgentAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType?), TypeInfoPropertyName = "NullableBetaMultiAgentCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessageType?), TypeInfoPropertyName = "NullableBetaAgentMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem7?), TypeInfoPropertyName = "NullableContentItem72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType?), TypeInfoPropertyName = "NullableBetaAgentMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaEncryptedContentType?), TypeInfoPropertyName = "NullableBetaEncryptedContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType?), TypeInfoPropertyName = "NullableBetaComputerScreenshotContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaTextContentType?), TypeInfoPropertyName = "NullableBetaTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType?), TypeInfoPropertyName = "NullableBetaFunctionToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus?), TypeInfoPropertyName = "NullableBetaFunctionToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus?), TypeInfoPropertyName = "NullableBetaComputerCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType?), TypeInfoPropertyName = "NullableBetaComputerToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus?), TypeInfoPropertyName = "NullableBetaComputerToolCallOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactResourceObject?), TypeInfoPropertyName = "NullableBetaCompactResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemField?), TypeInfoPropertyName = "NullableBetaItemField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaItemFieldDiscriminatorType?), TypeInfoPropertyName = "NullableBetaItemFieldDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessageType?), TypeInfoPropertyName = "NullableBetaMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessageStatus?), TypeInfoPropertyName = "NullableBetaMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContentItem8?), TypeInfoPropertyName = "NullableContentItem82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessageContentItemDiscriminatorType?), TypeInfoPropertyName = "NullableBetaMessageContentItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaMessagePhase2?), TypeInfoPropertyName = "NullableBetaMessagePhase22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseCustomToolCallInputDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType?), TypeInfoPropertyName = "NullableBetaResponseCustomToolCallInputDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType?), TypeInfoPropertyName = "NullableBetaResponseQueuedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponse?), TypeInfoPropertyName = "NullableBetaResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum?), TypeInfoPropertyName = "NullableBetaServiceTierResponsesEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation?), TypeInfoPropertyName = "NullableBetaResponseVariant3Truncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object?), TypeInfoPropertyName = "NullableBetaResponseVariant3Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status?), TypeInfoPropertyName = "NullableBetaResponseVariant3Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason?), TypeInfoPropertyName = "NullableBetaResponseVariant3IncompleteDetailsReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputItem?), TypeInfoPropertyName = "NullableBetaOutputItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnostics?), TypeInfoPropertyName = "NullableBetaPromptCacheDiagnostics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Input5?), TypeInfoPropertyName = "NullableInput52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType?), TypeInfoPropertyName = "NullableBetaModerationInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Output9?), TypeInfoPropertyName = "NullableOutput92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType?), TypeInfoPropertyName = "NullableBetaModerationOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType?), TypeInfoPropertyName = "NullableBetaModerationErrorBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType?), TypeInfoPropertyName = "NullableBetaModerationResultBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationInputType?), TypeInfoPropertyName = "NullableBetaModerationInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType?), TypeInfoPropertyName = "NullableBetaPromptCacheDiagnosticsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType?), TypeInfoPropertyName = "NullableBetaPromptCacheUnavailableDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType?), TypeInfoPropertyName = "NullableBetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType?), TypeInfoPropertyName = "NullableBetaPromptCacheHitDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType?), TypeInfoPropertyName = "NullableBetaPromptCacheMissDiagnosticsBodyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum?), TypeInfoPropertyName = "NullableBetaCacheMissReasonTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType?), TypeInfoPropertyName = "NullableBetaOutputItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseErrorCode?), TypeInfoPropertyName = "NullableBetaResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum?), TypeInfoPropertyName = "NullableBetaCyberAccessProgramEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.BetaInputTextContent, global::tryAGI.OpenAI.BetaInputImageContent, global::tryAGI.OpenAI.BetaInputFileContent>?), TypeInfoPropertyName = "NullableOneOfStringBetaInputTextContentBetaInputImageContentBetaInputFileContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention?), TypeInfoPropertyName = "NullableBetaModelResponsePropertiesPromptCacheRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType?), TypeInfoPropertyName = "NullableBetaResponseOutputTextAnnotationAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType?), TypeInfoPropertyName = "NullableBetaResponseMCPListToolsInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType?), TypeInfoPropertyName = "NullableBetaResponseMCPListToolsFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType?), TypeInfoPropertyName = "NullableBetaResponseMCPListToolsCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType?), TypeInfoPropertyName = "NullableBetaResponseMCPCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType?), TypeInfoPropertyName = "NullableBetaResponseMCPCallFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType?), TypeInfoPropertyName = "NullableBetaResponseMCPCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseMCPCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType?), TypeInfoPropertyName = "NullableBetaResponseMCPCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType?), TypeInfoPropertyName = "NullableBetaResponseImageGenCallPartialImageEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType?), TypeInfoPropertyName = "NullableBetaResponseImageGenCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType?), TypeInfoPropertyName = "NullableBetaResponseImageGenCallGeneratingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType?), TypeInfoPropertyName = "NullableBetaResponseImageGenCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseReasoningTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType?), TypeInfoPropertyName = "NullableBetaResponseReasoningTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseReasoningSummaryTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType?), TypeInfoPropertyName = "NullableBetaResponseReasoningSummaryTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseReasoningSummaryPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus?), TypeInfoPropertyName = "NullableBetaResponseReasoningSummaryPartDoneEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType?), TypeInfoPropertyName = "NullableBetaResponseReasoningSummaryPartDoneEventPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType?), TypeInfoPropertyName = "NullableBetaResponseReasoningSummaryPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType?), TypeInfoPropertyName = "NullableBetaResponseReasoningSummaryPartAddedEventPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType?), TypeInfoPropertyName = "NullableBetaResponseTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseRefusalDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType?), TypeInfoPropertyName = "NullableBetaResponseRefusalDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseOutputItemDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType?), TypeInfoPropertyName = "NullableBetaResponseOutputItemAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType?), TypeInfoPropertyName = "NullableBetaResponseInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType?), TypeInfoPropertyName = "NullableBetaResponseShellCallOutputContentDoneStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType?), TypeInfoPropertyName = "NullableBetaResponseShellCallOutputContentDeltaStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType?), TypeInfoPropertyName = "NullableBetaResponseShellCallCommandDoneStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType?), TypeInfoPropertyName = "NullableBetaResponseShellCallCommandDeltaStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType?), TypeInfoPropertyName = "NullableBetaResponseShellCallCommandAddedStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseFunctionCallArgumentsDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType?), TypeInfoPropertyName = "NullableBetaResponseFunctionCallArgumentsDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType?), TypeInfoPropertyName = "NullableBetaResponseFileSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType?), TypeInfoPropertyName = "NullableBetaResponseFileSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType?), TypeInfoPropertyName = "NullableBetaResponseFileSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseErrorEventType?), TypeInfoPropertyName = "NullableBetaResponseErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType?), TypeInfoPropertyName = "NullableBetaResponseCreatedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseContentPartDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputContent?), TypeInfoPropertyName = "NullableBetaOutputContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType?), TypeInfoPropertyName = "NullableBetaOutputContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType?), TypeInfoPropertyName = "NullableBetaResponseContentPartAddedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType?), TypeInfoPropertyName = "NullableBetaResponseCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType?), TypeInfoPropertyName = "NullableBetaResponseCompactionCompactingStreamingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType?), TypeInfoPropertyName = "NullableBetaResponseCodeInterpreterCallInterpretingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType?), TypeInfoPropertyName = "NullableBetaResponseCodeInterpreterCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType?), TypeInfoPropertyName = "NullableBetaResponseCodeInterpreterCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseCodeInterpreterCallCodeDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType?), TypeInfoPropertyName = "NullableBetaResponseCodeInterpreterCallCodeDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseAudioTranscriptDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType?), TypeInfoPropertyName = "NullableBetaResponseAudioTranscriptDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType?), TypeInfoPropertyName = "NullableBetaResponseAudioDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType?), TypeInfoPropertyName = "NullableBetaResponseAudioDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType?), TypeInfoPropertyName = "NullableBetaResponseIncompleteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType?), TypeInfoPropertyName = "NullableBetaResponseFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType?), TypeInfoPropertyName = "NullableBetaResponseWebSearchCallCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType?), TypeInfoPropertyName = "NullableBetaResponseWebSearchCallSearchingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType?), TypeInfoPropertyName = "NullableBetaResponseWebSearchCallInProgressEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaInputParam?), TypeInfoPropertyName = "NullableBetaInputParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaIncludeEnum?), TypeInfoPropertyName = "NullableBetaIncludeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCreateResponse?), TypeInfoPropertyName = "NullableBetaCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCreateModelResponseProperties?), TypeInfoPropertyName = "NullableBetaCreateModelResponseProperties2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation?), TypeInfoPropertyName = "NullableBetaCreateResponseVariant3Truncation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaModerationMode?), TypeInfoPropertyName = "NullableBetaModerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseStreamEvent?), TypeInfoPropertyName = "NullableBetaResponseStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableBetaResponseStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListInputItemsOrder?), TypeInfoPropertyName = "NullableListInputItemsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem?), TypeInfoPropertyName = "NullableBetaCreateResponseOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem?), TypeInfoPropertyName = "NullableBetaGetResponseOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem?), TypeInfoPropertyName = "NullableBetaDeleteResponseOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem?), TypeInfoPropertyName = "NullableBetaCancelResponseOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem?), TypeInfoPropertyName = "NullableBetaCompactconversationOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaListInputItemsOrder?), TypeInfoPropertyName = "NullableBetaListInputItemsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem?), TypeInfoPropertyName = "NullableBetaListInputItemsOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem?), TypeInfoPropertyName = "NullableBetaGetinputtokencountsOpenaiBetaItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CallableToolAllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ComputerAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.IncludeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContextManagementParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FileSearchToolCallResultsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.MCPListToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.MCPToolFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputMessageContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SummaryTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ReasoningTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.InputItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProbTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ResponseLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebSearchActionSearchSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ModerationInputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContainerNetworkPolicyDomainSecretParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.TopLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CoordParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.LocalSkillParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem13>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SearchContentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FunctionShellCallOutputContentParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ItemField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCallableToolAllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSearchContentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ToolsItem16>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLocalSkillParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.SkillsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDomainSecretParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.List<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>))]
    internal sealed partial class ResponsesSourceGenerationContextChunk4 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaMCPListToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaSummaryTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaReasoningTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContentParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.AnnotationsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaWebSearchActionSearchSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerCallSafetyCheckParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaComputerAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCoordParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputMessageContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaTopLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaInputContent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaItemResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaFunctionShellCallOutputContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem7>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaItemField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ContentItem8>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaModerationInputType>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaModerationInputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProb>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaResponseLogProbTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaIncludeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaContextManagementParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>))]
    internal sealed partial class ResponsesSourceGenerationContextChunk5 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ResponsesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ResponsesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputsVariant1ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FiltersItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ComputerActionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ConversationParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateModelResponsePropertiesJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CreateResponseJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CustomToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.CustomToolCallResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionAndCustomToolCallOutputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputMessageResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ItemResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MCPToolCallErrorJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ModelIdsCompactionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ModelIdsResponsesJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputMessageContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponseJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ResponseStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.TextResponseFormatConfigurationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolChoiceParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallActionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnnotationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ContentItem3JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Filters2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy3JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SkillsItem2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant1JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Format2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem13JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant12JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutcomeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OperationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputVariant2ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant13JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputOutcomeParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ApplyPatchOperationParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PromptCacheDiagnosticsJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Input4JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Output5JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.PersonalityEnumJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ItemFieldJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaConversationParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaPersonalityEnumJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaReasoningModeEnumJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaTextResponseFormatConfigurationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaToolJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolsItem16JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Format3JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant14JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy4JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.SkillsItem3JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.NetworkPolicy5JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaFiltersJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FiltersItem2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaInputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaFunctionAndCustomToolCallOutputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallErrorJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchOperationParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputOutcomeParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant15JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputsVariant1Item2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnnotationsItem4JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ContentItem6JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputVariant2Item2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallActionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaComputerActionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaAnnotationJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaInputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsCompactionJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsResponsesJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsSharedJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaMisalignmentErrorTypeJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaItemResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolCallResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Operation2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Outcome2JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.EnvironmentVariant16JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ContentItem7JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaItemFieldJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ContentItem8JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaResponseJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Input5JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.Output9JsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheDiagnosticsJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaOutputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaOutputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaInputParamJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaCreateResponseJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaCreateModelResponsePropertiesJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.BetaResponseStreamEventJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputContent>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.MCPToolFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.Error, string>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ToolChoiceOptions?, global::tryAGI.OpenAI.ToolChoiceFunction, global::tryAGI.OpenAI.ToolChoiceMCP>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.ResponseAudioDeltaEvent, global::tryAGI.OpenAI.ResponseAudioDoneEvent, global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.ResponseCompletedEvent, global::tryAGI.OpenAI.ResponseContentPartAddedEvent, global::tryAGI.OpenAI.ResponseContentPartDoneEvent, global::tryAGI.OpenAI.ResponseCreatedEvent, global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.ResponseInProgressEvent, global::tryAGI.OpenAI.ResponseFailedEvent, global::tryAGI.OpenAI.ResponseIncompleteEvent, global::tryAGI.OpenAI.ResponseOutputItemAddedEvent, global::tryAGI.OpenAI.ResponseOutputItemDoneEvent, global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.ResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.ResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.ResponseRefusalDeltaEvent, global::tryAGI.OpenAI.ResponseRefusalDoneEvent, global::tryAGI.OpenAI.ResponseTextDeltaEvent, global::tryAGI.OpenAI.ResponseTextDoneEvent, global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.ResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.ResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.ResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.ResponseMCPCallFailedEvent, global::tryAGI.OpenAI.ResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.ResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.ResponseQueuedEvent, global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEvent>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.ComparisonFilter, global::tryAGI.OpenAI.CompoundFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, int?, bool?, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.BetaImageGenToolModel?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.BetaImageGenToolSize?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParam>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::tryAGI.OpenAI.BetaMCPToolFilter>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum, global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item2>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputContent>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutput>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.BetaInputTextContent, global::tryAGI.OpenAI.BetaInputImageContent, global::tryAGI.OpenAI.BetaInputFileContent>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.BetaResponseAudioDeltaEvent, global::tryAGI.OpenAI.BetaResponseAudioDoneEvent, global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEvent, global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEvent, global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEvent, global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEvent, global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEvent, global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEvent, global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEvent, global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEvent, global::tryAGI.OpenAI.BetaResponseCompletedEvent, global::tryAGI.OpenAI.BetaResponseContentPartAddedEvent, global::tryAGI.OpenAI.BetaResponseContentPartDoneEvent, global::tryAGI.OpenAI.BetaResponseCreatedEvent, global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEvent, global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEvent, global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEvent, global::tryAGI.OpenAI.BetaResponseInProgressEvent, global::tryAGI.OpenAI.BetaResponseFailedEvent, global::tryAGI.OpenAI.BetaResponseIncompleteEvent, global::tryAGI.OpenAI.BetaResponseOutputItemAddedEvent, global::tryAGI.OpenAI.BetaResponseOutputItemDoneEvent, global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEvent, global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEvent, global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEvent, global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEvent, global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEvent, global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEvent, global::tryAGI.OpenAI.BetaResponseRefusalDeltaEvent, global::tryAGI.OpenAI.BetaResponseRefusalDoneEvent, global::tryAGI.OpenAI.BetaResponseTextDeltaEvent, global::tryAGI.OpenAI.BetaResponseTextDoneEvent, global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEvent, global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEvent, global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEvent, global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEvent, global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEvent, global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEvent, global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEvent, global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEvent, global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEvent, global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEvent, global::tryAGI.OpenAI.BetaResponseMCPCallFailedEvent, global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEvent, global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEvent, global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEvent, global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEvent, global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEvent, global::tryAGI.OpenAI.BetaResponseQueuedEvent, global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEvent, global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEvent>());
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
                    typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModeration)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModeration?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalRequestType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalRequestType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPListToolsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPListToolsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Object)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Object?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Status)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Status?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCreatedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCreatedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorCode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseItemListObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseItemListObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseQueuedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseQueuedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionFindType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionFindType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.IncludeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.IncludeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClickButtonType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClickButtonType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClickParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ClickParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DoubleClickActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DoubleClickActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DragParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DragParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.KeyPressActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.KeyPressActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MoveParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MoveParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ScreenshotParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ScreenshotParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ScrollParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ScrollParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TypeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TypeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WaitParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WaitParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RankerVersionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.RankerVersionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerEnvironment)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerEnvironment?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerMemoryLimit)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerMemoryLimit?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomTextFormatParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomTextFormatParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GrammarSyntax1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.GrammarSyntax1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApproximateLocationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApproximateLocationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SearchContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SearchContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellExecActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellExecActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPProtocolErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPProtocolErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HTTPErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.HTTPErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DetailEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DetailEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileDetailEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FileDetailEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationErrorBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationErrorBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TruncationEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersonalityEnumEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PersonalityEnumEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TokenCountsResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.TokenCountsResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheRetentionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheRetentionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemFieldDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ItemFieldDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.CompactResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTokenCountsResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTokenCountsResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPersonalityEnumEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPersonalityEnumEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTruncationEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTruncationEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaHTTPErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaHTTPErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPListToolsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPListToolsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageOutputFormat)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageOutputFormat?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageBackground)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageBackground?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDetailEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDetailEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileDetailEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileDetailEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWaitParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaWaitParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTypeParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTypeParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaScrollParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaScrollParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaScreenshotParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaScreenshotParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMoveParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMoveParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaKeyPressActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaKeyPressActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDragParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDragParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickButtonType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickButtonType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheRetentionEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheRetentionEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseItemListObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseItemListObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemResourceDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemResourceDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextContentType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextContentType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemFieldDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemFieldDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageContentItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageContentItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase2)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase2?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorCode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorCode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaIncludeEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaIncludeEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationMode?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListInputItemsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListInputItemsOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaListInputItemsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaListInputItemsOrder?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComparisonFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComparisonFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComparisonFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompoundFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompoundFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompoundFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerActionDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateResponseVariant3TruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CreateResponseVariant3Truncation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CreateResponseVariant3TruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EasyInputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EasyInputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EasyInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.EasyInputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.EasyInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FilePathTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FilePathType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FilePathTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionAndCustomToolCallOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionAndCustomToolCallOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModeration))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolModerationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolModeration?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolModerationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputMessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalRequestType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalRequestType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPApprovalResponseResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPApprovalResponseResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPListToolsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPListToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPListToolsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPListToolsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolConnectorIdJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolConnectorId?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolConnectorIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolRequireApprovalVariant1Enum2JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolRequireApprovalVariant1Enum2?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolRequireApprovalVariant1Enum2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallErrorDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallErrorDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallErrorDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhaseJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsResponsesEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsResponsesEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsResponsesEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelIdsSharedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelResponsePropertiesPromptCacheRetentionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModelResponsePropertiesPromptCacheRetention?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModelResponsePropertiesPromptCacheRetentionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputMessageContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningContextJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningContext?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningContextNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningGenerateSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningGenerateSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningGenerateSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3TruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Truncation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3TruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Object))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3ObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Object?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3ObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Status))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3Status?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3IncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseVariant3IncompleteDetailsReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseVariant3IncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseAudioTranscriptDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseConfigurationUpdateItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseContentPartAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseContentPartAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseContentPartDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseContentPartDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCreatedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCreatedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCreatedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCreatedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCustomToolCallInputDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCustomToolCallInputDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseErrorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseErrorEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseErrorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFileSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatJsonObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFormatTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallGeneratingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallGeneratingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallGeneratingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallPartialImageEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseImageGenCallPartialImageEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseImageGenCallPartialImageEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseIncompleteEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseIncompleteEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseIncompleteEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseItemListObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseItemListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseItemListObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseItemListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallArgumentsDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallArgumentsDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseMCPListToolsInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseMCPListToolsInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputItemDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextAnnotationAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseOutputTextAnnotationAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseOutputTextAnnotationAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseQueuedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseQueuedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseQueuedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseQueuedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEventPartType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartAddedEventPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEventPartType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryPartDoneEventPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningSummaryTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseReasoningTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseReasoningTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseRefusalDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseStreamEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseStreamEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseWebSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierResponsesEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierResponsesEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierResponsesEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextResponseFormatJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceAllowedMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceAllowedModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceCustomTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceCustomType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceCustomTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceMCPTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceMCPType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceMCPTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceOptions?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceOptionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceTypesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolChoiceTypesType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolChoiceTypesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.VerbosityEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.VerbosityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionFindType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionFindTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionFindType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionFindTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionOpenPageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionOpenPageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionOpenPageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchActionSearchSourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchActionSearchSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchApproximateLocationWebSearchApproximateLocation1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchApproximateLocationWebSearchApproximateLocation1Type?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchApproximateLocationWebSearchApproximateLocation1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolSearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchToolCallActionDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchToolCallActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MisalignmentErrorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationResultBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationResultBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationResultBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheTTLEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheTTLEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheTTLEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheModeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SkillReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SkillReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SkillReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillSourceParamMediaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillSourceParamMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InlineSkillParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InlineSkillParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyDisabledParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyDisabledParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyAllowlistParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerNetworkPolicyAllowlistParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.IncludeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.IncludeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.IncludeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.IncludeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointConfigModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointConfigMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointConfigModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UrlCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.UrlCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.UrlCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerFileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerFileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerFileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnnotationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AnnotationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AnnotationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.OutputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.OutputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SummaryTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SummaryTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SummaryTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RefusalContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RefusalContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RefusalContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerScreenshotContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerScreenshotContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileInputDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileInputDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileInputDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase2))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhase2JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessagePhase2?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessagePhase2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MessageContentItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MessageContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DirectToolCallCallerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DirectToolCallCallerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramToolCallCallerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramToolCallCallerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DirectToolCallCallerParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DirectToolCallCallerParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DirectToolCallCallerParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramToolCallCallerParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramToolCallCallerParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramToolCallCallerParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolCallCallerParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolCallCallerParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenActionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallSizeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallSizeVariant1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallSizeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ImageGenToolCallQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ImageGenToolCallQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClickButtonType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClickButtonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClickButtonType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClickButtonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClickParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClickParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ClickParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ClickParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DoubleClickActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DoubleClickActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DoubleClickActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DoubleClickActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DragParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DragParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DragParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DragParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.KeyPressActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.KeyPressActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.KeyPressActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.KeyPressActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MoveParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MoveParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MoveParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MoveParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ScreenshotParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ScreenshotParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ScreenshotParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ScreenshotParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ScrollParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ScrollParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ScrollParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ScrollParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TypeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TypeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TypeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TypeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WaitParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WaitParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WaitParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WaitParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchExecutionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchExecutionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CallableToolAllowedCallerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CallableToolAllowedCallerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RankerVersionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RankerVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.RankerVersionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.RankerVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileSearchToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerEnvironment))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerEnvironment?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUsePreviewToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerUsePreviewToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerUsePreviewToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerMemoryLimit))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerMemoryLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerMemoryLimit?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerMemoryLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AutoCodeInterpreterToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AutoCodeInterpreterToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFidelityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFidelity?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFidelityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamNetworkPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamNetworkPolicyDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamNetworkPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamSkillDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerAutoParamSkillDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamSkillDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellToolParamEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellToolParamEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellToolParamEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomTextFormatParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomTextFormatParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomTextFormatParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomTextFormatParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GrammarSyntax1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GrammarSyntax1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.GrammarSyntax1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.GrammarSyntax1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomGrammarFormatParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomGrammarFormatParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomGrammarFormatParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolParamFormatDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CustomToolParamFormatDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CustomToolParamFormatDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NamespaceToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NamespaceToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NamespaceToolParamToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.NamespaceToolParamToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.NamespaceToolParamToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApproximateLocationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApproximateLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApproximateLocationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApproximateLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SearchContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SearchContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SearchContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SearchContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchPreviewToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.WebSearchPreviewToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.WebSearchPreviewToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputLogsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputLogsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputLogsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CodeInterpreterOutputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CodeInterpreterOutputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellExecActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellExecActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalShellExecActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalShellExecActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.LocalEnvironmentResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.LocalEnvironmentResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerReferenceResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ContainerReferenceResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ContainerReferenceResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputStatusEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputContentOutcomeDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputContentOutcomeDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOperationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOperationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOperationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPProtocolErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPProtocolErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPProtocolErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPProtocolErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolExecutionErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolExecutionErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolExecutionErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HTTPErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HTTPErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.HTTPErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.HTTPErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.MCPToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.MCPToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DetailEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DetailEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DetailEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DetailEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ComputerCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ComputerCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputTextContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputTextContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentParamAutoParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputImageContentParamAutoParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputImageContentParamAutoParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileDetailEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileDetailEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FileDetailEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FileDetailEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.InputFileContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.InputFileContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionCallOutputItemParamOutputVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolSearchOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolSearchOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsItemParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.AdditionalToolsItemParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.AdditionalToolsItemParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionSummaryItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionSummaryItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionSummaryItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallItemParamEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputTimeoutOutcomeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputTimeoutOutcomeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputExitOutcomeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputExitOutcomeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputOutcomeParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputOutcomeParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputOutcomeParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.FunctionShellCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.FunctionShellCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallStatusParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallStatusParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCreateFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchDeleteFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchUpdateFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchOperationParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchOperationParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchOperationParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchCallOutputStatusParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchCallOutputStatusParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ApplyPatchToolCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ApplyPatchToolCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionTriggerItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactionTriggerItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactionTriggerItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ProgramOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ProgramOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificApplyPatchParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificApplyPatchParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificApplyPatchParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificFunctionShellParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.SpecificFunctionShellParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.SpecificFunctionShellParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CyberAccessProgramEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CyberAccessProgramEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CyberAccessProgramEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningModeEnumEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ReasoningModeEnumEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CacheMissReasonTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CacheMissReasonTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CacheMissReasonTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheMissDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheMissDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheHitDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheHitDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheUnavailableDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheUnavailableDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheDiagnosticsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheDiagnosticsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationErrorBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationErrorBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationErrorBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationErrorBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationInputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ModerationOutputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ModerationOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCompactionCompactingStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseCompactionCompactingStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseCompactionCompactingStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandAddedStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandAddedStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandAddedStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandDeltaStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDeltaStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandDeltaStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandDoneStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallCommandDoneStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallCommandDoneStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallOutputContentDeltaStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDeltaStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallOutputContentDeltaStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallOutputContentDoneStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ResponseShellCallOutputContentDoneStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ResponseShellCallOutputContentDoneStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TruncationEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TruncationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersonalityEnumEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersonalityEnumEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PersonalityEnumEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PersonalityEnumEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TokenCountsResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TokenCountsResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.TokenCountsResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.TokenCountsResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheRetentionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheRetentionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheRetentionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheRetentionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum2))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierEnum2JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ServiceTierEnum2?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ServiceTierEnum2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemFieldDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemFieldDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ItemFieldDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ItemFieldDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.CompactResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.CompactResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTokenCountsResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTokenCountsResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTokenCountsResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTokenCountsResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificFunctionShellParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificFunctionShellParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificFunctionShellParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificApplyPatchParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificApplyPatchParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificApplyPatchParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSpecificProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSpecificProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceCustomTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceCustomType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceCustomTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceMCPTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceMCPType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceMCPTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceFunctionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceFunctionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceFunctionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceTypesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceTypesType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceTypesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceAllowedMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceAllowedModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolChoiceOptions?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolChoiceOptionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPersonalityEnumEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPersonalityEnumEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPersonalityEnumEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPersonalityEnumEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTruncationEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTruncationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTruncationEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTruncationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningContextJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningContext?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningContextNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningGenerateSummaryJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningGenerateSummary?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningGenerateSummaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningEffortEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningEffortEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningEffortEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningModeEnumEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningModeEnumEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningModeEnumEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaVerbosityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaVerbosityEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaVerbosityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatJsonObjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObjectType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatJsonObjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTextResponseFormatJsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchemaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTextResponseFormatJsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatTextTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFormatTextType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFormatTextTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCallableToolAllowedCallerJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCallableToolAllowedCaller?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCallableToolAllowedCallerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchPreviewToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchPreviewToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchPreviewToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApproximateLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApproximateLocationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApproximateLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchExecutionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchExecutionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchExecutionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaNamespaceToolParamToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaNamespaceToolParamToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamFormatDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolParamFormatDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolParamFormatDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomGrammarFormatParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomGrammarFormatParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomGrammarFormatParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaGrammarSyntax1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaGrammarSyntax1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaGrammarSyntax1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomTextFormatParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomTextFormatParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomTextFormatParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellToolParamEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalEnvironmentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalEnvironmentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamNetworkPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamNetworkPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamSkillDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerAutoParamSkillDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerAutoParamSkillDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInlineSkillSourceParamMediaType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInlineSkillSourceParamMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSkillReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSkillReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSkillReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyAllowlistParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyAllowlistParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyDisabledParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerNetworkPolicyDisabledParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerMemoryLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerMemoryLimit?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerMemoryLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModelJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModel?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModerationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolModeration?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolModerationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenActionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenActionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenActionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFidelityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFidelity?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFidelityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgrammaticToolCallingParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgrammaticToolCallingParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgrammaticToolCallingParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamNetworkPolicyDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolConnectorIdJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolConnectorId?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolConnectorIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolRequireApprovalVariant1Enum2JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolRequireApprovalVariant1Enum2?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolRequireApprovalVariant1Enum2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolSearchContextSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolSearchContextSize?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolSearchContextSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchApproximateLocationWebSearchApproximateLocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchApproximateLocationWebSearchApproximateLocationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchApproximateLocationWebSearchApproximateLocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerUsePreviewToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerUsePreviewToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerUsePreviewToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerEnvironment?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompoundFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompoundFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompoundFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComparisonFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComparisonFilterType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComparisonFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRankerVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRankerVersionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRankerVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemReferenceParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemReferenceParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemReferenceParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionTriggerItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionTriggerItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionTriggerItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramToolCallCallerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramToolCallCallerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDirectToolCallCallerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDirectToolCallCallerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCustomToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCustomToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionAndCustomToolCallOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionAndCustomToolCallOutputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionAndCustomToolCallOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFileContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFileContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileInputDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileInputDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileInputDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheBreakpointConfigModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfigMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheBreakpointConfigModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputImageContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputImageContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageDetail?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolCallCallerParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolCallCallerParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramToolCallCallerParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramToolCallCallerParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramToolCallCallerParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDirectToolCallCallerParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDirectToolCallCallerParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDirectToolCallCallerParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallErrorDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolCallErrorDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaHTTPErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaHTTPErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaHTTPErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaHTTPErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolExecutionErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPToolExecutionErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPProtocolErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPProtocolErrorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPProtocolErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalRequestType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPListToolsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPListToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPListToolsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPListToolsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallOutputStatusParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatusParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallOutputStatusParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchOperationParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchOperationParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchUpdateFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchUpdateFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchDeleteFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchDeleteFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCreateFileOperationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCreateFileOperationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallStatusParamJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatusParam?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallStatusParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputOutcomeParamDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputOutcomeParamDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputOutcomeParamDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputExitOutcomeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputExitOutcomeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTimeoutOutcomeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTimeoutOutcomeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallItemParamEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellExecActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalShellExecActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalShellExecActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterOutputImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterOutputImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterOutputLogsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCodeInterpreterOutputLogsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCodeInterpreterOutputLogsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallSizeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallSizeVariant1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallSizeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageGenToolCallQuality?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageGenToolCallQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageOutputFormat))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageOutputFormat?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageBackground))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaImageBackground?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaImageBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionSummaryItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionSummaryItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionSummaryItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaReasoningTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaReasoningTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSummaryTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaSummaryTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaSummaryTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseConfigurationUpdateItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseConfigurationUpdateItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsItemParamRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsItemParamRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsItemParamRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallItemStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentParamAnnotationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentParamAnnotationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentParamAnnotationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerFileCitationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerFileCitationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUrlCitationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUrlCitationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileCitationParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileCitationParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentAction1JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction1?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentAction1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageItemParamContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageItemParamContentItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageItemParamContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEncryptedContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEncryptedContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputImageContentParamAutoParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputImageContentParamAutoParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputImageContentParamAutoParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheBreakpointParamModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheBreakpointParamMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheBreakpointParamModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDetailEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDetailEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDetailEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDetailEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputTextContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputTextContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputItemParamOutputVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFileContentParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputFileContentParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputFileContentParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileDetailEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileDetailEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileDetailEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileDetailEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchToolCallActionDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchToolCallActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionFindTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionFindType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionFindTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionOpenPageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionOpenPageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionOpenPageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionSearchTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionSearchTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionSearchSourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchActionSearchSourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchActionSearchSourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWebSearchCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWebSearchCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerCallOutputItemParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputItemParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerCallOutputItemParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerScreenshotImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotImageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerScreenshotImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerActionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerActionDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerActionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWaitParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWaitParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaWaitParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaWaitParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTypeParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTypeParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTypeParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTypeParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaScrollParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaScrollParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaScrollParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaScrollParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaScreenshotParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaScreenshotParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaScreenshotParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaScreenshotParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMoveParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMoveParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMoveParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMoveParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaKeyPressActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaKeyPressActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaKeyPressActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaKeyPressActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDragParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDragParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDragParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDragParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDoubleClickActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDoubleClickActionType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDoubleClickActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickParamType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaClickParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickParamType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaClickParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickButtonType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaClickButtonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaClickButtonType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaClickButtonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileSearchToolCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessagePhaseJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessagePhaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputMessageContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputMessageContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRefusalContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaRefusalContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaRefusalContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAnnotationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAnnotationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAnnotationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFilePathTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFilePathType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFilePathTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerFileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerFileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerFileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUrlCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaUrlCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaUrlCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileCitationBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFileCitationBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFileCitationBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputMessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaInputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaInputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEasyInputMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEasyInputMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEasyInputMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEasyInputMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEasyInputMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaServiceTierEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaServiceTierEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheModeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheModeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheModeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheTTLEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheTTLEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheTTLEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheRetentionEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheRetentionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheRetentionEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheRetentionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsResponsesEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsResponsesEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsResponsesEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsSharedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelIdsSharedEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelIdsSharedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMisalignmentErrorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMisalignmentErrorTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMisalignmentErrorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseItemListObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseItemListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseItemListObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseItemListObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemResourceDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemResourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemResourceDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemResourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallOutputStatusEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallOutputStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalResponseResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMCPApprovalResponseResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMCPApprovalResponseResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOperationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchToolCallOperationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchUpdateFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchUpdateFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchDeleteFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchDeleteFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCreateFileOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCreateFileOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaApplyPatchCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaApplyPatchCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputContentOutcomeDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputContentOutcomeDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputContentOutcomeDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputExitOutcomeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputExitOutcomeType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputExitOutcomeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTimeoutOutcomeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputTimeoutOutcomeType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputTimeoutOutcomeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallOutputStatusEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallOutputStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallEnvironmentVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallEnvironmentVariant1DiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallEnvironmentVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerReferenceResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaContainerReferenceResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaContainerReferenceResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalEnvironmentResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaLocalEnvironmentResourceType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaLocalEnvironmentResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionShellCallStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionShellCallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactionBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactionBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaProgramType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaProgramTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseConfigurationUpdateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseConfigurationUpdateType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseConfigurationUpdateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAdditionalToolsType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAdditionalToolsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageRole))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageRole?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaToolSearchCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaToolSearchCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentActionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentAction?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMultiAgentCallType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMultiAgentCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaAgentMessageContentItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaAgentMessageContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEncryptedContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaEncryptedContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaEncryptedContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerScreenshotContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerScreenshotContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerScreenshotContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextContentType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaTextContentType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaTextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaFunctionToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaFunctionToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaComputerToolCallOutputStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaComputerToolCallOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemFieldDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemFieldDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaItemFieldDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaItemFieldDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageContentItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessageContentItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageContentItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessageContentItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase2))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessagePhase2JsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessagePhase2?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessagePhase2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaMessageStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCustomToolCallInputDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCustomToolCallInputDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCustomToolCallInputDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCustomToolCallInputDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCustomToolCallInputDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseQueuedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseQueuedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseQueuedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3TruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Truncation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3TruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3ObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Object?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3ObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3Status?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3IncompleteDetailsReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseVariant3IncompleteDetailsReason?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseVariant3IncompleteDetailsReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationOutputDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationErrorBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationErrorBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationErrorBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationResultBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationResultBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationResultBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationInputType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheDiagnosticsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheDiagnosticsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheUnavailableDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheUnavailableDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheHitDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheHitDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheMissDiagnosticsBodyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBodyType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheMissDiagnosticsBodyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCacheMissReasonTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCacheMissReasonTypeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCacheMissReasonTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorCode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorCode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCyberAccessProgramEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCyberAccessProgramEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCyberAccessProgramEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaServiceTierResponsesEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaServiceTierResponsesEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaServiceTierResponsesEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelResponsePropertiesPromptCacheRetentionJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModelResponsePropertiesPromptCacheRetention?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModelResponsePropertiesPromptCacheRetentionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputTextAnnotationAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputTextAnnotationAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputTextAnnotationAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPListToolsCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPListToolsCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallArgumentsDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallArgumentsDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallArgumentsDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseMCPCallArgumentsDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseMCPCallArgumentsDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallPartialImageEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallPartialImageEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallPartialImageEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallGeneratingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallGeneratingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallGeneratingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseImageGenCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseImageGenCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventStatus?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartDoneEventPartType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartDoneEventPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartAddedEventPartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseReasoningSummaryPartAddedEventPartType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseReasoningSummaryPartAddedEventPartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseTextDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseTextDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseTextDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseTextDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseTextDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseRefusalDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseRefusalDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseRefusalDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseRefusalDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseRefusalDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputItemDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputItemDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputItemAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseOutputItemAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseOutputItemAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallOutputContentDoneStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDoneStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallOutputContentDoneStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallOutputContentDeltaStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallOutputContentDeltaStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallOutputContentDeltaStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandDoneStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDoneStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandDoneStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandDeltaStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandDeltaStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandDeltaStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandAddedStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseShellCallCommandAddedStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseShellCallCommandAddedStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFunctionCallArgumentsDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFunctionCallArgumentsDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFunctionCallArgumentsDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFunctionCallArgumentsDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFunctionCallArgumentsDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallSearchingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFileSearchCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFileSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseErrorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseErrorEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseErrorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCreatedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCreatedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCreatedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseContentPartDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseContentPartDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputContentDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaOutputContentDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaOutputContentDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseContentPartAddedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseContentPartAddedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseContentPartAddedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCompactionCompactingStreamingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCompactionCompactingStreamingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCompactionCompactingStreamingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallInterpretingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInterpretingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallInterpretingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCodeDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseCodeInterpreterCallCodeDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseCodeInterpreterCallCodeDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioTranscriptDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioTranscriptDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioTranscriptDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioTranscriptDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioTranscriptDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioDoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDoneEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioDoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioDeltaEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseAudioDeltaEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseAudioDeltaEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseIncompleteEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseIncompleteEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseIncompleteEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseFailedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallCompletedEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallSearchingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallSearchingEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallSearchingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallInProgressEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseWebSearchCallInProgressEventType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseWebSearchCallInProgressEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaIncludeEnum))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaIncludeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaIncludeEnum?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaIncludeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCreateResponseVariant3TruncationJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseVariant3Truncation?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCreateResponseVariant3TruncationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaModerationMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaModerationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaResponseStreamEventDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaResponseStreamEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListInputItemsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListInputItemsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListInputItemsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListInputItemsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCreateResponseOpenaiBetaItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCreateResponseOpenaiBetaItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCreateResponseOpenaiBetaItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaGetResponseOpenaiBetaItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaGetResponseOpenaiBetaItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDeleteResponseOpenaiBetaItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaDeleteResponseOpenaiBetaItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaDeleteResponseOpenaiBetaItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCancelResponseOpenaiBetaItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCancelResponseOpenaiBetaItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCancelResponseOpenaiBetaItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactconversationOpenaiBetaItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaCompactconversationOpenaiBetaItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaCompactconversationOpenaiBetaItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaListInputItemsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaListInputItemsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaListInputItemsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaListInputItemsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaListInputItemsOpenaiBetaItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaListInputItemsOpenaiBetaItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaListInputItemsOpenaiBetaItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaGetinputtokencountsOpenaiBetaItemJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.BetaGetinputtokencountsOpenaiBetaItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[6];

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
                    0 => new ResponsesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new ResponsesSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new ResponsesSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new ResponsesSourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),

                    4 => new ResponsesSourceGenerationContextChunk4(new global::System.Text.Json.JsonSerializerOptions()),

                    5 => new ResponsesSourceGenerationContextChunk5(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}