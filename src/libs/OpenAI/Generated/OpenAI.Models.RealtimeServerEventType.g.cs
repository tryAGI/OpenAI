
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeServerEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
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
        ConversationCreated,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCommitted,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCleared,
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
        ConversationItemCreated,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionCompleted,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionFailed,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemTruncated,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDeleted,
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
        ResponseOutputItemAdded,
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemDone,
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
        ResponseTextDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseTextDone,
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
        ResponseAudioDelta,
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioDone,
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
        RateLimitsUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventType value)
        {
            return value switch
            {
                RealtimeServerEventType.Error => "error",
                RealtimeServerEventType.SessionCreated => "session.created",
                RealtimeServerEventType.SessionUpdated => "session.updated",
                RealtimeServerEventType.ConversationCreated => "conversation.created",
                RealtimeServerEventType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                RealtimeServerEventType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                RealtimeServerEventType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                RealtimeServerEventType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                RealtimeServerEventType.ConversationItemCreated => "conversation.item.created",
                RealtimeServerEventType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                RealtimeServerEventType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                RealtimeServerEventType.ConversationItemTruncated => "conversation.item.truncated",
                RealtimeServerEventType.ConversationItemDeleted => "conversation.item.deleted",
                RealtimeServerEventType.ResponseCreated => "response.created",
                RealtimeServerEventType.ResponseDone => "response.done",
                RealtimeServerEventType.ResponseOutputItemAdded => "response.output_item.added",
                RealtimeServerEventType.ResponseOutputItemDone => "response.output_item.done",
                RealtimeServerEventType.ResponseContentPartAdded => "response.content_part.added",
                RealtimeServerEventType.ResponseContentPartDone => "response.content_part.done",
                RealtimeServerEventType.ResponseTextDelta => "response.text.delta",
                RealtimeServerEventType.ResponseTextDone => "response.text.done",
                RealtimeServerEventType.ResponseAudioTranscriptDelta => "response.audio_transcript.delta",
                RealtimeServerEventType.ResponseAudioTranscriptDone => "response.audio_transcript.done",
                RealtimeServerEventType.ResponseAudioDelta => "response.audio.delta",
                RealtimeServerEventType.ResponseAudioDone => "response.audio.done",
                RealtimeServerEventType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                RealtimeServerEventType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                RealtimeServerEventType.RateLimitsUpdated => "rate_limits.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventType? ToEnum(string value)
        {
            return value switch
            {
                "error" => RealtimeServerEventType.Error,
                "session.created" => RealtimeServerEventType.SessionCreated,
                "session.updated" => RealtimeServerEventType.SessionUpdated,
                "conversation.created" => RealtimeServerEventType.ConversationCreated,
                "input_audio_buffer.committed" => RealtimeServerEventType.InputAudioBufferCommitted,
                "input_audio_buffer.cleared" => RealtimeServerEventType.InputAudioBufferCleared,
                "input_audio_buffer.speech_started" => RealtimeServerEventType.InputAudioBufferSpeechStarted,
                "input_audio_buffer.speech_stopped" => RealtimeServerEventType.InputAudioBufferSpeechStopped,
                "conversation.item.created" => RealtimeServerEventType.ConversationItemCreated,
                "conversation.item.input_audio_transcription.completed" => RealtimeServerEventType.ConversationItemInputAudioTranscriptionCompleted,
                "conversation.item.input_audio_transcription.failed" => RealtimeServerEventType.ConversationItemInputAudioTranscriptionFailed,
                "conversation.item.truncated" => RealtimeServerEventType.ConversationItemTruncated,
                "conversation.item.deleted" => RealtimeServerEventType.ConversationItemDeleted,
                "response.created" => RealtimeServerEventType.ResponseCreated,
                "response.done" => RealtimeServerEventType.ResponseDone,
                "response.output_item.added" => RealtimeServerEventType.ResponseOutputItemAdded,
                "response.output_item.done" => RealtimeServerEventType.ResponseOutputItemDone,
                "response.content_part.added" => RealtimeServerEventType.ResponseContentPartAdded,
                "response.content_part.done" => RealtimeServerEventType.ResponseContentPartDone,
                "response.text.delta" => RealtimeServerEventType.ResponseTextDelta,
                "response.text.done" => RealtimeServerEventType.ResponseTextDone,
                "response.audio_transcript.delta" => RealtimeServerEventType.ResponseAudioTranscriptDelta,
                "response.audio_transcript.done" => RealtimeServerEventType.ResponseAudioTranscriptDone,
                "response.audio.delta" => RealtimeServerEventType.ResponseAudioDelta,
                "response.audio.done" => RealtimeServerEventType.ResponseAudioDone,
                "response.function_call_arguments.delta" => RealtimeServerEventType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => RealtimeServerEventType.ResponseFunctionCallArgumentsDone,
                "rate_limits.updated" => RealtimeServerEventType.RateLimitsUpdated,
                _ => null,
            };
        }
    }
}