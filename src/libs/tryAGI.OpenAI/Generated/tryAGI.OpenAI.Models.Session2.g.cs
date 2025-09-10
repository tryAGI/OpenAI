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
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? RealtimeSessionCreateResponseGA { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? RealtimeSessionCreateResponseGA { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeSessionCreateResponseGA))]
#endif
        public bool IsRealtimeSessionCreateResponseGA => RealtimeSessionCreateResponseGA != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Session2(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA value) => new Session2((global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?(Session2 @this) => @this.RealtimeSessionCreateResponseGA;

        /// <summary>
        /// 
        /// </summary>
        public Session2(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? value)
        {
            RealtimeSessionCreateResponseGA = value;
        }

        /// <summary>
        /// A Realtime transcription session configuration object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? RealtimeTranscriptionSessionCreateResponseGA { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? RealtimeTranscriptionSessionCreateResponseGA { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeTranscriptionSessionCreateResponseGA))]
#endif
        public bool IsRealtimeTranscriptionSessionCreateResponseGA => RealtimeTranscriptionSessionCreateResponseGA != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Session2(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA value) => new Session2((global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?(Session2 @this) => @this.RealtimeTranscriptionSessionCreateResponseGA;

        /// <summary>
        /// 
        /// </summary>
        public Session2(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? value)
        {
            RealtimeTranscriptionSessionCreateResponseGA = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Session2(
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA? realtimeSessionCreateResponseGA,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA? realtimeTranscriptionSessionCreateResponseGA
            )
        {
            RealtimeSessionCreateResponseGA = realtimeSessionCreateResponseGA;
            RealtimeTranscriptionSessionCreateResponseGA = realtimeTranscriptionSessionCreateResponseGA;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RealtimeTranscriptionSessionCreateResponseGA as object ??
            RealtimeSessionCreateResponseGA as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RealtimeSessionCreateResponseGA?.ToString() ??
            RealtimeTranscriptionSessionCreateResponseGA?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeSessionCreateResponseGA || IsRealtimeTranscriptionSessionCreateResponseGA;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?, TResult>? realtimeSessionCreateResponseGA = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?, TResult>? realtimeTranscriptionSessionCreateResponseGA = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeSessionCreateResponseGA && realtimeSessionCreateResponseGA != null)
            {
                return realtimeSessionCreateResponseGA(RealtimeSessionCreateResponseGA!);
            }
            else if (IsRealtimeTranscriptionSessionCreateResponseGA && realtimeTranscriptionSessionCreateResponseGA != null)
            {
                return realtimeTranscriptionSessionCreateResponseGA(RealtimeTranscriptionSessionCreateResponseGA!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?>? realtimeSessionCreateResponseGA = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?>? realtimeTranscriptionSessionCreateResponseGA = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeSessionCreateResponseGA)
            {
                realtimeSessionCreateResponseGA?.Invoke(RealtimeSessionCreateResponseGA!);
            }
            else if (IsRealtimeTranscriptionSessionCreateResponseGA)
            {
                realtimeTranscriptionSessionCreateResponseGA?.Invoke(RealtimeTranscriptionSessionCreateResponseGA!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RealtimeSessionCreateResponseGA,
                typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA),
                RealtimeTranscriptionSessionCreateResponseGA,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeSessionCreateResponseGA?>.Default.Equals(RealtimeSessionCreateResponseGA, other.RealtimeSessionCreateResponseGA) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGA?>.Default.Equals(RealtimeTranscriptionSessionCreateResponseGA, other.RealtimeTranscriptionSessionCreateResponseGA) 
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
