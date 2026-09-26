
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputsVariant1Item), TypeInfoPropertyName = "OutputsVariant1Item2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FiltersItem), TypeInfoPropertyName = "FiltersItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItem), TypeInfoPropertyName = "ConversationItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType), TypeInfoPropertyName = "ConversationItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItemList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItemListObject), TypeInfoPropertyName = "ConversationItemListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ConversationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortEnum), TypeInfoPropertyName = "ReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillReferenceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyDisabledParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ContainerNetworkPolicyAllowlistParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.EasyInputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Tool), TypeInfoPropertyName = "Tool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFidelity), TypeInfoPropertyName = "InputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.IncludeEnum), TypeInfoPropertyName = "IncludeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallType), TypeInfoPropertyName = "CustomToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolCallCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallOutputType), TypeInfoPropertyName = "CustomToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolCallCallerParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>), TypeInfoPropertyName = "OneOfStringIListFunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput), TypeInfoPropertyName = "FunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum), TypeInfoPropertyName = "FunctionCallOutputStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallStatus), TypeInfoPropertyName = "FunctionCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedConversationResource))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.RefusalContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageType), TypeInfoPropertyName = "OutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageRole), TypeInfoPropertyName = "OutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputMessageContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContent), TypeInfoPropertyName = "OutputMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageStatus), TypeInfoPropertyName = "OutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType), TypeInfoPropertyName = "OutputMessageContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemType), TypeInfoPropertyName = "ReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SummaryTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningTextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemStatus), TypeInfoPropertyName = "ReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType), TypeInfoPropertyName = "ResponseConfigurationUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType), TypeInfoPropertyName = "ResponseConfigurationUpdateItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Annotation))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode), TypeInfoPropertyName = "PromptCacheBreakpointParamMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.SkillReferenceParamType), TypeInfoPropertyName = "SkillReferenceParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InlineSkillSourceParam))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Outcome), TypeInfoPropertyName = "Outcome2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Operation), TypeInfoPropertyName = "Operation2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>), TypeInfoPropertyName = "OneOfStringIListOutputVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputVariant2Item), TypeInfoPropertyName = "OutputVariant2Item2")]
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
    internal sealed partial class ConversationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationResourceObject), TypeInfoPropertyName = "ConversationResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateConversationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.UpdateConversationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedConversationResourceObject), TypeInfoPropertyName = "DeletedConversationResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CreateConversationItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListConversationItemsOrder), TypeInfoPropertyName = "ListConversationItemsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolType?), TypeInfoPropertyName = "NullableCodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::tryAGI.OpenAI.AutoCodeInterpreterToolParam>?), TypeInfoPropertyName = "NullableOneOfStringAutoCodeInterpreterToolParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CallableToolAllowedCaller?), TypeInfoPropertyName = "NullableCallableToolAllowedCaller2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallType?), TypeInfoPropertyName = "NullableCodeInterpreterToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallStatus?), TypeInfoPropertyName = "NullableCodeInterpreterToolCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputsVariant1Item?), TypeInfoPropertyName = "NullableOutputsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableCodeInterpreterToolCallOutputsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ComparisonFilterType?), TypeInfoPropertyName = "NullableComparisonFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<string, double?>>>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanIListOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?>?), TypeInfoPropertyName = "NullableOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CompoundFilterType?), TypeInfoPropertyName = "NullableCompoundFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FiltersItem?), TypeInfoPropertyName = "NullableFiltersItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItem?), TypeInfoPropertyName = "NullableConversationItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallResource?), TypeInfoPropertyName = "NullableFunctionToolCallResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionToolCallOutputResource?), TypeInfoPropertyName = "NullableFunctionToolCallOutputResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType?), TypeInfoPropertyName = "NullableConversationItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationItemListObject?), TypeInfoPropertyName = "NullableConversationItemListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?), TypeInfoPropertyName = "NullableReasoningEffortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Tool?), TypeInfoPropertyName = "NullableTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.InputFidelity?), TypeInfoPropertyName = "NullableInputFidelity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.IncludeEnum?), TypeInfoPropertyName = "NullableIncludeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallType?), TypeInfoPropertyName = "NullableCustomToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.CustomToolCallOutputType?), TypeInfoPropertyName = "NullableCustomToolCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput>>?), TypeInfoPropertyName = "NullableOneOfStringIListFunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionAndCustomToolCallOutput?), TypeInfoPropertyName = "NullableFunctionAndCustomToolCallOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionCallOutputStatusEnum?), TypeInfoPropertyName = "NullableFunctionCallOutputStatusEnum2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ItemDiscriminatorType?), TypeInfoPropertyName = "NullableItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageType?), TypeInfoPropertyName = "NullableOutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageRole?), TypeInfoPropertyName = "NullableOutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContent?), TypeInfoPropertyName = "NullableOutputMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageStatus?), TypeInfoPropertyName = "NullableOutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType?), TypeInfoPropertyName = "NullableOutputMessageContentDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemType?), TypeInfoPropertyName = "NullableReasoningItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ReasoningItemStatus?), TypeInfoPropertyName = "NullableReasoningItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType?), TypeInfoPropertyName = "NullableResponseConfigurationUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType?), TypeInfoPropertyName = "NullableResponseConfigurationUpdateItemParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?), TypeInfoPropertyName = "NullableToolDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?), TypeInfoPropertyName = "NullablePromptCacheBreakpointParamMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Outcome?), TypeInfoPropertyName = "NullableOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputContentOutcomeDiscriminatorType?), TypeInfoPropertyName = "NullableFunctionShellCallOutputContentOutcomeDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.FunctionShellCallOutputType?), TypeInfoPropertyName = "NullableFunctionShellCallOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCallStatus?), TypeInfoPropertyName = "NullableApplyPatchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationType?), TypeInfoPropertyName = "NullableApplyPatchCreateFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationType?), TypeInfoPropertyName = "NullableApplyPatchDeleteFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationType?), TypeInfoPropertyName = "NullableApplyPatchUpdateFileOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ApplyPatchToolCallType?), TypeInfoPropertyName = "NullableApplyPatchToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.Operation?), TypeInfoPropertyName = "NullableOperation2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OutputVariant2Item>>?), TypeInfoPropertyName = "NullableOneOfStringIListOutputVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OutputVariant2Item?), TypeInfoPropertyName = "NullableOutputVariant2Item2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ConversationResourceObject?), TypeInfoPropertyName = "NullableConversationResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.DeletedConversationResourceObject?), TypeInfoPropertyName = "NullableDeletedConversationResourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.ListConversationItemsOrder?), TypeInfoPropertyName = "NullableListConversationItemsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.CallableToolAllowedCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OutputsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.OpenAI.OneOf<string, double?, bool?, global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.OneOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.FiltersItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ComputerAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ComputerCallSafetyCheckParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.ConversationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.IncludeEnum>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.OpenAI.WebSearchActionSearchSource>))]
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
    internal sealed partial class ConversationsSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ConversationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ConversationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ConversationItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionAndCustomToolCallOutputJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallOutputResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.FunctionToolCallResourceJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.InputItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ItemJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.MCPToolCallErrorJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OutputMessageContentJsonConverter());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.ToolJsonConverter());
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
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>());
            options.Converters.Add(new global::tryAGI.OpenAI.JsonConverters.OneOfJsonConverter<string, global::tryAGI.OpenAI.InputTextContent, global::tryAGI.OpenAI.InputImageContent, global::tryAGI.OpenAI.InputFileContent>());
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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemListObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemListObject?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageRole)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageRole?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.OutputMessageContentDiscriminatorType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningEffortEnum?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ReasoningItemStatus?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ResponseConfigurationUpdateItemParamType?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?)

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

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ConversationResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ConversationResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedConversationResourceObject)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.DeletedConversationResourceObject?)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListConversationItemsOrder)

                    || typeToConvert == typeof(global::tryAGI.OpenAI.ListConversationItemsOrder?);
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ConversationItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ConversationItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemListObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ConversationItemListObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ConversationItemListObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ConversationItemListObjectNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ToolDiscriminatorType?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ToolDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.PromptCacheBreakpointParamMode?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.PromptCacheBreakpointParamModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ConversationResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ConversationResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ConversationResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ConversationResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedConversationResourceObject))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedConversationResourceObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.DeletedConversationResourceObject?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.DeletedConversationResourceObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListConversationItemsOrder))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListConversationItemsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::tryAGI.OpenAI.ListConversationItemsOrder?))
                {
                    return new global::tryAGI.OpenAI.JsonConverters.ListConversationItemsOrderNullableJsonConverter();
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
                    0 => new ConversationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new ConversationsSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}