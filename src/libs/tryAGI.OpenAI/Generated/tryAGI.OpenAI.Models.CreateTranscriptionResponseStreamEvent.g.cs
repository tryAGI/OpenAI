#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateTranscriptionResponseStreamEvent : global::System.IEquatable<CreateTranscriptionResponseStreamEvent>
    {
        /// <summary>
        /// Emitted when there is an additional text delta. This is also the first event emitted when the transcription starts. Only emitted when you [create a transcription](/docs/api-reference/audio/create-transcription) with the `Stream` parameter set to `true`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TranscriptTextDeltaEvent? TranscriptTextDelta { get; init; }
#else
        public global::tryAGI.OpenAI.TranscriptTextDeltaEvent? TranscriptTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptTextDelta))]
#endif
        public bool IsTranscriptTextDelta => TranscriptTextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTranscriptionResponseStreamEvent(global::tryAGI.OpenAI.TranscriptTextDeltaEvent value) => new CreateTranscriptionResponseStreamEvent((global::tryAGI.OpenAI.TranscriptTextDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TranscriptTextDeltaEvent?(CreateTranscriptionResponseStreamEvent @this) => @this.TranscriptTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public CreateTranscriptionResponseStreamEvent(global::tryAGI.OpenAI.TranscriptTextDeltaEvent? value)
        {
            TranscriptTextDelta = value;
        }

        /// <summary>
        /// Emitted when the transcription is complete. Contains the complete transcription text. Only emitted when you [create a transcription](/docs/api-reference/audio/create-transcription) with the `Stream` parameter set to `true`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TranscriptTextDoneEvent? TranscriptTextDone { get; init; }
#else
        public global::tryAGI.OpenAI.TranscriptTextDoneEvent? TranscriptTextDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptTextDone))]
#endif
        public bool IsTranscriptTextDone => TranscriptTextDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateTranscriptionResponseStreamEvent(global::tryAGI.OpenAI.TranscriptTextDoneEvent value) => new CreateTranscriptionResponseStreamEvent((global::tryAGI.OpenAI.TranscriptTextDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TranscriptTextDoneEvent?(CreateTranscriptionResponseStreamEvent @this) => @this.TranscriptTextDone;

        /// <summary>
        /// 
        /// </summary>
        public CreateTranscriptionResponseStreamEvent(global::tryAGI.OpenAI.TranscriptTextDoneEvent? value)
        {
            TranscriptTextDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateTranscriptionResponseStreamEvent(
            global::tryAGI.OpenAI.TranscriptTextDeltaEvent? transcriptTextDelta,
            global::tryAGI.OpenAI.TranscriptTextDoneEvent? transcriptTextDone
            )
        {
            TranscriptTextDelta = transcriptTextDelta;
            TranscriptTextDone = transcriptTextDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TranscriptTextDone as object ??
            TranscriptTextDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TranscriptTextDelta?.ToString() ??
            TranscriptTextDone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranscriptTextDelta || IsTranscriptTextDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.TranscriptTextDeltaEvent?, TResult>? transcriptTextDelta = null,
            global::System.Func<global::tryAGI.OpenAI.TranscriptTextDoneEvent?, TResult>? transcriptTextDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptTextDelta && transcriptTextDelta != null)
            {
                return transcriptTextDelta(TranscriptTextDelta!);
            }
            else if (IsTranscriptTextDone && transcriptTextDone != null)
            {
                return transcriptTextDone(TranscriptTextDone!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.TranscriptTextDeltaEvent?>? transcriptTextDelta = null,
            global::System.Action<global::tryAGI.OpenAI.TranscriptTextDoneEvent?>? transcriptTextDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptTextDelta)
            {
                transcriptTextDelta?.Invoke(TranscriptTextDelta!);
            }
            else if (IsTranscriptTextDone)
            {
                transcriptTextDone?.Invoke(TranscriptTextDone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TranscriptTextDelta,
                typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent),
                TranscriptTextDone,
                typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CreateTranscriptionResponseStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TranscriptTextDeltaEvent?>.Default.Equals(TranscriptTextDelta, other.TranscriptTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TranscriptTextDoneEvent?>.Default.Equals(TranscriptTextDone, other.TranscriptTextDone) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateTranscriptionResponseStreamEvent obj1, CreateTranscriptionResponseStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateTranscriptionResponseStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateTranscriptionResponseStreamEvent obj1, CreateTranscriptionResponseStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateTranscriptionResponseStreamEvent o && Equals(o);
        }
    }
}
