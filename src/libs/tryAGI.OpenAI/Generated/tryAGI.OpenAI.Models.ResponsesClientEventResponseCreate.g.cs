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
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? Value1 { get; init; }
#else
        public global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CreateResponse? Value2 { get; init; }
#else
        public global::tryAGI.OpenAI.CreateResponse? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesClientEventResponseCreate(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1 value) => new ResponsesClientEventResponseCreate((global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1?(ResponsesClientEventResponseCreate @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClientEventResponseCreate(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesClientEventResponseCreate(global::tryAGI.OpenAI.CreateResponse value) => new ResponsesClientEventResponseCreate((global::tryAGI.OpenAI.CreateResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CreateResponse?(ResponsesClientEventResponseCreate @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClientEventResponseCreate(global::tryAGI.OpenAI.CreateResponse? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClientEventResponseCreate(
            global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1? value1,
            global::tryAGI.OpenAI.CreateResponse? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1?, TResult>? value1 = null,
            global::System.Func<global::tryAGI.OpenAI.CreateResponse?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1?>? value1 = null,
            global::System.Action<global::tryAGI.OpenAI.CreateResponse?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1),
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ResponsesClientEventResponseCreateVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CreateResponse?>.Default.Equals(Value2, other.Value2) 
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
