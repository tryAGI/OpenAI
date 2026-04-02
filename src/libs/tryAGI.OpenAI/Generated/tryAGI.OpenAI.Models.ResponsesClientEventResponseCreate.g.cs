#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Client event for creating a response over a persistent WebSocket connection.<br/>
    /// This payload uses the same top-level fields as `POST /v1/responses`.<br/>
    /// Notes:<br/>
    /// - `stream` is implicit over WebSocket and should not be sent.<br/>
    /// - `background` is not supported over WebSocket.
    /// </summary>
    public readonly partial struct ResponsesClientEventResponseCreate : global::System.IEquatable<ResponsesClientEventResponseCreate>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? ResponsesClientEventResponseCreateVariant1 { get; init; }
#else
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? ResponsesClientEventResponseCreateVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesClientEventResponseCreateVariant1))]
#endif
        public bool IsResponsesClientEventResponseCreateVariant1 => ResponsesClientEventResponseCreateVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateResponse? CreateResponse { get; init; }
#else
        public global::tryAGI.OpenAI.CreateResponse? CreateResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateResponse))]
#endif
        public bool IsCreateResponse => CreateResponse != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesClientEventResponseCreate(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1 value) => new ResponsesClientEventResponseCreate((global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1?(ResponsesClientEventResponseCreate @this) => @this.ResponsesClientEventResponseCreateVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClientEventResponseCreate(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? value)
        {
            ResponsesClientEventResponseCreateVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesClientEventResponseCreate(global::tryAGI.OpenAI.CreateResponse value) => new ResponsesClientEventResponseCreate((global::tryAGI.OpenAI.CreateResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateResponse?(ResponsesClientEventResponseCreate @this) => @this.CreateResponse;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClientEventResponseCreate(global::tryAGI.OpenAI.CreateResponse? value)
        {
            CreateResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClientEventResponseCreate(
            global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? responsesClientEventResponseCreateVariant1,
            global::tryAGI.OpenAI.CreateResponse? createResponse
            )
        {
            ResponsesClientEventResponseCreateVariant1 = responsesClientEventResponseCreateVariant1;
            CreateResponse = createResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateResponse as object ??
            ResponsesClientEventResponseCreateVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponsesClientEventResponseCreateVariant1?.ToString() ??
            CreateResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponsesClientEventResponseCreateVariant1 && IsCreateResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1?, TResult>? responsesClientEventResponseCreateVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.CreateResponse?, TResult>? createResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesClientEventResponseCreateVariant1 && responsesClientEventResponseCreateVariant1 != null)
            {
                return responsesClientEventResponseCreateVariant1(ResponsesClientEventResponseCreateVariant1!);
            }
            else if (IsCreateResponse && createResponse != null)
            {
                return createResponse(CreateResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1?>? responsesClientEventResponseCreateVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.CreateResponse?>? createResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesClientEventResponseCreateVariant1)
            {
                responsesClientEventResponseCreateVariant1?.Invoke(ResponsesClientEventResponseCreateVariant1!);
            }
            else if (IsCreateResponse)
            {
                createResponse?.Invoke(CreateResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponsesClientEventResponseCreateVariant1,
                typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1),
                CreateResponse,
                typeof(global::tryAGI.OpenAI.CreateResponse),
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
        public bool Equals(ResponsesClientEventResponseCreate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1?>.Default.Equals(ResponsesClientEventResponseCreateVariant1, other.ResponsesClientEventResponseCreateVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateResponse?>.Default.Equals(CreateResponse, other.CreateResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesClientEventResponseCreate obj1, ResponsesClientEventResponseCreate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesClientEventResponseCreate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesClientEventResponseCreate obj1, ResponsesClientEventResponseCreate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesClientEventResponseCreate o && Equals(o);
        }
    }
}
