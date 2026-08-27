
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseStreamEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        ResponseAudioDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseAudioDone,
        /// <summary>
        ///
        /// </summary>
        ResponseAudioTranscriptDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseAudioTranscriptDone,
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallInterpreting,
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallCodeDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallCodeDone,
        /// <summary>
        ///
        /// </summary>
        ResponseCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartDone,
        /// <summary>
        ///
        /// </summary>
        ResponseCreated,
        /// <summary>
        ///
        /// </summary>
        ResponseCustomToolCallInputDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseCustomToolCallInputDone,
        /// <summary>
        ///
        /// </summary>
        ResponseFailed,
        /// <summary>
        ///
        /// </summary>
        ResponseFileSearchCallCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseFileSearchCallInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseFileSearchCallSearching,
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDone,
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallGenerating,
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseImageGenerationCallPartialImage,
        /// <summary>
        ///
        /// </summary>
        ResponseInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseIncomplete,
        /// <summary>
        ///
        /// </summary>
        ResponseMcpCallCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseMcpCallFailed,
        /// <summary>
        ///
        /// </summary>
        ResponseMcpCallInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseMcpCallArgumentsDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseMcpCallArgumentsDone,
        /// <summary>
        ///
        /// </summary>
        ResponseMcpListToolsCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseMcpListToolsFailed,
        /// <summary>
        ///
        /// </summary>
        ResponseMcpListToolsInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputItemDone,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextAnnotationAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDone,
        /// <summary>
        ///
        /// </summary>
        ResponseQueued,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryPartAdded,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryPartDone,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryTextDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryTextDone,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningTextDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningTextDone,
        /// <summary>
        ///
        /// </summary>
        ResponseRefusalDelta,
        /// <summary>
        ///
        /// </summary>
        ResponseRefusalDone,
        /// <summary>
        ///
        /// </summary>
        ResponseWebSearchCallCompleted,
        /// <summary>
        ///
        /// </summary>
        ResponseWebSearchCallInProgress,
        /// <summary>
        ///
        /// </summary>
        ResponseWebSearchCallSearching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseStreamEventDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseStreamEventDiscriminatorType.Error => "error",
                BetaResponseStreamEventDiscriminatorType.ResponseAudioDelta => "response.audio.delta",
                BetaResponseStreamEventDiscriminatorType.ResponseAudioDone => "response.audio.done",
                BetaResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDelta => "response.audio.transcript.delta",
                BetaResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDone => "response.audio.transcript.done",
                BetaResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCompleted => "response.code_interpreter_call.completed",
                BetaResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInProgress => "response.code_interpreter_call.in_progress",
                BetaResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInterpreting => "response.code_interpreter_call.interpreting",
                BetaResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDelta => "response.code_interpreter_call_code.delta",
                BetaResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDone => "response.code_interpreter_call_code.done",
                BetaResponseStreamEventDiscriminatorType.ResponseCompleted => "response.completed",
                BetaResponseStreamEventDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                BetaResponseStreamEventDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                BetaResponseStreamEventDiscriminatorType.ResponseCreated => "response.created",
                BetaResponseStreamEventDiscriminatorType.ResponseCustomToolCallInputDelta => "response.custom_tool_call_input.delta",
                BetaResponseStreamEventDiscriminatorType.ResponseCustomToolCallInputDone => "response.custom_tool_call_input.done",
                BetaResponseStreamEventDiscriminatorType.ResponseFailed => "response.failed",
                BetaResponseStreamEventDiscriminatorType.ResponseFileSearchCallCompleted => "response.file_search_call.completed",
                BetaResponseStreamEventDiscriminatorType.ResponseFileSearchCallInProgress => "response.file_search_call.in_progress",
                BetaResponseStreamEventDiscriminatorType.ResponseFileSearchCallSearching => "response.file_search_call.searching",
                BetaResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                BetaResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                BetaResponseStreamEventDiscriminatorType.ResponseImageGenerationCallCompleted => "response.image_generation_call.completed",
                BetaResponseStreamEventDiscriminatorType.ResponseImageGenerationCallGenerating => "response.image_generation_call.generating",
                BetaResponseStreamEventDiscriminatorType.ResponseImageGenerationCallInProgress => "response.image_generation_call.in_progress",
                BetaResponseStreamEventDiscriminatorType.ResponseImageGenerationCallPartialImage => "response.image_generation_call.partial_image",
                BetaResponseStreamEventDiscriminatorType.ResponseInProgress => "response.in_progress",
                BetaResponseStreamEventDiscriminatorType.ResponseIncomplete => "response.incomplete",
                BetaResponseStreamEventDiscriminatorType.ResponseMcpCallCompleted => "response.mcp_call.completed",
                BetaResponseStreamEventDiscriminatorType.ResponseMcpCallFailed => "response.mcp_call.failed",
                BetaResponseStreamEventDiscriminatorType.ResponseMcpCallInProgress => "response.mcp_call.in_progress",
                BetaResponseStreamEventDiscriminatorType.ResponseMcpCallArgumentsDelta => "response.mcp_call_arguments.delta",
                BetaResponseStreamEventDiscriminatorType.ResponseMcpCallArgumentsDone => "response.mcp_call_arguments.done",
                BetaResponseStreamEventDiscriminatorType.ResponseMcpListToolsCompleted => "response.mcp_list_tools.completed",
                BetaResponseStreamEventDiscriminatorType.ResponseMcpListToolsFailed => "response.mcp_list_tools.failed",
                BetaResponseStreamEventDiscriminatorType.ResponseMcpListToolsInProgress => "response.mcp_list_tools.in_progress",
                BetaResponseStreamEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                BetaResponseStreamEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                BetaResponseStreamEventDiscriminatorType.ResponseOutputTextAnnotationAdded => "response.output_text.annotation.added",
                BetaResponseStreamEventDiscriminatorType.ResponseOutputTextDelta => "response.output_text.delta",
                BetaResponseStreamEventDiscriminatorType.ResponseOutputTextDone => "response.output_text.done",
                BetaResponseStreamEventDiscriminatorType.ResponseQueued => "response.queued",
                BetaResponseStreamEventDiscriminatorType.ResponseReasoningSummaryPartAdded => "response.reasoning_summary_part.added",
                BetaResponseStreamEventDiscriminatorType.ResponseReasoningSummaryPartDone => "response.reasoning_summary_part.done",
                BetaResponseStreamEventDiscriminatorType.ResponseReasoningSummaryTextDelta => "response.reasoning_summary_text.delta",
                BetaResponseStreamEventDiscriminatorType.ResponseReasoningSummaryTextDone => "response.reasoning_summary_text.done",
                BetaResponseStreamEventDiscriminatorType.ResponseReasoningTextDelta => "response.reasoning_text.delta",
                BetaResponseStreamEventDiscriminatorType.ResponseReasoningTextDone => "response.reasoning_text.done",
                BetaResponseStreamEventDiscriminatorType.ResponseRefusalDelta => "response.refusal.delta",
                BetaResponseStreamEventDiscriminatorType.ResponseRefusalDone => "response.refusal.done",
                BetaResponseStreamEventDiscriminatorType.ResponseWebSearchCallCompleted => "response.web_search_call.completed",
                BetaResponseStreamEventDiscriminatorType.ResponseWebSearchCallInProgress => "response.web_search_call.in_progress",
                BetaResponseStreamEventDiscriminatorType.ResponseWebSearchCallSearching => "response.web_search_call.searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => BetaResponseStreamEventDiscriminatorType.Error,
                "response.audio.delta" => BetaResponseStreamEventDiscriminatorType.ResponseAudioDelta,
                "response.audio.done" => BetaResponseStreamEventDiscriminatorType.ResponseAudioDone,
                "response.audio.transcript.delta" => BetaResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDelta,
                "response.audio.transcript.done" => BetaResponseStreamEventDiscriminatorType.ResponseAudioTranscriptDone,
                "response.code_interpreter_call.completed" => BetaResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCompleted,
                "response.code_interpreter_call.in_progress" => BetaResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInProgress,
                "response.code_interpreter_call.interpreting" => BetaResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallInterpreting,
                "response.code_interpreter_call_code.delta" => BetaResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDelta,
                "response.code_interpreter_call_code.done" => BetaResponseStreamEventDiscriminatorType.ResponseCodeInterpreterCallCodeDone,
                "response.completed" => BetaResponseStreamEventDiscriminatorType.ResponseCompleted,
                "response.content_part.added" => BetaResponseStreamEventDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => BetaResponseStreamEventDiscriminatorType.ResponseContentPartDone,
                "response.created" => BetaResponseStreamEventDiscriminatorType.ResponseCreated,
                "response.custom_tool_call_input.delta" => BetaResponseStreamEventDiscriminatorType.ResponseCustomToolCallInputDelta,
                "response.custom_tool_call_input.done" => BetaResponseStreamEventDiscriminatorType.ResponseCustomToolCallInputDone,
                "response.failed" => BetaResponseStreamEventDiscriminatorType.ResponseFailed,
                "response.file_search_call.completed" => BetaResponseStreamEventDiscriminatorType.ResponseFileSearchCallCompleted,
                "response.file_search_call.in_progress" => BetaResponseStreamEventDiscriminatorType.ResponseFileSearchCallInProgress,
                "response.file_search_call.searching" => BetaResponseStreamEventDiscriminatorType.ResponseFileSearchCallSearching,
                "response.function_call_arguments.delta" => BetaResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => BetaResponseStreamEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.image_generation_call.completed" => BetaResponseStreamEventDiscriminatorType.ResponseImageGenerationCallCompleted,
                "response.image_generation_call.generating" => BetaResponseStreamEventDiscriminatorType.ResponseImageGenerationCallGenerating,
                "response.image_generation_call.in_progress" => BetaResponseStreamEventDiscriminatorType.ResponseImageGenerationCallInProgress,
                "response.image_generation_call.partial_image" => BetaResponseStreamEventDiscriminatorType.ResponseImageGenerationCallPartialImage,
                "response.in_progress" => BetaResponseStreamEventDiscriminatorType.ResponseInProgress,
                "response.incomplete" => BetaResponseStreamEventDiscriminatorType.ResponseIncomplete,
                "response.mcp_call.completed" => BetaResponseStreamEventDiscriminatorType.ResponseMcpCallCompleted,
                "response.mcp_call.failed" => BetaResponseStreamEventDiscriminatorType.ResponseMcpCallFailed,
                "response.mcp_call.in_progress" => BetaResponseStreamEventDiscriminatorType.ResponseMcpCallInProgress,
                "response.mcp_call_arguments.delta" => BetaResponseStreamEventDiscriminatorType.ResponseMcpCallArgumentsDelta,
                "response.mcp_call_arguments.done" => BetaResponseStreamEventDiscriminatorType.ResponseMcpCallArgumentsDone,
                "response.mcp_list_tools.completed" => BetaResponseStreamEventDiscriminatorType.ResponseMcpListToolsCompleted,
                "response.mcp_list_tools.failed" => BetaResponseStreamEventDiscriminatorType.ResponseMcpListToolsFailed,
                "response.mcp_list_tools.in_progress" => BetaResponseStreamEventDiscriminatorType.ResponseMcpListToolsInProgress,
                "response.output_item.added" => BetaResponseStreamEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => BetaResponseStreamEventDiscriminatorType.ResponseOutputItemDone,
                "response.output_text.annotation.added" => BetaResponseStreamEventDiscriminatorType.ResponseOutputTextAnnotationAdded,
                "response.output_text.delta" => BetaResponseStreamEventDiscriminatorType.ResponseOutputTextDelta,
                "response.output_text.done" => BetaResponseStreamEventDiscriminatorType.ResponseOutputTextDone,
                "response.queued" => BetaResponseStreamEventDiscriminatorType.ResponseQueued,
                "response.reasoning_summary_part.added" => BetaResponseStreamEventDiscriminatorType.ResponseReasoningSummaryPartAdded,
                "response.reasoning_summary_part.done" => BetaResponseStreamEventDiscriminatorType.ResponseReasoningSummaryPartDone,
                "response.reasoning_summary_text.delta" => BetaResponseStreamEventDiscriminatorType.ResponseReasoningSummaryTextDelta,
                "response.reasoning_summary_text.done" => BetaResponseStreamEventDiscriminatorType.ResponseReasoningSummaryTextDone,
                "response.reasoning_text.delta" => BetaResponseStreamEventDiscriminatorType.ResponseReasoningTextDelta,
                "response.reasoning_text.done" => BetaResponseStreamEventDiscriminatorType.ResponseReasoningTextDone,
                "response.refusal.delta" => BetaResponseStreamEventDiscriminatorType.ResponseRefusalDelta,
                "response.refusal.done" => BetaResponseStreamEventDiscriminatorType.ResponseRefusalDone,
                "response.web_search_call.completed" => BetaResponseStreamEventDiscriminatorType.ResponseWebSearchCallCompleted,
                "response.web_search_call.in_progress" => BetaResponseStreamEventDiscriminatorType.ResponseWebSearchCallInProgress,
                "response.web_search_call.searching" => BetaResponseStreamEventDiscriminatorType.ResponseWebSearchCallSearching,
                _ => null,
            };
        }
    }
}