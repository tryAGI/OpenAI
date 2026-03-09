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
        /// This payload uses the same top-level fields as `POST /v1/responses`.<br/>
        /// Notes:<br/>
        /// - `stream` is implicit over WebSocket and should not be sent.<br/>
        /// - `background` is not supported over WebSocket.
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
        public object? Object =>
            ResponseCreate as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseCreate?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseCreate;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponsesClientEventResponseCreate?, TResult>? responseCreate = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponsesClientEventResponseCreate?>? responseCreate = null,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponsesClientEventResponseCreate?>.Default.Equals(ResponseCreate, other.ResponseCreate) 
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
