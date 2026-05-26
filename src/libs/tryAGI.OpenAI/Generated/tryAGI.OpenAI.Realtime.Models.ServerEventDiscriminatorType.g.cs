
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerEventDiscriminatorType
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
        /// <summary>
        /// 
        /// </summary>
        TranscriptionSessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ServerEventDiscriminatorType.ConversationCreated => "conversation.created",
                ServerEventDiscriminatorType.ConversationItemAdded => "conversation.item.added",
                ServerEventDiscriminatorType.ConversationItemCreated => "conversation.item.created",
                ServerEventDiscriminatorType.ConversationItemDeleted => "conversation.item.deleted",
                ServerEventDiscriminatorType.ConversationItemDone => "conversation.item.done",
                ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta => "conversation.item.input_audio_transcription.delta",
                ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionSegment => "conversation.item.input_audio_transcription.segment",
                ServerEventDiscriminatorType.ConversationItemRetrieved => "conversation.item.retrieved",
                ServerEventDiscriminatorType.ConversationItemTruncated => "conversation.item.truncated",
                ServerEventDiscriminatorType.Error => "error",
                ServerEventDiscriminatorType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                ServerEventDiscriminatorType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                ServerEventDiscriminatorType.InputAudioBufferDtmfEventReceived => "input_audio_buffer.dtmf_event_received",
                ServerEventDiscriminatorType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                ServerEventDiscriminatorType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                ServerEventDiscriminatorType.InputAudioBufferTimeoutTriggered => "input_audio_buffer.timeout_triggered",
                ServerEventDiscriminatorType.McpListToolsCompleted => "mcp_list_tools.completed",
                ServerEventDiscriminatorType.McpListToolsFailed => "mcp_list_tools.failed",
                ServerEventDiscriminatorType.McpListToolsInProgress => "mcp_list_tools.in_progress",
                ServerEventDiscriminatorType.OutputAudioBufferCleared => "output_audio_buffer.cleared",
                ServerEventDiscriminatorType.OutputAudioBufferStarted => "output_audio_buffer.started",
                ServerEventDiscriminatorType.OutputAudioBufferStopped => "output_audio_buffer.stopped",
                ServerEventDiscriminatorType.RateLimitsUpdated => "rate_limits.updated",
                ServerEventDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                ServerEventDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                ServerEventDiscriminatorType.ResponseCreated => "response.created",
                ServerEventDiscriminatorType.ResponseDone => "response.done",
                ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                ServerEventDiscriminatorType.ResponseMcpCallCompleted => "response.mcp_call.completed",
                ServerEventDiscriminatorType.ResponseMcpCallFailed => "response.mcp_call.failed",
                ServerEventDiscriminatorType.ResponseMcpCallInProgress => "response.mcp_call.in_progress",
                ServerEventDiscriminatorType.ResponseMcpCallArgumentsDelta => "response.mcp_call_arguments.delta",
                ServerEventDiscriminatorType.ResponseMcpCallArgumentsDone => "response.mcp_call_arguments.done",
                ServerEventDiscriminatorType.ResponseOutputAudioDelta => "response.output_audio.delta",
                ServerEventDiscriminatorType.ResponseOutputAudioDone => "response.output_audio.done",
                ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta => "response.output_audio_transcript.delta",
                ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone => "response.output_audio_transcript.done",
                ServerEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                ServerEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                ServerEventDiscriminatorType.ResponseOutputTextDelta => "response.output_text.delta",
                ServerEventDiscriminatorType.ResponseOutputTextDone => "response.output_text.done",
                ServerEventDiscriminatorType.SessionCreated => "session.created",
                ServerEventDiscriminatorType.SessionUpdated => "session.updated",
                ServerEventDiscriminatorType.TranscriptionSessionUpdated => "transcription_session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.created" => ServerEventDiscriminatorType.ConversationCreated,
                "conversation.item.added" => ServerEventDiscriminatorType.ConversationItemAdded,
                "conversation.item.created" => ServerEventDiscriminatorType.ConversationItemCreated,
                "conversation.item.deleted" => ServerEventDiscriminatorType.ConversationItemDeleted,
                "conversation.item.done" => ServerEventDiscriminatorType.ConversationItemDone,
                "conversation.item.input_audio_transcription.completed" => ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted,
                "conversation.item.input_audio_transcription.delta" => ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta,
                "conversation.item.input_audio_transcription.failed" => ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed,
                "conversation.item.input_audio_transcription.segment" => ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionSegment,
                "conversation.item.retrieved" => ServerEventDiscriminatorType.ConversationItemRetrieved,
                "conversation.item.truncated" => ServerEventDiscriminatorType.ConversationItemTruncated,
                "error" => ServerEventDiscriminatorType.Error,
                "input_audio_buffer.cleared" => ServerEventDiscriminatorType.InputAudioBufferCleared,
                "input_audio_buffer.committed" => ServerEventDiscriminatorType.InputAudioBufferCommitted,
                "input_audio_buffer.dtmf_event_received" => ServerEventDiscriminatorType.InputAudioBufferDtmfEventReceived,
                "input_audio_buffer.speech_started" => ServerEventDiscriminatorType.InputAudioBufferSpeechStarted,
                "input_audio_buffer.speech_stopped" => ServerEventDiscriminatorType.InputAudioBufferSpeechStopped,
                "input_audio_buffer.timeout_triggered" => ServerEventDiscriminatorType.InputAudioBufferTimeoutTriggered,
                "mcp_list_tools.completed" => ServerEventDiscriminatorType.McpListToolsCompleted,
                "mcp_list_tools.failed" => ServerEventDiscriminatorType.McpListToolsFailed,
                "mcp_list_tools.in_progress" => ServerEventDiscriminatorType.McpListToolsInProgress,
                "output_audio_buffer.cleared" => ServerEventDiscriminatorType.OutputAudioBufferCleared,
                "output_audio_buffer.started" => ServerEventDiscriminatorType.OutputAudioBufferStarted,
                "output_audio_buffer.stopped" => ServerEventDiscriminatorType.OutputAudioBufferStopped,
                "rate_limits.updated" => ServerEventDiscriminatorType.RateLimitsUpdated,
                "response.content_part.added" => ServerEventDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => ServerEventDiscriminatorType.ResponseContentPartDone,
                "response.created" => ServerEventDiscriminatorType.ResponseCreated,
                "response.done" => ServerEventDiscriminatorType.ResponseDone,
                "response.function_call_arguments.delta" => ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.mcp_call.completed" => ServerEventDiscriminatorType.ResponseMcpCallCompleted,
                "response.mcp_call.failed" => ServerEventDiscriminatorType.ResponseMcpCallFailed,
                "response.mcp_call.in_progress" => ServerEventDiscriminatorType.ResponseMcpCallInProgress,
                "response.mcp_call_arguments.delta" => ServerEventDiscriminatorType.ResponseMcpCallArgumentsDelta,
                "response.mcp_call_arguments.done" => ServerEventDiscriminatorType.ResponseMcpCallArgumentsDone,
                "response.output_audio.delta" => ServerEventDiscriminatorType.ResponseOutputAudioDelta,
                "response.output_audio.done" => ServerEventDiscriminatorType.ResponseOutputAudioDone,
                "response.output_audio_transcript.delta" => ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDelta,
                "response.output_audio_transcript.done" => ServerEventDiscriminatorType.ResponseOutputAudioTranscriptDone,
                "response.output_item.added" => ServerEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => ServerEventDiscriminatorType.ResponseOutputItemDone,
                "response.output_text.delta" => ServerEventDiscriminatorType.ResponseOutputTextDelta,
                "response.output_text.done" => ServerEventDiscriminatorType.ResponseOutputTextDone,
                "session.created" => ServerEventDiscriminatorType.SessionCreated,
                "session.updated" => ServerEventDiscriminatorType.SessionUpdated,
                "transcription_session.updated" => ServerEventDiscriminatorType.TranscriptionSessionUpdated,
                _ => null,
            };
        }
    }
}