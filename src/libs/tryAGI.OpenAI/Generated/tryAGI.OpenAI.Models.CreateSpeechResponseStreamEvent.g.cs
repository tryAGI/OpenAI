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
        public global::tryAGI.OpenAI.SpeechAudioDeltaEvent? SpeechAudioDelta { get; init; }
#else
        public global::tryAGI.OpenAI.SpeechAudioDeltaEvent? SpeechAudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechAudioDelta))]
#endif
        public bool IsSpeechAudioDelta => SpeechAudioDelta != null;

        /// <summary>
        /// Emitted when the speech synthesis is complete and all audio has been streamed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SpeechAudioDoneEvent? SpeechAudioDone { get; init; }
#else
        public global::tryAGI.OpenAI.SpeechAudioDoneEvent? SpeechAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechAudioDone))]
#endif
        public bool IsSpeechAudioDone => SpeechAudioDone != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSpeechResponseStreamEvent(global::tryAGI.OpenAI.SpeechAudioDeltaEvent value) => new CreateSpeechResponseStreamEvent((global::tryAGI.OpenAI.SpeechAudioDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SpeechAudioDeltaEvent?(CreateSpeechResponseStreamEvent @this) => @this.SpeechAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public CreateSpeechResponseStreamEvent(global::tryAGI.OpenAI.SpeechAudioDeltaEvent? value)
        {
            SpeechAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSpeechResponseStreamEvent(global::tryAGI.OpenAI.SpeechAudioDoneEvent value) => new CreateSpeechResponseStreamEvent((global::tryAGI.OpenAI.SpeechAudioDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SpeechAudioDoneEvent?(CreateSpeechResponseStreamEvent @this) => @this.SpeechAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public CreateSpeechResponseStreamEvent(global::tryAGI.OpenAI.SpeechAudioDoneEvent? value)
        {
            SpeechAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateSpeechResponseStreamEvent(
            global::tryAGI.OpenAI.SpeechAudioDeltaEvent? speechAudioDelta,
            global::tryAGI.OpenAI.SpeechAudioDoneEvent? speechAudioDone
            )
        {
            SpeechAudioDelta = speechAudioDelta;
            SpeechAudioDone = speechAudioDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SpeechAudioDone as object ??
            SpeechAudioDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SpeechAudioDelta?.ToString() ??
            SpeechAudioDone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSpeechAudioDelta || IsSpeechAudioDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.SpeechAudioDeltaEvent?, TResult>? speechAudioDelta = null,
            global::System.Func<global::tryAGI.OpenAI.SpeechAudioDoneEvent?, TResult>? speechAudioDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeechAudioDelta && speechAudioDelta != null)
            {
                return speechAudioDelta(SpeechAudioDelta!);
            }
            else if (IsSpeechAudioDone && speechAudioDone != null)
            {
                return speechAudioDone(SpeechAudioDone!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.SpeechAudioDeltaEvent?>? speechAudioDelta = null,
            global::System.Action<global::tryAGI.OpenAI.SpeechAudioDoneEvent?>? speechAudioDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeechAudioDelta)
            {
                speechAudioDelta?.Invoke(SpeechAudioDelta!);
            }
            else if (IsSpeechAudioDone)
            {
                speechAudioDone?.Invoke(SpeechAudioDone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SpeechAudioDelta,
                typeof(global::tryAGI.OpenAI.SpeechAudioDeltaEvent),
                SpeechAudioDone,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SpeechAudioDeltaEvent?>.Default.Equals(SpeechAudioDelta, other.SpeechAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SpeechAudioDoneEvent?>.Default.Equals(SpeechAudioDone, other.SpeechAudioDone) 
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
