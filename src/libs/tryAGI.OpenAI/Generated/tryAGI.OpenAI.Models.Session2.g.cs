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
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponse? RealtimeSessionCreateResponse { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponse? RealtimeSessionCreateResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeSessionCreateResponse))]
#endif
        public bool IsRealtimeSessionCreateResponse => RealtimeSessionCreateResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Session2(global::tryAGI.OpenAI.RealtimeSessionCreateResponse value) => new Session2((global::tryAGI.OpenAI.RealtimeSessionCreateResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeSessionCreateResponse?(Session2 @this) => @this.RealtimeSessionCreateResponse;

        /// <summary>
        /// 
        /// </summary>
        public Session2(global::tryAGI.OpenAI.RealtimeSessionCreateResponse? value)
        {
            RealtimeSessionCreateResponse = value;
        }

        /// <summary>
        /// A new Realtime transcription session configuration.<br/>
        /// When a session is created on the server via REST API, the session object<br/>
        /// also contains an ephemeral key. Default TTL for keys is 10 minutes. This<br/>
        /// property is not present when a session is updated via the WebSocket API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse? RealtimeTranscriptionSessionCreateResponse { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse? RealtimeTranscriptionSessionCreateResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeTranscriptionSessionCreateResponse))]
#endif
        public bool IsRealtimeTranscriptionSessionCreateResponse => RealtimeTranscriptionSessionCreateResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Session2(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse value) => new Session2((global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse?(Session2 @this) => @this.RealtimeTranscriptionSessionCreateResponse;

        /// <summary>
        /// 
        /// </summary>
        public Session2(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse? value)
        {
            RealtimeTranscriptionSessionCreateResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Session2(
            global::tryAGI.OpenAI.RealtimeSessionCreateResponse? realtimeSessionCreateResponse,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse? realtimeTranscriptionSessionCreateResponse
            )
        {
            RealtimeSessionCreateResponse = realtimeSessionCreateResponse;
            RealtimeTranscriptionSessionCreateResponse = realtimeTranscriptionSessionCreateResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RealtimeTranscriptionSessionCreateResponse as object ??
            RealtimeSessionCreateResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RealtimeSessionCreateResponse?.ToString() ??
            RealtimeTranscriptionSessionCreateResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeSessionCreateResponse || IsRealtimeTranscriptionSessionCreateResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeSessionCreateResponse?, TResult>? realtimeSessionCreateResponse = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse?, TResult>? realtimeTranscriptionSessionCreateResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeSessionCreateResponse && realtimeSessionCreateResponse != null)
            {
                return realtimeSessionCreateResponse(RealtimeSessionCreateResponse!);
            }
            else if (IsRealtimeTranscriptionSessionCreateResponse && realtimeTranscriptionSessionCreateResponse != null)
            {
                return realtimeTranscriptionSessionCreateResponse(RealtimeTranscriptionSessionCreateResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeSessionCreateResponse?>? realtimeSessionCreateResponse = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse?>? realtimeTranscriptionSessionCreateResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeSessionCreateResponse)
            {
                realtimeSessionCreateResponse?.Invoke(RealtimeSessionCreateResponse!);
            }
            else if (IsRealtimeTranscriptionSessionCreateResponse)
            {
                realtimeTranscriptionSessionCreateResponse?.Invoke(RealtimeTranscriptionSessionCreateResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RealtimeSessionCreateResponse,
                typeof(global::tryAGI.OpenAI.RealtimeSessionCreateResponse),
                RealtimeTranscriptionSessionCreateResponse,
                typeof(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeSessionCreateResponse?>.Default.Equals(RealtimeSessionCreateResponse, other.RealtimeSessionCreateResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse?>.Default.Equals(RealtimeTranscriptionSessionCreateResponse, other.RealtimeTranscriptionSessionCreateResponse) 
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
