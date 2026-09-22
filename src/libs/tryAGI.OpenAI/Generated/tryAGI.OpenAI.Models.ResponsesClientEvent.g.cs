#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Client events accepted by the Responses WebSocket server.
    /// </summary>
    public readonly partial struct ResponsesClientEvent : global::System.IEquatable<ResponsesClientEvent>
    {
        /// <summary>
        /// Client event for creating a response over a persistent WebSocket connection.<br/>
        /// This payload uses the same top-level fields as `POST /v1/responses`, plus<br/>
        /// WebSocket-only envelope metadata.<br/>
        /// Notes:<br/>
        /// - `stream` is implicit over WebSocket and should not be sent.<br/>
        /// - `background` is not supported over WebSocket.<br/>
        /// - `stream_id` is WebSocket-only and is not part of `POST /v1/responses`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreate? ResponseCreate { get; init; }
#else
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreate? ResponseCreate { get; }
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
            out global::tryAGI.OpenAI.ResponsesClientEventResponseCreate? value)
        {
            value = ResponseCreate;
            return IsResponseCreate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreate PickResponseCreate() => IsResponseCreate
            ? ResponseCreate!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseCreate' but the value was {ToString()}.");

        /// <summary>
        /// Queues user input to steer a response on this WebSocket connection. Input<br/>
        /// can contain text, images, and files. Steering is supported only for<br/>
        /// single-agent responses on models and execution modes that support steering.<br/>
        /// Responses bound to a conversation or using automatic compaction do not<br/>
        /// support steering.<br/>
        /// A `response.steer.accepted` event acknowledges that the server owns the<br/>
        /// queued input, not that it has been applied. The successor's `response.created`<br/>
        /// event is the commit point. Input that cannot be committed is returned in<br/>
        /// `response.steer.failed`.<br/>
        /// Steering may cause the active response to finish at a safe output boundary<br/>
        /// with `response.incomplete` and `incomplete_details.reason` set to `steered`,<br/>
        /// followed automatically by a successor `response.created`. Normal completion<br/>
        /// can also be followed by an automatic successor. Automatic successors inherit<br/>
        /// the previous response's settings and continue from it with the queued input.<br/>
        /// If the response stops for client-owned tool output or approval, accepted<br/>
        /// steering input remains queued and `response.steer.pending` is emitted after<br/>
        /// `response.completed`. Fill the `required_input` stubs from that event with<br/>
        /// saved tool results or approval decisions, and send one explicit<br/>
        /// `response.create` per parent with the same `previous_response_id` and<br/>
        /// WebSocket lane. Do not rerun tools or resend accepted steering input. The<br/>
        /// queued input is prepended in submission order to that request's input, and<br/>
        /// the explicit request retains its own settings.<br/>
        /// This event accepts only `type`, `previous_response_id`, and `input`. Do not<br/>
        /// send `stream_id`; the target response determines the WebSocket lane.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseSteerEvent? ResponseSteer { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseSteerEvent? ResponseSteer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseSteer))]
#endif
        public bool IsResponseSteer => ResponseSteer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseSteer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ResponseSteerEvent? value)
        {
            value = ResponseSteer;
            return IsResponseSteer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.ResponseSteerEvent PickResponseSteer() => IsResponseSteer
            ? ResponseSteer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseSteer' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesClientEvent(global::tryAGI.OpenAI.ResponsesClientEventResponseCreate value) => new ResponsesClientEvent((global::tryAGI.OpenAI.ResponsesClientEventResponseCreate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponsesClientEventResponseCreate?(ResponsesClientEvent @this) => @this.ResponseCreate;

        /// <summary>
        ///
        /// </summary>
        public ResponsesClientEvent(global::tryAGI.OpenAI.ResponsesClientEventResponseCreate? value)
        {
            ResponseCreate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesClientEvent FromResponseCreate(global::tryAGI.OpenAI.ResponsesClientEventResponseCreate? value) => new ResponsesClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponsesClientEvent(global::tryAGI.OpenAI.ResponseSteerEvent value) => new ResponsesClientEvent((global::tryAGI.OpenAI.ResponseSteerEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseSteerEvent?(ResponsesClientEvent @this) => @this.ResponseSteer;

        /// <summary>
        ///
        /// </summary>
        public ResponsesClientEvent(global::tryAGI.OpenAI.ResponseSteerEvent? value)
        {
            ResponseSteer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponsesClientEvent FromResponseSteer(global::tryAGI.OpenAI.ResponseSteerEvent? value) => new ResponsesClientEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ResponsesClientEvent(
            global::tryAGI.OpenAI.ResponsesClientEventResponseCreate? responseCreate,
            global::tryAGI.OpenAI.ResponseSteerEvent? responseSteer
            )
        {
            ResponseCreate = responseCreate;
            ResponseSteer = responseSteer;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseSteer as object ??
            ResponseCreate as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ResponseCreate?.ToString() ??
            ResponseSteer?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsResponseCreate || IsResponseSteer;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponsesClientEventResponseCreate?, TResult>? responseCreate = null,
            global::System.Func<global::tryAGI.OpenAI.ResponseSteerEvent, TResult>? responseSteer = null,
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
            else if (IsResponseSteer && responseSteer != null)
            {
                return responseSteer(ResponseSteer!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponsesClientEventResponseCreate?>? responseCreate = null,

            global::System.Action<global::tryAGI.OpenAI.ResponseSteerEvent>? responseSteer = null,
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
            else if (IsResponseSteer)
            {
                responseSteer?.Invoke(ResponseSteer!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.ResponsesClientEventResponseCreate?>? responseCreate = null,
            global::System.Action<global::tryAGI.OpenAI.ResponseSteerEvent>? responseSteer = null,
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
            else if (IsResponseSteer)
            {
                responseSteer?.Invoke(ResponseSteer!);
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
                typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreate),
                ResponseSteer,
                typeof(global::tryAGI.OpenAI.ResponseSteerEvent),
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
        public bool Equals(ResponsesClientEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponsesClientEventResponseCreate?>.Default.Equals(ResponseCreate, other.ResponseCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseSteerEvent?>.Default.Equals(ResponseSteer, other.ResponseSteer)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponsesClientEvent obj1, ResponsesClientEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesClientEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponsesClientEvent obj1, ResponsesClientEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesClientEvent o && Equals(o);
        }
    }
}
