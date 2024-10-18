
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeServerEventDiscriminatorType
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
    public static class RealtimeServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventDiscriminatorType value)
        {
            return value switch
            {
                RealtimeServerEventDiscriminatorType.Error => "error",
                RealtimeServerEventDiscriminatorType.SessionCreated => "session.created",
                RealtimeServerEventDiscriminatorType.SessionUpdated => "session.updated",
                RealtimeServerEventDiscriminatorType.ConversationCreated => "conversation.created",
                RealtimeServerEventDiscriminatorType.ConversationItemCreated => "conversation.item.created",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                RealtimeServerEventDiscriminatorType.ConversationItemTruncated => "conversation.item.truncated",
                RealtimeServerEventDiscriminatorType.ConversationItemDeleted => "conversation.item.deleted",
                RealtimeServerEventDiscriminatorType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                RealtimeServerEventDiscriminatorType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                RealtimeServerEventDiscriminatorType.ResponseCreated => "response.created",
                RealtimeServerEventDiscriminatorType.ResponseDone => "response.done",
                RealtimeServerEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                RealtimeServerEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                RealtimeServerEventDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                RealtimeServerEventDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                RealtimeServerEventDiscriminatorType.ResponseTextDelta => "response.text.delta",
                RealtimeServerEventDiscriminatorType.ResponseTextDone => "response.text.done",
                RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDelta => "response.audio_transcript.delta",
                RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDone => "response.audio_transcript.done",
                RealtimeServerEventDiscriminatorType.ResponseAudioDelta => "response.audio.delta",
                RealtimeServerEventDiscriminatorType.ResponseAudioDone => "response.audio.done",
                RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                RealtimeServerEventDiscriminatorType.RateLimitsUpdated => "rate_limits.updated",
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
                "error" => RealtimeServerEventDiscriminatorType.Error,
                "session.created" => RealtimeServerEventDiscriminatorType.SessionCreated,
                "session.updated" => RealtimeServerEventDiscriminatorType.SessionUpdated,
                "conversation.created" => RealtimeServerEventDiscriminatorType.ConversationCreated,
                "conversation.item.created" => RealtimeServerEventDiscriminatorType.ConversationItemCreated,
                "conversation.item.input_audio_transcription.completed" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted,
                "conversation.item.input_audio_transcription.failed" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed,
                "conversation.item.truncated" => RealtimeServerEventDiscriminatorType.ConversationItemTruncated,
                "conversation.item.deleted" => RealtimeServerEventDiscriminatorType.ConversationItemDeleted,
                "input_audio_buffer.committed" => RealtimeServerEventDiscriminatorType.InputAudioBufferCommitted,
                "input_audio_buffer.cleared" => RealtimeServerEventDiscriminatorType.InputAudioBufferCleared,
                "input_audio_buffer.speech_started" => RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStarted,
                "input_audio_buffer.speech_stopped" => RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStopped,
                "response.created" => RealtimeServerEventDiscriminatorType.ResponseCreated,
                "response.done" => RealtimeServerEventDiscriminatorType.ResponseDone,
                "response.output_item.added" => RealtimeServerEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => RealtimeServerEventDiscriminatorType.ResponseOutputItemDone,
                "response.content_part.added" => RealtimeServerEventDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => RealtimeServerEventDiscriminatorType.ResponseContentPartDone,
                "response.text.delta" => RealtimeServerEventDiscriminatorType.ResponseTextDelta,
                "response.text.done" => RealtimeServerEventDiscriminatorType.ResponseTextDone,
                "response.audio_transcript.delta" => RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDelta,
                "response.audio_transcript.done" => RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDone,
                "response.audio.delta" => RealtimeServerEventDiscriminatorType.ResponseAudioDelta,
                "response.audio.done" => RealtimeServerEventDiscriminatorType.ResponseAudioDone,
                "response.function_call_arguments.delta" => RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "rate_limits.updated" => RealtimeServerEventDiscriminatorType.RateLimitsUpdated,
                _ => null,
            };
        }
    }
}