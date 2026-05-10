
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationCreated,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemAdded,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemCreated,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDeleted,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDone,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionCompleted,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionDelta,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionFailed,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionSegment,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemRetrieved,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemTruncated,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCleared,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCommitted,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferDtmfEventReceived,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferSpeechStarted,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferSpeechStopped,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferTimeoutTriggered,
        /// <summary>
        /// 
        /// </summary>
        McpListToolsCompleted,
        /// <summary>
        /// 
        /// </summary>
        McpListToolsFailed,
        /// <summary>
        /// 
        /// </summary>
        McpListToolsInProgress,
        /// <summary>
        /// 
        /// </summary>
        OutputAudioBufferCleared,
        /// <summary>
        /// 
        /// </summary>
        OutputAudioBufferStarted,
        /// <summary>
        /// 
        /// </summary>
        OutputAudioBufferStopped,
        /// <summary>
        /// 
        /// </summary>
        RateLimitsUpdated,
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
        ResponseDone,
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
        ResponseOutputAudioDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioDone,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioTranscriptDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioTranscriptDone,
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
        ResponseOutputTextDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextDone,
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventDiscriminatorType value)
        {
            return value switch
            {
                RealtimeServerEventDiscriminatorType.ConversationCreated => "conversation.created",
                RealtimeServerEventDiscriminatorType.ConversationItemAdded => "conversation.item.added",
                RealtimeServerEventDiscriminatorType.ConversationItemCreated => "conversation.item.created",
                RealtimeServerEventDiscriminatorType.ConversationItemDeleted => "conversation.item.deleted",
                RealtimeServerEventDiscriminatorType.ConversationItemDone => "conversation.item.done",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta => "conversation.item.input_audio_transcription.delta",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionSegment => "conversation.item.input_audio_transcription.segment",
                RealtimeServerEventDiscriminatorType.ConversationItemRetrieved => "conversation.item.retrieved",
                RealtimeServerEventDiscriminatorType.ConversationItemTruncated => "conversation.item.truncated",
                RealtimeServerEventDiscriminatorType.Error => "error",
                RealtimeServerEventDiscriminatorType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                RealtimeServerEventDiscriminatorType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                RealtimeServerEventDiscriminatorType.InputAudioBufferDtmfEventReceived => "input_audio_buffer.dtmf_event_received",
                RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                RealtimeServerEventDiscriminatorType.InputAudioBufferTimeoutTriggered => "input_audio_buffer.timeout_triggered",
                RealtimeServerEventDiscriminatorType.McpListToolsCompleted => "mcp_list_tools.completed",
                RealtimeServerEventDiscriminatorType.McpListToolsFailed => "mcp_list_tools.failed",
                RealtimeServerEventDiscriminatorType.McpListToolsInProgress => "mcp_list_tools.in_progress",
                RealtimeServerEventDiscriminatorType.OutputAudioBufferCleared => "output_audio_buffer.cleared",
                RealtimeServerEventDiscriminatorType.OutputAudioBufferStarted => "output_audio_buffer.started",
                RealtimeServerEventDiscriminatorType.OutputAudioBufferStopped => "output_audio_buffer.stopped",
                RealtimeServerEventDiscriminatorType.RateLimitsUpdated => "rate_limits.updated",
                RealtimeServerEventDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                RealtimeServerEventDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                RealtimeServerEventDiscriminatorType.ResponseCreated => "response.created",
                RealtimeServerEventDiscriminatorType.ResponseDone => "response.done",
                RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                RealtimeServerEventDiscriminatorType.ResponseMcpCallCompleted => "response.mcp_call.completed",
                RealtimeServerEventDiscriminatorType.ResponseMcpCallFailed => "response.mcp_call.failed",
                RealtimeServerEventDiscriminatorType.ResponseMcpCallInProgress => "response.mcp_call.in_progress",
                RealtimeServerEventDiscriminatorType.ResponseMcpCallArgumentsDelta => "response.mcp_call_arguments.delta",
                RealtimeServerEventDiscriminatorType.ResponseMcpCallArgumentsDone => "response.mcp_call_arguments.done",
                RealtimeServerEventDiscriminatorType.ResponseOutputAudioDelta => "response.output_audio.delta",
                RealtimeServerEventDiscriminatorType.ResponseOutputAudioDone => "response.output_audio.done",
                RealtimeServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta => "response.output_audio_transcript.delta",
                RealtimeServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone => "response.output_audio_transcript.done",
                RealtimeServerEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                RealtimeServerEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                RealtimeServerEventDiscriminatorType.ResponseOutputTextDelta => "response.output_text.delta",
                RealtimeServerEventDiscriminatorType.ResponseOutputTextDone => "response.output_text.done",
                RealtimeServerEventDiscriminatorType.SessionCreated => "session.created",
                RealtimeServerEventDiscriminatorType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.created" => RealtimeServerEventDiscriminatorType.ConversationCreated,
                "conversation.item.added" => RealtimeServerEventDiscriminatorType.ConversationItemAdded,
                "conversation.item.created" => RealtimeServerEventDiscriminatorType.ConversationItemCreated,
                "conversation.item.deleted" => RealtimeServerEventDiscriminatorType.ConversationItemDeleted,
                "conversation.item.done" => RealtimeServerEventDiscriminatorType.ConversationItemDone,
                "conversation.item.input_audio_transcription.completed" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted,
                "conversation.item.input_audio_transcription.delta" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta,
                "conversation.item.input_audio_transcription.failed" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed,
                "conversation.item.input_audio_transcription.segment" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionSegment,
                "conversation.item.retrieved" => RealtimeServerEventDiscriminatorType.ConversationItemRetrieved,
                "conversation.item.truncated" => RealtimeServerEventDiscriminatorType.ConversationItemTruncated,
                "error" => RealtimeServerEventDiscriminatorType.Error,
                "input_audio_buffer.cleared" => RealtimeServerEventDiscriminatorType.InputAudioBufferCleared,
                "input_audio_buffer.committed" => RealtimeServerEventDiscriminatorType.InputAudioBufferCommitted,
                "input_audio_buffer.dtmf_event_received" => RealtimeServerEventDiscriminatorType.InputAudioBufferDtmfEventReceived,
                "input_audio_buffer.speech_started" => RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStarted,
                "input_audio_buffer.speech_stopped" => RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStopped,
                "input_audio_buffer.timeout_triggered" => RealtimeServerEventDiscriminatorType.InputAudioBufferTimeoutTriggered,
                "mcp_list_tools.completed" => RealtimeServerEventDiscriminatorType.McpListToolsCompleted,
                "mcp_list_tools.failed" => RealtimeServerEventDiscriminatorType.McpListToolsFailed,
                "mcp_list_tools.in_progress" => RealtimeServerEventDiscriminatorType.McpListToolsInProgress,
                "output_audio_buffer.cleared" => RealtimeServerEventDiscriminatorType.OutputAudioBufferCleared,
                "output_audio_buffer.started" => RealtimeServerEventDiscriminatorType.OutputAudioBufferStarted,
                "output_audio_buffer.stopped" => RealtimeServerEventDiscriminatorType.OutputAudioBufferStopped,
                "rate_limits.updated" => RealtimeServerEventDiscriminatorType.RateLimitsUpdated,
                "response.content_part.added" => RealtimeServerEventDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => RealtimeServerEventDiscriminatorType.ResponseContentPartDone,
                "response.created" => RealtimeServerEventDiscriminatorType.ResponseCreated,
                "response.done" => RealtimeServerEventDiscriminatorType.ResponseDone,
                "response.function_call_arguments.delta" => RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.mcp_call.completed" => RealtimeServerEventDiscriminatorType.ResponseMcpCallCompleted,
                "response.mcp_call.failed" => RealtimeServerEventDiscriminatorType.ResponseMcpCallFailed,
                "response.mcp_call.in_progress" => RealtimeServerEventDiscriminatorType.ResponseMcpCallInProgress,
                "response.mcp_call_arguments.delta" => RealtimeServerEventDiscriminatorType.ResponseMcpCallArgumentsDelta,
                "response.mcp_call_arguments.done" => RealtimeServerEventDiscriminatorType.ResponseMcpCallArgumentsDone,
                "response.output_audio.delta" => RealtimeServerEventDiscriminatorType.ResponseOutputAudioDelta,
                "response.output_audio.done" => RealtimeServerEventDiscriminatorType.ResponseOutputAudioDone,
                "response.output_audio_transcript.delta" => RealtimeServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta,
                "response.output_audio_transcript.done" => RealtimeServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone,
                "response.output_item.added" => RealtimeServerEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => RealtimeServerEventDiscriminatorType.ResponseOutputItemDone,
                "response.output_text.delta" => RealtimeServerEventDiscriminatorType.ResponseOutputTextDelta,
                "response.output_text.done" => RealtimeServerEventDiscriminatorType.ResponseOutputTextDone,
                "session.created" => RealtimeServerEventDiscriminatorType.SessionCreated,
                "session.updated" => RealtimeServerEventDiscriminatorType.SessionUpdated,
                _ => null,
            };
        }
    }
}