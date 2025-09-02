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
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequest? RealtimeCreateRequest { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequest? RealtimeCreateRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeCreateRequest))]
#endif
        public bool IsRealtimeCreateRequest => RealtimeCreateRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Session(global::tryAGI.OpenAI.RealtimeSessionCreateRequest value) => new Session((global::tryAGI.OpenAI.RealtimeSessionCreateRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeSessionCreateRequest?(Session @this) => @this.RealtimeCreateRequest;

        /// <summary>
        /// 
        /// </summary>
        public Session(global::tryAGI.OpenAI.RealtimeSessionCreateRequest? value)
        {
            RealtimeCreateRequest = value;
        }

        /// <summary>
        /// Realtime transcription session object configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest? RealtimeTranscriptionCreateRequest { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest? RealtimeTranscriptionCreateRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeTranscriptionCreateRequest))]
#endif
        public bool IsRealtimeTranscriptionCreateRequest => RealtimeTranscriptionCreateRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Session(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest value) => new Session((global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest?(Session @this) => @this.RealtimeTranscriptionCreateRequest;

        /// <summary>
        /// 
        /// </summary>
        public Session(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest? value)
        {
            RealtimeTranscriptionCreateRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Session(
            global::tryAGI.OpenAI.RealtimeSessionCreateRequest? realtimeCreateRequest,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest? realtimeTranscriptionCreateRequest
            )
        {
            RealtimeCreateRequest = realtimeCreateRequest;
            RealtimeTranscriptionCreateRequest = realtimeTranscriptionCreateRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RealtimeTranscriptionCreateRequest as object ??
            RealtimeCreateRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RealtimeCreateRequest?.ToString() ??
            RealtimeTranscriptionCreateRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeCreateRequest || IsRealtimeTranscriptionCreateRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeSessionCreateRequest?, TResult>? realtimeCreateRequest = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest?, TResult>? realtimeTranscriptionCreateRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeCreateRequest && realtimeCreateRequest != null)
            {
                return realtimeCreateRequest(RealtimeCreateRequest!);
            }
            else if (IsRealtimeTranscriptionCreateRequest && realtimeTranscriptionCreateRequest != null)
            {
                return realtimeTranscriptionCreateRequest(RealtimeTranscriptionCreateRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeSessionCreateRequest?>? realtimeCreateRequest = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest?>? realtimeTranscriptionCreateRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeCreateRequest)
            {
                realtimeCreateRequest?.Invoke(RealtimeCreateRequest!);
            }
            else if (IsRealtimeTranscriptionCreateRequest)
            {
                realtimeTranscriptionCreateRequest?.Invoke(RealtimeTranscriptionCreateRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RealtimeCreateRequest,
                typeof(global::tryAGI.OpenAI.RealtimeSessionCreateRequest),
                RealtimeTranscriptionCreateRequest,
                typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeSessionCreateRequest?>.Default.Equals(RealtimeCreateRequest, other.RealtimeCreateRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest?>.Default.Equals(RealtimeTranscriptionCreateRequest, other.RealtimeTranscriptionCreateRequest) 
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
