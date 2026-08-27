#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Client events accepted by the Responses WebSocket server.
    /// </summary>
    public readonly partial struct BetaResponsesClientEvent : global::System.IEquatable<BetaResponsesClientEvent>
    {
        /// <summary>
        /// Client event for creating a response over a persistent WebSocket connection.<br/>
        /// This payload uses the same top-level fields as `POST /v1/responses`.<br/>
        /// Notes:<br/>
        /// - `stream` is implicit over WebSocket and should not be sent.<br/>
        /// - `background` is not supported over WebSocket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate? ResponseCreate { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate? ResponseCreate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseCreate))]
#endif
        public bool IsResponseCreate => ResponseCreate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate? value)
        {
            value = ResponseCreate;
            return IsResponseCreate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate PickResponseCreate() => IsResponseCreate
            ? ResponseCreate!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCreate' but the value was {ToString()}.");

        /// <summary>
        /// Injects input items into an active response over a WebSocket connection.<br/>
        /// The items are validated and committed atomically. Currently, the server<br/>
        /// accepts client-owned tool outputs that resume a waiting agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaResponseInjectEvent? ResponseInject { get; init; }
#else
        public global::tryAGI.OpenAI.BetaResponseInjectEvent? ResponseInject { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseInject))]
#endif
        public bool IsResponseInject => ResponseInject != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseInject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaResponseInjectEvent? value)
        {
            value = ResponseInject;
            return IsResponseInject;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaResponseInjectEvent PickResponseInject() => IsResponseInject
            ? ResponseInject!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseInject' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesClientEvent(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate value) => new BetaResponsesClientEvent((global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate?(BetaResponsesClientEvent @this) => @this.ResponseCreate;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesClientEvent(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate? value)
        {
            ResponseCreate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesClientEvent FromResponseCreate(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate? value) => new BetaResponsesClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponsesClientEvent(global::tryAGI.OpenAI.BetaResponseInjectEvent value) => new BetaResponsesClientEvent((global::tryAGI.OpenAI.BetaResponseInjectEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaResponseInjectEvent?(BetaResponsesClientEvent @this) => @this.ResponseInject;

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesClientEvent(global::tryAGI.OpenAI.BetaResponseInjectEvent? value)
        {
            ResponseInject = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponsesClientEvent FromResponseInject(global::tryAGI.OpenAI.BetaResponseInjectEvent? value) => new BetaResponsesClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public BetaResponsesClientEvent(
            global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate? responseCreate,
            global::tryAGI.OpenAI.BetaResponseInjectEvent? responseInject
            )
        {
            ResponseCreate = responseCreate;
            ResponseInject = responseInject;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseInject as object ??
            ResponseCreate as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ResponseCreate?.ToString() ??
            ResponseInject?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsResponseCreate || IsResponseInject;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate?, TResult>? responseCreate = null,
            global::System.Func<global::tryAGI.OpenAI.BetaResponseInjectEvent, TResult>? responseInject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseCreate && responseCreate != null)
            {
                return responseCreate(ResponseCreate!);
            }
            else if (IsResponseInject && responseInject != null)
            {
                return responseInject(ResponseInject!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate?>? responseCreate = null,

            global::System.Action<global::tryAGI.OpenAI.BetaResponseInjectEvent>? responseInject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseCreate)
            {
                responseCreate?.Invoke(ResponseCreate!);
            }
            else if (IsResponseInject)
            {
                responseInject?.Invoke(ResponseInject!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate?>? responseCreate = null,
            global::System.Action<global::tryAGI.OpenAI.BetaResponseInjectEvent>? responseInject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseCreate)
            {
                responseCreate?.Invoke(ResponseCreate!);
            }
            else if (IsResponseInject)
            {
                responseInject?.Invoke(ResponseInject!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseCreate,
                typeof(global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate),
                ResponseInject,
                typeof(global::tryAGI.OpenAI.BetaResponseInjectEvent),
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
        public bool Equals(BetaResponsesClientEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponsesClientEventResponseCreate?>.Default.Equals(ResponseCreate, other.ResponseCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaResponseInjectEvent?>.Default.Equals(ResponseInject, other.ResponseInject)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponsesClientEvent obj1, BetaResponsesClientEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponsesClientEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponsesClientEvent obj1, BetaResponsesClientEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponsesClientEvent o && Equals(o);
        }
    }
}
