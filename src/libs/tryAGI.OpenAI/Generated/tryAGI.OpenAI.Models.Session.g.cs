#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Session configuration to use for the client secret. Choose either a realtime<br/>
    /// session or a transcription session.
    /// </summary>
    public readonly partial struct Session : global::System.IEquatable<Session>
    {
        /// <summary>
        /// Realtime session object configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA? RealtimeCreateRequestGA { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA? RealtimeCreateRequestGA { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeCreateRequestGA))]
#endif
        public bool IsRealtimeCreateRequestGA => RealtimeCreateRequestGA != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Session(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA value) => new Session((global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA?(Session @this) => @this.RealtimeCreateRequestGA;

        /// <summary>
        /// 
        /// </summary>
        public Session(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA? value)
        {
            RealtimeCreateRequestGA = value;
        }

        /// <summary>
        /// Realtime transcription session object configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA? RealtimeTranscriptionCreateRequestGA { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA? RealtimeTranscriptionCreateRequestGA { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeTranscriptionCreateRequestGA))]
#endif
        public bool IsRealtimeTranscriptionCreateRequestGA => RealtimeTranscriptionCreateRequestGA != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Session(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA value) => new Session((global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA?(Session @this) => @this.RealtimeTranscriptionCreateRequestGA;

        /// <summary>
        /// 
        /// </summary>
        public Session(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA? value)
        {
            RealtimeTranscriptionCreateRequestGA = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Session(
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA? realtimeCreateRequestGA,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA? realtimeTranscriptionCreateRequestGA
            )
        {
            RealtimeCreateRequestGA = realtimeCreateRequestGA;
            RealtimeTranscriptionCreateRequestGA = realtimeTranscriptionCreateRequestGA;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RealtimeTranscriptionCreateRequestGA as object ??
            RealtimeCreateRequestGA as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RealtimeCreateRequestGA?.ToString() ??
            RealtimeTranscriptionCreateRequestGA?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeCreateRequestGA || IsRealtimeTranscriptionCreateRequestGA;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA?, TResult>? realtimeCreateRequestGA = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA?, TResult>? realtimeTranscriptionCreateRequestGA = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeCreateRequestGA && realtimeCreateRequestGA != null)
            {
                return realtimeCreateRequestGA(RealtimeCreateRequestGA!);
            }
            else if (IsRealtimeTranscriptionCreateRequestGA && realtimeTranscriptionCreateRequestGA != null)
            {
                return realtimeTranscriptionCreateRequestGA(RealtimeTranscriptionCreateRequestGA!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA?>? realtimeCreateRequestGA = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA?>? realtimeTranscriptionCreateRequestGA = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeCreateRequestGA)
            {
                realtimeCreateRequestGA?.Invoke(RealtimeCreateRequestGA!);
            }
            else if (IsRealtimeTranscriptionCreateRequestGA)
            {
                realtimeTranscriptionCreateRequestGA?.Invoke(RealtimeTranscriptionCreateRequestGA!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RealtimeCreateRequestGA,
                typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA),
                RealtimeTranscriptionCreateRequestGA,
                typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA),
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
        public bool Equals(Session other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA?>.Default.Equals(RealtimeCreateRequestGA, other.RealtimeCreateRequestGA) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA?>.Default.Equals(RealtimeTranscriptionCreateRequestGA, other.RealtimeTranscriptionCreateRequestGA) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Session obj1, Session obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Session>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Session obj1, Session obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Session o && Equals(o);
        }
    }
}
