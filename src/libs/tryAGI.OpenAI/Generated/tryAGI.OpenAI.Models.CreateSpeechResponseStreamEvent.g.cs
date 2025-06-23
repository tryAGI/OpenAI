#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateSpeechResponseStreamEvent : global::System.IEquatable<CreateSpeechResponseStreamEvent>
    {
        /// <summary>
        /// Emitted for each chunk of audio data generated during speech synthesis.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SpeechAudioDeltaEvent? AudioDelta { get; init; }
#else
        public global::tryAGI.OpenAI.SpeechAudioDeltaEvent? AudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioDelta))]
#endif
        public bool IsAudioDelta => AudioDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSpeechResponseStreamEvent(global::tryAGI.OpenAI.SpeechAudioDeltaEvent value) => new CreateSpeechResponseStreamEvent((global::tryAGI.OpenAI.SpeechAudioDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SpeechAudioDeltaEvent?(CreateSpeechResponseStreamEvent @this) => @this.AudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public CreateSpeechResponseStreamEvent(global::tryAGI.OpenAI.SpeechAudioDeltaEvent? value)
        {
            AudioDelta = value;
        }

        /// <summary>
        /// Emitted when the speech synthesis is complete and all audio has been streamed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SpeechAudioDoneEvent? AudioDone { get; init; }
#else
        public global::tryAGI.OpenAI.SpeechAudioDoneEvent? AudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioDone))]
#endif
        public bool IsAudioDone => AudioDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSpeechResponseStreamEvent(global::tryAGI.OpenAI.SpeechAudioDoneEvent value) => new CreateSpeechResponseStreamEvent((global::tryAGI.OpenAI.SpeechAudioDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SpeechAudioDoneEvent?(CreateSpeechResponseStreamEvent @this) => @this.AudioDone;

        /// <summary>
        /// 
        /// </summary>
        public CreateSpeechResponseStreamEvent(global::tryAGI.OpenAI.SpeechAudioDoneEvent? value)
        {
            AudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateSpeechResponseStreamEvent(
            global::tryAGI.OpenAI.SpeechAudioDeltaEvent? audioDelta,
            global::tryAGI.OpenAI.SpeechAudioDoneEvent? audioDone
            )
        {
            AudioDelta = audioDelta;
            AudioDone = audioDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AudioDone as object ??
            AudioDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AudioDelta?.ToString() ??
            AudioDone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAudioDelta || IsAudioDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.SpeechAudioDeltaEvent?, TResult>? audioDelta = null,
            global::System.Func<global::tryAGI.OpenAI.SpeechAudioDoneEvent?, TResult>? audioDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioDelta && audioDelta != null)
            {
                return audioDelta(AudioDelta!);
            }
            else if (IsAudioDone && audioDone != null)
            {
                return audioDone(AudioDone!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.SpeechAudioDeltaEvent?>? audioDelta = null,
            global::System.Action<global::tryAGI.OpenAI.SpeechAudioDoneEvent?>? audioDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioDelta)
            {
                audioDelta?.Invoke(AudioDelta!);
            }
            else if (IsAudioDone)
            {
                audioDone?.Invoke(AudioDone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AudioDelta,
                typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEvent),
                AudioDone,
                typeof(global::tryAGI.OpenAI.SpeechAudioDoneEvent),
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
        public bool Equals(CreateSpeechResponseStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SpeechAudioDeltaEvent?>.Default.Equals(AudioDelta, other.AudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SpeechAudioDoneEvent?>.Default.Equals(AudioDone, other.AudioDone) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateSpeechResponseStreamEvent obj1, CreateSpeechResponseStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSpeechResponseStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateSpeechResponseStreamEvent obj1, CreateSpeechResponseStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSpeechResponseStreamEvent o && Equals(o);
        }
    }
}
