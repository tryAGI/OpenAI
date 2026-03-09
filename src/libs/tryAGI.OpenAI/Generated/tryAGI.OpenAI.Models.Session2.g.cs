#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The session configuration for either a realtime or transcription session.
    /// </summary>
    public readonly partial struct Session2 : global::System.IEquatable<Session2>
    {
        /// <summary>
        /// A new Realtime session configuration, with an ephemeral key. Default TTL<br/>
        /// for keys is one minute.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? Realtime { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? Realtime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Realtime))]
#endif
        public bool IsRealtime => Realtime != null;

        /// <summary>
        /// A Realtime transcription session configuration object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? Transcription { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? Transcription { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Transcription))]
#endif
        public bool IsTranscription => Transcription != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Session2(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA value) => new Session2((global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?(Session2 @this) => @this.Realtime;

        /// <summary>
        /// 
        /// </summary>
        public Session2(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? value)
        {
            Realtime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Session2(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA value) => new Session2((global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?(Session2 @this) => @this.Transcription;

        /// <summary>
        /// 
        /// </summary>
        public Session2(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? value)
        {
            Transcription = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Session2(
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? realtime,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? transcription
            )
        {
            Realtime = realtime;
            Transcription = transcription;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Transcription as object ??
            Realtime as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Realtime?.ToString() ??
            Transcription?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRealtime && !IsTranscription || !IsRealtime && IsTranscription;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?, TResult>? realtime = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?, TResult>? transcription = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtime && realtime != null)
            {
                return realtime(Realtime!);
            }
            else if (IsTranscription && transcription != null)
            {
                return transcription(Transcription!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?>? realtime = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?>? transcription = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtime)
            {
                realtime?.Invoke(Realtime!);
            }
            else if (IsTranscription)
            {
                transcription?.Invoke(Transcription!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Realtime,
                typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA),
                Transcription,
                typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA),
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
        public bool Equals(Session2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?>.Default.Equals(Realtime, other.Realtime) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?>.Default.Equals(Transcription, other.Transcription) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Session2 obj1, Session2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Session2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Session2 obj1, Session2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Session2 o && Equals(o);
        }
    }
}
