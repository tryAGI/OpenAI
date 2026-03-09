#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Server events emitted by the Responses WebSocket server.
    /// </summary>
    public readonly partial struct ResponsesServerEvent : global::System.IEquatable<ResponsesServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponseStreamEvent? ResponseStream { get; init; }
#else
        public global::tryAGI.OpenAI.ResponseStreamEvent? ResponseStream { get; }
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
        public static implicit operator ResponsesServerEvent(global::tryAGI.OpenAI.ResponseStreamEvent value) => new ResponsesServerEvent((global::tryAGI.OpenAI.ResponseStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponseStreamEvent?(ResponsesServerEvent @this) => @this.ResponseStream;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesServerEvent(global::tryAGI.OpenAI.ResponseStreamEvent? value)
        {
            ResponseStream = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponseStream as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseStream?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseStream;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponseStreamEvent?, TResult>? responseStream = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponseStreamEvent?>? responseStream = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseStream,
                typeof(global::tryAGI.OpenAI.ResponseStreamEvent),
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
        public bool Equals(ResponsesServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponseStreamEvent?>.Default.Equals(ResponseStream, other.ResponseStream) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesServerEvent obj1, ResponsesServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesServerEvent obj1, ResponsesServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesServerEvent o && Equals(o);
        }
    }
}
