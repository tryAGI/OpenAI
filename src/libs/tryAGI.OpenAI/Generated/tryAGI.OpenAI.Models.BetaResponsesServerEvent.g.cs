#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Server events emitted by the Responses WebSocket server.
    /// </summary>
    public readonly partial struct BetaResponsesServerEvent : global::System.IEquatable<BetaResponsesServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseStreamEvent? ResponseStream { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseStreamEvent? ResponseStream { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseStream))]
#endif
        public bool IsResponseStream => ResponseStream != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseStream(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseStreamEvent? value)
        {
            value = ResponseStream;
            return IsResponseStream;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseStreamEvent PickResponseStream() => IsResponseStream
            ? ResponseStream!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseStream' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when all injected input items were validated and committed to the<br/>
        /// active response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? ResponseInjectCreated { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? ResponseInjectCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseInjectCreated))]
#endif
        public bool IsResponseInjectCreated => ResponseInjectCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseInjectCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? value)
        {
            value = ResponseInjectCreated;
            return IsResponseInjectCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent PickResponseInjectCreated() => IsResponseInjectCreated
            ? ResponseInjectCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseInjectCreated' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when injected input could not be committed to a response. The event<br/>
        /// returns the uncommitted raw input so the client can retry it in another<br/>
        /// response when appropriate.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? ResponseInjectFailed { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? ResponseInjectFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseInjectFailed))]
#endif
        public bool IsResponseInjectFailed => ResponseInjectFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseInjectFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? value)
        {
            value = ResponseInjectFailed;
            return IsResponseInjectFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectFailedEvent PickResponseInjectFailed() => IsResponseInjectFailed
            ? ResponseInjectFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseInjectFailed' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseStreamEvent value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.BetaResponseStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseStreamEvent?(BetaResponsesServerEvent @this) => @this.ResponseStream;

        /// <summary>
        /// 
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseStreamEvent? value)
        {
            ResponseStream = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaResponsesServerEvent FromResponseStream(global::tryAGI.OpenAI.BetaResponseStreamEvent? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent?(BetaResponsesServerEvent @this) => @this.ResponseInjectCreated;

        /// <summary>
        /// 
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? value)
        {
            ResponseInjectCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaResponsesServerEvent FromResponseInjectCreated(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent value) => new BetaResponsesServerEvent((global::tryAGI.OpenAI.BetaResponseInjectFailedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseInjectFailedEvent?(BetaResponsesServerEvent @this) => @this.ResponseInjectFailed;

        /// <summary>
        /// 
        /// </summary>
        public BetaResponsesServerEvent(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? value)
        {
            ResponseInjectFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaResponsesServerEvent FromResponseInjectFailed(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? value) => new BetaResponsesServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaResponsesServerEvent(
            global::tryAGI.OpenAI.BetaResponseStreamEvent? responseStream,
            global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent? responseInjectCreated,
            global::tryAGI.OpenAI.BetaResponseInjectFailedEvent? responseInjectFailed
            )
        {
            ResponseStream = responseStream;
            ResponseInjectCreated = responseInjectCreated;
            ResponseInjectFailed = responseInjectFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponseInjectFailed as object ??
            ResponseInjectCreated as object ??
            ResponseStream as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseStream?.ToString() ??
            ResponseInjectCreated?.ToString() ??
            ResponseInjectFailed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseStream || IsResponseInjectCreated || IsResponseInjectFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaResponseStreamEvent?, TResult>? responseStream = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent, TResult>? responseInjectCreated = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseInjectFailedEvent, TResult>? responseInjectFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseStream && responseStream != null)
            {
                return responseStream(ResponseStream!);
            }
            else if (IsResponseInjectCreated && responseInjectCreated != null)
            {
                return responseInjectCreated(ResponseInjectCreated!);
            }
            else if (IsResponseInjectFailed && responseInjectFailed != null)
            {
                return responseInjectFailed(ResponseInjectFailed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseStreamEvent?>? responseStream = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent>? responseInjectCreated = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseInjectFailedEvent>? responseInjectFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseStream)
            {
                responseStream?.Invoke(ResponseStream!);
            }
            else if (IsResponseInjectCreated)
            {
                responseInjectCreated?.Invoke(ResponseInjectCreated!);
            }
            else if (IsResponseInjectFailed)
            {
                responseInjectFailed?.Invoke(ResponseInjectFailed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaResponseStreamEvent?>? responseStream = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent>? responseInjectCreated = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseInjectFailedEvent>? responseInjectFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseStream)
            {
                responseStream?.Invoke(ResponseStream!);
            }
            else if (IsResponseInjectCreated)
            {
                responseInjectCreated?.Invoke(ResponseInjectCreated!);
            }
            else if (IsResponseInjectFailed)
            {
                responseInjectFailed?.Invoke(ResponseInjectFailed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseStream,
                typeof(global::tryAGI.OpenAI.BetaResponseStreamEvent),
                ResponseInjectCreated,
                typeof(global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent),
                ResponseInjectFailed,
                typeof(global::tryAGI.OpenAI.BetaResponseInjectFailedEvent),
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
        public bool Equals(BetaResponsesServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseStreamEvent?>.Default.Equals(ResponseStream, other.ResponseStream) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseInjectCreatedEvent?>.Default.Equals(ResponseInjectCreated, other.ResponseInjectCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseInjectFailedEvent?>.Default.Equals(ResponseInjectFailed, other.ResponseInjectFailed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaResponsesServerEvent obj1, BetaResponsesServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponsesServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaResponsesServerEvent obj1, BetaResponsesServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponsesServerEvent o && Equals(o);
        }
    }
}
